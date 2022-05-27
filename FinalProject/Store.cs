using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Store : System.Windows.Forms.Form
    {
        public Store()
        {
            InitializeComponent();
            panel_signIn.Parent = theStore;
            panel_order.Parent = theStore;
            panel_orderResponse.Parent = theStore;
            panel_payment.Parent = theStore;
        }

        private void OnSignInClicked(object sender, EventArgs e)
        {

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var userName = context.CUSTOMERs.Where(u => u.CustUsername == $"{input_username.Text}"
                    && u.CustPassword == $"{input_password.Text}").Select(u => u.CustUsername);

                if (userName.ToArray().Length == 0)
                {
                    label_invalidUsernamePassword.Show();
                }
                else
                {
                    panel_signIn.Hide();
                    button_order.Show();
                    button_payBill.Show();
                    button_viewOrders.Show();
                    panel_order.Show();
                }
            }
        }


        private void OnReenterUsername(object sender, KeyPressEventArgs e)
        {
            label_invalidUsernamePassword.Hide();
        }

        private void OnReenterPassword(object sender, EventArgs e)
        {
            label_invalidUsernamePassword.Hide();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet3.PURCHASE' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'storeDBDataSet3.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter1.Fill(this.storeDBDataSet3.ITEM);
            // TODO: This line of code loads data into the 'storeDBDataSet2.PURCHASE' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'storeDBDataSet1.PURCHASE' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'storeDBDataSet.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter.Fill(this.storeDBDataSet.ITEM);

        }

        private void OnSubmitOrderClicked(object sender, EventArgs e)
        {
            label_noItemsAdded.Hide();
            decimal cost = GetCost();
            if (cost == 0)
            {
                label_noItemsAdded.Show();
            }
            else
            {
                panel_orderResponse.Show();
                panel_order.Hide();
                if (VerifyFunds(cost))
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        var updateBal = context.CUSTOMERs.Single(c => c.CustID == GetCustID());
                        updateBal.CustCurrBalance += cost;
                        context.SubmitChanges();
                    }
                    AddPurchase();
                    AddPurchaseItems();
                }
            }
        }

        private void AddPurchaseItems()
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var pid = context.PURCHASEs.Max(p => p.PurchaseID);
                for (int i = 0; i < dataview_itemsTable.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataview_itemsTable.Rows[i].Cells[3].Value))
                    {
                        if (dataview_itemsTable.Rows[i].Cells[2].Value != null)
                        {
                            string item = dataview_itemsTable.Rows[i].Cells[0].Value.ToString();
                            var iid = context.ITEMs.Where(d => d.ItemDescription == $"{item}").Select(d => d.ItemID).First();


                            int qty = int.Parse(dataview_itemsTable.Rows[i].Cells[2].Value.ToString());
                            PURCHASE_ITEM pItem = new PURCHASE_ITEM
                            {
                                CustID = GetCustID(),
                                PurchaseID = pid,
                                ItemID = iid,
                                Qty = qty
                            };
                            context.PURCHASE_ITEMs.InsertOnSubmit(pItem);
                            context.SubmitChanges();

                        }
                    }
                }
            }
        }

        private void AddPurchase()
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                PURCHASE purch = new PURCHASE
                {
                    CustID = GetCustID(),
                    OrderTotal = GetCost()
                };
                context.PURCHASEs.InsertOnSubmit(purch);
                context.SubmitChanges();
            }
        }

        private int GetCustID()
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var uid = context.CUSTOMERs.Where(c => c.CustUsername == input_username.Text
                && c.CustPassword == input_password.Text).Select(c => c.CustID).First();
                return uid;
            }
        }

        private decimal GetCost()
        {
            decimal cost = 0;
            for (int i = 0; i < dataview_itemsTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataview_itemsTable.Rows[i].Cells[3].Value))
                {
                    decimal price = Convert.ToDecimal(dataview_itemsTable.Rows[i].Cells[1].Value.ToString());
                    int qty = Convert.ToInt32(dataview_itemsTable.Rows[i].Cells[2].Value);
                    cost += price * qty;
                }
            }
            return cost;
        }

        private bool VerifyFunds(decimal cost)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                label_insufficientFunds.Hide();
                label_sufficientFunds.Hide();
                var verify = context.CUSTOMERs.Where(c => c.CustID == GetCustID()).Select(c => new { c.CustCurrBalance, c.CustCreditLimit }).First();
                panel_order.Hide();
                decimal bal = Convert.ToDecimal(verify.CustCurrBalance);
                if (bal + cost > Convert.ToDecimal(verify.CustCreditLimit))
                {
                    label_insufficientFunds.Show();
                    return false;
                }
                else
                {
                    label_sufficientFunds.Show();
                    return true;
                }
            }
        }

        private void OnOrderClicked(object sender, EventArgs e)
        {
            panel_payment.Hide();
            panel_order.Show();
            panel_orderResponse.Hide();
            panel_purchases.Hide();

        }

        private void OnPayBillClicked(object sender, EventArgs e)
        {
            panel_order.Hide();
            panel_purchases.Hide();
            panel_payment.Show();
            panel_orderResponse.Hide();
            GetCurrBalance();
        }

        private void GetCurrBalance()
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var balance = context.CUSTOMERs.Where(c => c.CustID == GetCustID()).Select(c => c.CustCurrBalance).First();
                label_currBalance.Text = $"{balance}";
            }
        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            label_subtotalAmount.Text = $"${GetCost()}";
            label_noItemsAdded.Hide();
        }

        private void OnSubmitPaymentClicked(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var updateBal = context.CUSTOMERs.Single(c => c.CustID == GetCustID());
                updateBal.CustCurrBalance -= numericUpDown_pricePicker.Value;
                context.SubmitChanges();
            }
                
            GetCurrBalance();
        }

        private void OnViewOrdersClicked(object sender, EventArgs e)
        {
            panel_purchases.Show();
            panel_order.Hide();
            panel_orderResponse.Hide();
            panel_payment.Hide();
            FillPurchaseTable();
            dateTimePicker_maxDate.Value = DateTime.Today.AddDays(1);
            textBox_min.Text = "0.00";
            textBox_max.Text = "100.00";
        }

        private void FillPurchaseTable()
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var purchases = context.PURCHASE_ITEMs.Where(p => p.CustID == GetCustID())
                    .Select(p => new
                    {
                        Purchase = p.PurchaseID,
                        Item = context.ITEMs
                    .Single(i => i.ItemID == p.ItemID).ItemDescription,
                        p.Qty,
                        Order_Total = context.PURCHASEs.Single(purch => p.PurchaseID == purch.PurchaseID).OrderTotal,
                        Date = context.PURCHASEs.Single(purch => p.PurchaseID == purch.PurchaseID).PurchaseDate
            });

                purchases.AsQueryable();
                dataGridView_purchases.DataSource = purchases;
            }
        }

        private void OnFilterClicked(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var purchases = context.PURCHASE_ITEMs.Where(p => p.CustID == GetCustID())
                    .Select(p => new {
                        Purchase = p.PurchaseID,
                        Item = context.ITEMs
                    .Single(i => i.ItemID == p.ItemID).ItemDescription,
                        p.Qty,
                        Order_Total = context.PURCHASEs.Single(purch => p.PurchaseID == purch.PurchaseID).OrderTotal,
                        Date = context.PURCHASEs.Single(purch => p.PurchaseID == purch.PurchaseID).PurchaseDate
                    });

                if (radioButton_filterTotal.Checked)
                {
                    if (textBox_min.Text == "" || textBox_max.Text == "")
                    {
                        label_enterVals.Show();
                    }
                    else
                    {
                        label_enterVals.Hide();
                        var min = Convert.ToDecimal(textBox_min.Text);
                        var max = Convert.ToDecimal(textBox_max.Text);
                        purchases = purchases.Where(o => o.Order_Total >= min && o.Order_Total <= max);
                    }
                }
                if (radioButton_filterDate.Checked)
                {
                    if (dateTimePicker_minDate.Value > dateTimePicker_maxDate.Value)
                    {
                        label_enterVals.Show();
                    }
                    else
                    {
                        label_enterVals.Hide();
                        var min = dateTimePicker_minDate.Value;
                        var max = dateTimePicker_maxDate.Value;
                        purchases = purchases.Where(o => o.Date >= min && o.Date <= max);
                    }
                }
                purchases.AsQueryable();
                dataGridView_purchases.DataSource = purchases;
            }
        }
    }
}
