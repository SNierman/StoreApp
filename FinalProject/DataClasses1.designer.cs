﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StoreDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCUSTOMER(CUSTOMER instance);
    partial void UpdateCUSTOMER(CUSTOMER instance);
    partial void DeleteCUSTOMER(CUSTOMER instance);
    partial void InsertITEM(ITEM instance);
    partial void UpdateITEM(ITEM instance);
    partial void DeleteITEM(ITEM instance);
    partial void InsertPURCHASE_ITEM(PURCHASE_ITEM instance);
    partial void UpdatePURCHASE_ITEM(PURCHASE_ITEM instance);
    partial void DeletePURCHASE_ITEM(PURCHASE_ITEM instance);
    partial void InsertPURCHASE(PURCHASE instance);
    partial void UpdatePURCHASE(PURCHASE instance);
    partial void DeletePURCHASE(PURCHASE instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::FinalProject.Properties.Settings.Default.StoreDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this.GetTable<CUSTOMER>();
			}
		}
		
		public System.Data.Linq.Table<ITEM> ITEMs
		{
			get
			{
				return this.GetTable<ITEM>();
			}
		}
		
		public System.Data.Linq.Table<PURCHASE_ITEM> PURCHASE_ITEMs
		{
			get
			{
				return this.GetTable<PURCHASE_ITEM>();
			}
		}
		
		public System.Data.Linq.Table<PURCHASE> PURCHASEs
		{
			get
			{
				return this.GetTable<PURCHASE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUSTOMER")]
	public partial class CUSTOMER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustID;
		
		private string _CustUsername;
		
		private string _CustPassword;
		
		private decimal _CustCreditLimit;
		
		private decimal _CustCurrBalance;
		
		private EntitySet<PURCHASE_ITEM> _PURCHASE_ITEMs;
		
		private EntitySet<PURCHASE> _PURCHASEs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustIDChanging(int value);
    partial void OnCustIDChanged();
    partial void OnCustUsernameChanging(string value);
    partial void OnCustUsernameChanged();
    partial void OnCustPasswordChanging(string value);
    partial void OnCustPasswordChanged();
    partial void OnCustCreditLimitChanging(decimal value);
    partial void OnCustCreditLimitChanged();
    partial void OnCustCurrBalanceChanging(decimal value);
    partial void OnCustCurrBalanceChanged();
    #endregion
		
		public CUSTOMER()
		{
			this._PURCHASE_ITEMs = new EntitySet<PURCHASE_ITEM>(new Action<PURCHASE_ITEM>(this.attach_PURCHASE_ITEMs), new Action<PURCHASE_ITEM>(this.detach_PURCHASE_ITEMs));
			this._PURCHASEs = new EntitySet<PURCHASE>(new Action<PURCHASE>(this.attach_PURCHASEs), new Action<PURCHASE>(this.detach_PURCHASEs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustUsername", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CustUsername
		{
			get
			{
				return this._CustUsername;
			}
			set
			{
				if ((this._CustUsername != value))
				{
					this.OnCustUsernameChanging(value);
					this.SendPropertyChanging();
					this._CustUsername = value;
					this.SendPropertyChanged("CustUsername");
					this.OnCustUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustPassword", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CustPassword
		{
			get
			{
				return this._CustPassword;
			}
			set
			{
				if ((this._CustPassword != value))
				{
					this.OnCustPasswordChanging(value);
					this.SendPropertyChanging();
					this._CustPassword = value;
					this.SendPropertyChanged("CustPassword");
					this.OnCustPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustCreditLimit", DbType="Decimal(8,2) NOT NULL")]
		public decimal CustCreditLimit
		{
			get
			{
				return this._CustCreditLimit;
			}
			set
			{
				if ((this._CustCreditLimit != value))
				{
					this.OnCustCreditLimitChanging(value);
					this.SendPropertyChanging();
					this._CustCreditLimit = value;
					this.SendPropertyChanged("CustCreditLimit");
					this.OnCustCreditLimitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustCurrBalance", DbType="Decimal(8,2) NOT NULL")]
		public decimal CustCurrBalance
		{
			get
			{
				return this._CustCurrBalance;
			}
			set
			{
				if ((this._CustCurrBalance != value))
				{
					this.OnCustCurrBalanceChanging(value);
					this.SendPropertyChanging();
					this._CustCurrBalance = value;
					this.SendPropertyChanged("CustCurrBalance");
					this.OnCustCurrBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_PURCHASE_ITEM", Storage="_PURCHASE_ITEMs", ThisKey="CustID", OtherKey="CustID")]
		public EntitySet<PURCHASE_ITEM> PURCHASE_ITEMs
		{
			get
			{
				return this._PURCHASE_ITEMs;
			}
			set
			{
				this._PURCHASE_ITEMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_PURCHASE", Storage="_PURCHASEs", ThisKey="CustID", OtherKey="CustID")]
		public EntitySet<PURCHASE> PURCHASEs
		{
			get
			{
				return this._PURCHASEs;
			}
			set
			{
				this._PURCHASEs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
		
		private void attach_PURCHASEs(PURCHASE entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_PURCHASEs(PURCHASE entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITEM")]
	public partial class ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemID;
		
		private string _ItemDescription;
		
		private decimal _ItemCost;
		
		private EntitySet<PURCHASE_ITEM> _PURCHASE_ITEMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnItemDescriptionChanging(string value);
    partial void OnItemDescriptionChanged();
    partial void OnItemCostChanging(decimal value);
    partial void OnItemCostChanged();
    #endregion
		
		public ITEM()
		{
			this._PURCHASE_ITEMs = new EntitySet<PURCHASE_ITEM>(new Action<PURCHASE_ITEM>(this.attach_PURCHASE_ITEMs), new Action<PURCHASE_ITEM>(this.detach_PURCHASE_ITEMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemDescription", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ItemDescription
		{
			get
			{
				return this._ItemDescription;
			}
			set
			{
				if ((this._ItemDescription != value))
				{
					this.OnItemDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ItemDescription = value;
					this.SendPropertyChanged("ItemDescription");
					this.OnItemDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemCost", DbType="Decimal(8,2) NOT NULL")]
		public decimal ItemCost
		{
			get
			{
				return this._ItemCost;
			}
			set
			{
				if ((this._ItemCost != value))
				{
					this.OnItemCostChanging(value);
					this.SendPropertyChanging();
					this._ItemCost = value;
					this.SendPropertyChanged("ItemCost");
					this.OnItemCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_PURCHASE_ITEM", Storage="_PURCHASE_ITEMs", ThisKey="ItemID", OtherKey="ItemID")]
		public EntitySet<PURCHASE_ITEM> PURCHASE_ITEMs
		{
			get
			{
				return this._PURCHASE_ITEMs;
			}
			set
			{
				this._PURCHASE_ITEMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = this;
		}
		
		private void detach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.ITEM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PURCHASE_ITEM")]
	public partial class PURCHASE_ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseItemID;
		
		private System.Nullable<int> _PurchaseID;
		
		private System.Nullable<int> _ItemID;
		
		private System.Nullable<int> _Qty;
		
		private System.Nullable<int> _CustID;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
		private EntityRef<ITEM> _ITEM;
		
		private EntityRef<PURCHASE> _PURCHASE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseItemIDChanging(int value);
    partial void OnPurchaseItemIDChanged();
    partial void OnPurchaseIDChanging(System.Nullable<int> value);
    partial void OnPurchaseIDChanged();
    partial void OnItemIDChanging(System.Nullable<int> value);
    partial void OnItemIDChanged();
    partial void OnQtyChanging(System.Nullable<int> value);
    partial void OnQtyChanged();
    partial void OnCustIDChanging(System.Nullable<int> value);
    partial void OnCustIDChanged();
    #endregion
		
		public PURCHASE_ITEM()
		{
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			this._ITEM = default(EntityRef<ITEM>);
			this._PURCHASE = default(EntityRef<PURCHASE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PurchaseItemID
		{
			get
			{
				return this._PurchaseItemID;
			}
			set
			{
				if ((this._PurchaseItemID != value))
				{
					this.OnPurchaseItemIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseItemID = value;
					this.SendPropertyChanged("PurchaseItemID");
					this.OnPurchaseItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseID", DbType="Int")]
		public System.Nullable<int> PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					if (this._PURCHASE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int")]
		public System.Nullable<int> ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					if (this._ITEM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int")]
		public System.Nullable<int> Qty
		{
			get
			{
				return this._Qty;
			}
			set
			{
				if ((this._Qty != value))
				{
					this.OnQtyChanging(value);
					this.SendPropertyChanging();
					this._Qty = value;
					this.SendPropertyChanged("Qty");
					this.OnQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="Int")]
		public System.Nullable<int> CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_PURCHASE_ITEM", Storage="_CUSTOMER", ThisKey="CustID", OtherKey="CustID", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.PURCHASE_ITEMs.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.PURCHASE_ITEMs.Add(this);
						this._CustID = value.CustID;
					}
					else
					{
						this._CustID = default(Nullable<int>);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ITEM_PURCHASE_ITEM", Storage="_ITEM", ThisKey="ItemID", OtherKey="ItemID", IsForeignKey=true)]
		public ITEM ITEM
		{
			get
			{
				return this._ITEM.Entity;
			}
			set
			{
				ITEM previousValue = this._ITEM.Entity;
				if (((previousValue != value) 
							|| (this._ITEM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ITEM.Entity = null;
						previousValue.PURCHASE_ITEMs.Remove(this);
					}
					this._ITEM.Entity = value;
					if ((value != null))
					{
						value.PURCHASE_ITEMs.Add(this);
						this._ItemID = value.ItemID;
					}
					else
					{
						this._ItemID = default(Nullable<int>);
					}
					this.SendPropertyChanged("ITEM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PURCHASE_PURCHASE_ITEM", Storage="_PURCHASE", ThisKey="PurchaseID", OtherKey="PurchaseID", IsForeignKey=true)]
		public PURCHASE PURCHASE
		{
			get
			{
				return this._PURCHASE.Entity;
			}
			set
			{
				PURCHASE previousValue = this._PURCHASE.Entity;
				if (((previousValue != value) 
							|| (this._PURCHASE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PURCHASE.Entity = null;
						previousValue.PURCHASE_ITEMs.Remove(this);
					}
					this._PURCHASE.Entity = value;
					if ((value != null))
					{
						value.PURCHASE_ITEMs.Add(this);
						this._PurchaseID = value.PurchaseID;
					}
					else
					{
						this._PurchaseID = default(Nullable<int>);
					}
					this.SendPropertyChanged("PURCHASE");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PURCHASE")]
	public partial class PURCHASE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseID;
		
		private int _CustID;
		
		private decimal _OrderTotal;
		
		private System.DateTime _PurchaseDate = default(System.DateTime);
		
		private EntitySet<PURCHASE_ITEM> _PURCHASE_ITEMs;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseIDChanging(int value);
    partial void OnPurchaseIDChanged();
    partial void OnCustIDChanging(int value);
    partial void OnCustIDChanged();
    partial void OnOrderTotalChanging(decimal value);
    partial void OnOrderTotalChanged();
    #endregion
		
		public PURCHASE()
		{
			this._PURCHASE_ITEMs = new EntitySet<PURCHASE_ITEM>(new Action<PURCHASE_ITEM>(this.attach_PURCHASE_ITEMs), new Action<PURCHASE_ITEM>(this.detach_PURCHASE_ITEMs));
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="Int NOT NULL")]
		public int CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderTotal", DbType="Decimal(8,2) NOT NULL")]
		public decimal OrderTotal
		{
			get
			{
				return this._OrderTotal;
			}
			set
			{
				if ((this._OrderTotal != value))
				{
					this.OnOrderTotalChanging(value);
					this.SendPropertyChanging();
					this._OrderTotal = value;
					this.SendPropertyChanged("OrderTotal");
					this.OnOrderTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseDate", AutoSync=AutoSync.Always, DbType="DateTime NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.DateTime PurchaseDate
		{
			get
			{
				return this._PurchaseDate;
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PURCHASE_PURCHASE_ITEM", Storage="_PURCHASE_ITEMs", ThisKey="PurchaseID", OtherKey="PurchaseID")]
		public EntitySet<PURCHASE_ITEM> PURCHASE_ITEMs
		{
			get
			{
				return this._PURCHASE_ITEMs;
			}
			set
			{
				this._PURCHASE_ITEMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_PURCHASE", Storage="_CUSTOMER", ThisKey="CustID", OtherKey="CustID", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.PURCHASEs.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.PURCHASEs.Add(this);
						this._CustID = value.CustID;
					}
					else
					{
						this._CustID = default(int);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.PURCHASE = this;
		}
		
		private void detach_PURCHASE_ITEMs(PURCHASE_ITEM entity)
		{
			this.SendPropertyChanging();
			entity.PURCHASE = null;
		}
	}
}
#pragma warning restore 1591