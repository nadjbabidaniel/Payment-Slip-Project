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

namespace UplatnicaWCFtoDb
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OtpremnicaDatabase")]
	public partial class SifarnikPartnerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSifarnikPartner(SifarnikPartner instance);
    partial void UpdateSifarnikPartner(SifarnikPartner instance);
    partial void DeleteSifarnikPartner(SifarnikPartner instance);
    #endregion
		
		public SifarnikPartnerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OtpremnicaDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SifarnikPartnerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SifarnikPartnerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SifarnikPartnerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SifarnikPartnerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SifarnikPartner> SifarnikPartners
		{
			get
			{
				return this.GetTable<SifarnikPartner>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SifarnikPartners")]
	public partial class SifarnikPartner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SifraPartnera;
		
		private string _NazivPartnera;
		
		private string _Mesto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSifraPartneraChanging(int value);
    partial void OnSifraPartneraChanged();
    partial void OnNazivPartneraChanging(string value);
    partial void OnNazivPartneraChanged();
    partial void OnMestoChanging(string value);
    partial void OnMestoChanged();
    #endregion
		
		public SifarnikPartner()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraPartnera", DbType="Int NOT NULL")]
		public int SifraPartnera
		{
			get
			{
				return this._SifraPartnera;
			}
			set
			{
				if ((this._SifraPartnera != value))
				{
					this.OnSifraPartneraChanging(value);
					this.SendPropertyChanging();
					this._SifraPartnera = value;
					this.SendPropertyChanged("SifraPartnera");
					this.OnSifraPartneraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NazivPartnera", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NazivPartnera
		{
			get
			{
				return this._NazivPartnera;
			}
			set
			{
				if ((this._NazivPartnera != value))
				{
					this.OnNazivPartneraChanging(value);
					this.SendPropertyChanging();
					this._NazivPartnera = value;
					this.SendPropertyChanged("NazivPartnera");
					this.OnNazivPartneraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mesto", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Mesto
		{
			get
			{
				return this._Mesto;
			}
			set
			{
				if ((this._Mesto != value))
				{
					this.OnMestoChanging(value);
					this.SendPropertyChanging();
					this._Mesto = value;
					this.SendPropertyChanged("Mesto");
					this.OnMestoChanged();
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
