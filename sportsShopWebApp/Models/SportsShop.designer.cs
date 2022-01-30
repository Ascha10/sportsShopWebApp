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

namespace sportsShopWebApp.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sportsShopDB")]
	public partial class SportsShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertsportsEquipment(sportsEquipment instance);
    partial void UpdatesportsEquipment(sportsEquipment instance);
    partial void DeletesportsEquipment(sportsEquipment instance);
    partial void InsertSportsClub(SportsClub instance);
    partial void UpdateSportsClub(SportsClub instance);
    partial void DeleteSportsClub(SportsClub instance);
    partial void InsertShoe(Shoe instance);
    partial void UpdateShoe(Shoe instance);
    partial void DeleteShoe(Shoe instance);
    partial void InsertClothe(Clothe instance);
    partial void UpdateClothe(Clothe instance);
    partial void DeleteClothe(Clothe instance);
    #endregion
		
		public SportsShopDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["sportsShopDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SportsShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<sportsEquipment> sportsEquipments
		{
			get
			{
				return this.GetTable<sportsEquipment>();
			}
		}
		
		public System.Data.Linq.Table<SportsClub> SportsClubs
		{
			get
			{
				return this.GetTable<SportsClub>();
			}
		}
		
		public System.Data.Linq.Table<Shoe> Shoes
		{
			get
			{
				return this.GetTable<Shoe>();
			}
		}
		
		public System.Data.Linq.Table<Clothe> Clothes
		{
			get
			{
				return this.GetTable<Clothe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sportsEquipment")]
	public partial class sportsEquipment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sportsEquipmentId;
		
		private string _category;
		
		private string _productName;
		
		private string _company;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<int> _sportsClubId;
		
		private string _imageData;
		
		private EntityRef<SportsClub> _SportsClub;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsportsEquipmentIdChanging(int value);
    partial void OnsportsEquipmentIdChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    partial void OnproductNameChanging(string value);
    partial void OnproductNameChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnsportsClubIdChanging(System.Nullable<int> value);
    partial void OnsportsClubIdChanged();
    partial void OnimageDataChanging(string value);
    partial void OnimageDataChanged();
    #endregion
		
		public sportsEquipment()
		{
			this._SportsClub = default(EntityRef<SportsClub>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sportsEquipmentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int sportsEquipmentId
		{
			get
			{
				return this._sportsEquipmentId;
			}
			set
			{
				if ((this._sportsEquipmentId != value))
				{
					this.OnsportsEquipmentIdChanging(value);
					this.SendPropertyChanging();
					this._sportsEquipmentId = value;
					this.SendPropertyChanged("sportsEquipmentId");
					this.OnsportsEquipmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="NVarChar(30)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", DbType="NVarChar(30)")]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this.OnproductNameChanging(value);
					this.SendPropertyChanging();
					this._productName = value;
					this.SendPropertyChanged("productName");
					this.OnproductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="NVarChar(30)")]
		public string company
		{
			get
			{
				return this._company;
			}
			set
			{
				if ((this._company != value))
				{
					this.OncompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("company");
					this.OncompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sportsClubId", DbType="Int")]
		public System.Nullable<int> sportsClubId
		{
			get
			{
				return this._sportsClubId;
			}
			set
			{
				if ((this._sportsClubId != value))
				{
					if (this._SportsClub.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsportsClubIdChanging(value);
					this.SendPropertyChanging();
					this._sportsClubId = value;
					this.SendPropertyChanged("sportsClubId");
					this.OnsportsClubIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageData", DbType="Nvarchar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string imageData
		{
			get
			{
				return this._imageData;
			}
			set
			{
				if ((this._imageData != value))
				{
					this.OnimageDataChanging(value);
					this.SendPropertyChanging();
					this._imageData = value;
					this.SendPropertyChanged("imageData");
					this.OnimageDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SportsClub_sportsEquipment", Storage="_SportsClub", ThisKey="sportsClubId", OtherKey="SportsClubId", IsForeignKey=true)]
		public SportsClub SportsClub
		{
			get
			{
				return this._SportsClub.Entity;
			}
			set
			{
				SportsClub previousValue = this._SportsClub.Entity;
				if (((previousValue != value) 
							|| (this._SportsClub.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SportsClub.Entity = null;
						previousValue.sportsEquipments.Remove(this);
					}
					this._SportsClub.Entity = value;
					if ((value != null))
					{
						value.sportsEquipments.Add(this);
						this._sportsClubId = value.SportsClubId;
					}
					else
					{
						this._sportsClubId = default(Nullable<int>);
					}
					this.SendPropertyChanged("SportsClub");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SportsClub")]
	public partial class SportsClub : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SportsClubId;
		
		private string _SportsClubName;
		
		private EntitySet<sportsEquipment> _sportsEquipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSportsClubIdChanging(int value);
    partial void OnSportsClubIdChanged();
    partial void OnSportsClubNameChanging(string value);
    partial void OnSportsClubNameChanged();
    #endregion
		
		public SportsClub()
		{
			this._sportsEquipments = new EntitySet<sportsEquipment>(new Action<sportsEquipment>(this.attach_sportsEquipments), new Action<sportsEquipment>(this.detach_sportsEquipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SportsClubId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SportsClubId
		{
			get
			{
				return this._SportsClubId;
			}
			set
			{
				if ((this._SportsClubId != value))
				{
					this.OnSportsClubIdChanging(value);
					this.SendPropertyChanging();
					this._SportsClubId = value;
					this.SendPropertyChanged("SportsClubId");
					this.OnSportsClubIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SportsClubName", DbType="NVarChar(30)")]
		public string SportsClubName
		{
			get
			{
				return this._SportsClubName;
			}
			set
			{
				if ((this._SportsClubName != value))
				{
					this.OnSportsClubNameChanging(value);
					this.SendPropertyChanging();
					this._SportsClubName = value;
					this.SendPropertyChanged("SportsClubName");
					this.OnSportsClubNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SportsClub_sportsEquipment", Storage="_sportsEquipments", ThisKey="SportsClubId", OtherKey="sportsClubId")]
		public EntitySet<sportsEquipment> sportsEquipments
		{
			get
			{
				return this._sportsEquipments;
			}
			set
			{
				this._sportsEquipments.Assign(value);
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
		
		private void attach_sportsEquipments(sportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.SportsClub = this;
		}
		
		private void detach_sportsEquipments(sportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.SportsClub = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shoes")]
	public partial class Shoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _shoesId;
		
		private string _typeOfShoe;
		
		private string _company;
		
		private string _model;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<bool> _haveDiscount;
		
		private string _imageData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnshoesIdChanging(int value);
    partial void OnshoesIdChanged();
    partial void OntypeOfShoeChanging(string value);
    partial void OntypeOfShoeChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnhaveDiscountChanging(System.Nullable<bool> value);
    partial void OnhaveDiscountChanged();
    partial void OnimageDataChanging(string value);
    partial void OnimageDataChanged();
    #endregion
		
		public Shoe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shoesId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int shoesId
		{
			get
			{
				return this._shoesId;
			}
			set
			{
				if ((this._shoesId != value))
				{
					this.OnshoesIdChanging(value);
					this.SendPropertyChanging();
					this._shoesId = value;
					this.SendPropertyChanged("shoesId");
					this.OnshoesIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeOfShoe", DbType="NVarChar(30)")]
		public string typeOfShoe
		{
			get
			{
				return this._typeOfShoe;
			}
			set
			{
				if ((this._typeOfShoe != value))
				{
					this.OntypeOfShoeChanging(value);
					this.SendPropertyChanging();
					this._typeOfShoe = value;
					this.SendPropertyChanged("typeOfShoe");
					this.OntypeOfShoeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="NVarChar(30)")]
		public string company
		{
			get
			{
				return this._company;
			}
			set
			{
				if ((this._company != value))
				{
					this.OncompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("company");
					this.OncompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="NVarChar(30)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haveDiscount", DbType="Bit")]
		public System.Nullable<bool> haveDiscount
		{
			get
			{
				return this._haveDiscount;
			}
			set
			{
				if ((this._haveDiscount != value))
				{
					this.OnhaveDiscountChanging(value);
					this.SendPropertyChanging();
					this._haveDiscount = value;
					this.SendPropertyChanged("haveDiscount");
					this.OnhaveDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageData", DbType="NVarChar(MAX)")]
		public string imageData
		{
			get
			{
				return this._imageData;
			}
			set
			{
				if ((this._imageData != value))
				{
					this.OnimageDataChanging(value);
					this.SendPropertyChanging();
					this._imageData = value;
					this.SendPropertyChanged("imageData");
					this.OnimageDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clothes")]
	public partial class Clothe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _clothesId;
		
		private string _typeOfclothe;
		
		private string _gender;
		
		private string _company;
		
		private string _model;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<bool> _isShort;
		
		private System.Nullable<bool> _isDryfit;
		
		private string _imageData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnclothesIdChanging(int value);
    partial void OnclothesIdChanged();
    partial void OntypeOfclotheChanging(string value);
    partial void OntypeOfclotheChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnisShortChanging(System.Nullable<bool> value);
    partial void OnisShortChanged();
    partial void OnisDryfitChanging(System.Nullable<bool> value);
    partial void OnisDryfitChanged();
    partial void OnimageDataChanging(string value);
    partial void OnimageDataChanged();
    #endregion
		
		public Clothe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothesId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int clothesId
		{
			get
			{
				return this._clothesId;
			}
			set
			{
				if ((this._clothesId != value))
				{
					this.OnclothesIdChanging(value);
					this.SendPropertyChanging();
					this._clothesId = value;
					this.SendPropertyChanged("clothesId");
					this.OnclothesIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeOfclothe", DbType="NVarChar(30)")]
		public string typeOfclothe
		{
			get
			{
				return this._typeOfclothe;
			}
			set
			{
				if ((this._typeOfclothe != value))
				{
					this.OntypeOfclotheChanging(value);
					this.SendPropertyChanging();
					this._typeOfclothe = value;
					this.SendPropertyChanged("typeOfclothe");
					this.OntypeOfclotheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(30)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="NVarChar(30)")]
		public string company
		{
			get
			{
				return this._company;
			}
			set
			{
				if ((this._company != value))
				{
					this.OncompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("company");
					this.OncompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="NVarChar(30)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isShort", DbType="Bit")]
		public System.Nullable<bool> isShort
		{
			get
			{
				return this._isShort;
			}
			set
			{
				if ((this._isShort != value))
				{
					this.OnisShortChanging(value);
					this.SendPropertyChanging();
					this._isShort = value;
					this.SendPropertyChanged("isShort");
					this.OnisShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDryfit", DbType="Bit")]
		public System.Nullable<bool> isDryfit
		{
			get
			{
				return this._isDryfit;
			}
			set
			{
				if ((this._isDryfit != value))
				{
					this.OnisDryfitChanging(value);
					this.SendPropertyChanging();
					this._isDryfit = value;
					this.SendPropertyChanged("isDryfit");
					this.OnisDryfitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageData", DbType="Nvarchar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string imageData
		{
			get
			{
				return this._imageData;
			}
			set
			{
				if ((this._imageData != value))
				{
					this.OnimageDataChanging(value);
					this.SendPropertyChanging();
					this._imageData = value;
					this.SendPropertyChanged("imageData");
					this.OnimageDataChanged();
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
}
#pragma warning restore 1591