﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDDSample.Reporting
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="DDDSampleCQRS")]
	public partial class ReportingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLocation(Location instance);
    partial void UpdateLocation(Location instance);
    partial void DeleteLocation(Location instance);
    partial void InsertCargo(Cargo instance);
    partial void UpdateCargo(Cargo instance);
    partial void DeleteCargo(Cargo instance);
    partial void InsertDelivery(Delivery instance);
    partial void UpdateDelivery(Delivery instance);
    partial void DeleteDelivery(Delivery instance);
    #endregion
		
		public ReportingDataContext() : 
				base(global::DDDSample.Reporting.Properties.Settings.Default.DDDSampleCQRSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ReportingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ReportingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Location> Locations
		{
			get
			{
				return this.GetTable<Location>();
			}
		}
		
		public System.Data.Linq.Table<Cargo> Cargos
		{
			get
			{
				return this.GetTable<Cargo>();
			}
		}
		
		public System.Data.Linq.Table<Delivery> Deliveries
		{
			get
			{
				return this.GetTable<Delivery>();
			}
		}
	}
	
	[Table(Name="domain.Location")]
	public partial class Location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _UnLocode;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnUnLocodeChanging(string value);
    partial void OnUnLocodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Location()
		{
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[Column(Storage="_UnLocode", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string UnLocode
		{
			get
			{
				return this._UnLocode;
			}
			set
			{
				if ((this._UnLocode != value))
				{
					this.OnUnLocodeChanging(value);
					this.SendPropertyChanging();
					this._UnLocode = value;
					this.SendPropertyChanged("UnLocode");
					this.OnUnLocodeChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
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
	
	[Table(Name="reporting.Cargo")]
	public partial class Cargo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _TrackingId;
		
		private string _Origin;
		
		private string _Destination;
		
		private System.DateTime _ArrivalDeadline;
		
		private List<DDDSample.Messages.LegDTO> _RoteSpecification;
		
		private System.Guid _CurrentInformation;
		
		private EntitySet<Delivery> _Deliveries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnTrackingIdChanging(string value);
    partial void OnTrackingIdChanged();
    partial void OnOriginChanging(string value);
    partial void OnOriginChanged();
    partial void OnDestinationChanging(string value);
    partial void OnDestinationChanged();
    partial void OnArrivalDeadlineChanging(System.DateTime value);
    partial void OnArrivalDeadlineChanged();
    partial void OnRouteSpecificationChanging(List<DDDSample.Messages.LegDTO> value);
    partial void OnRouteSpecificationChanged();
    partial void OnCurrentInformationIdChanging(System.Guid value);
    partial void OnCurrentInformationIdChanged();
    #endregion
		
		public Cargo()
		{
			this._Deliveries = new EntitySet<Delivery>(new Action<Delivery>(this.attach_Deliveries), new Action<Delivery>(this.detach_Deliveries));
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[Column(Storage="_TrackingId", DbType="NVarChar(255)")]
		public string TrackingId
		{
			get
			{
				return this._TrackingId;
			}
			set
			{
				if ((this._TrackingId != value))
				{
					this.OnTrackingIdChanging(value);
					this.SendPropertyChanging();
					this._TrackingId = value;
					this.SendPropertyChanged("TrackingId");
					this.OnTrackingIdChanged();
				}
			}
		}
		
		[Column(Storage="_Origin", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Origin
		{
			get
			{
				return this._Origin;
			}
			set
			{
				if ((this._Origin != value))
				{
					this.OnOriginChanging(value);
					this.SendPropertyChanging();
					this._Origin = value;
					this.SendPropertyChanged("Origin");
					this.OnOriginChanged();
				}
			}
		}
		
		[Column(Storage="_Destination", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Destination
		{
			get
			{
				return this._Destination;
			}
			set
			{
				if ((this._Destination != value))
				{
					this.OnDestinationChanging(value);
					this.SendPropertyChanging();
					this._Destination = value;
					this.SendPropertyChanged("Destination");
					this.OnDestinationChanged();
				}
			}
		}
		
		[Column(Storage="_ArrivalDeadline", DbType="DateTime NOT NULL")]
		public System.DateTime ArrivalDeadline
		{
			get
			{
				return this._ArrivalDeadline;
			}
			set
			{
				if ((this._ArrivalDeadline != value))
				{
					this.OnArrivalDeadlineChanging(value);
					this.SendPropertyChanging();
					this._ArrivalDeadline = value;
					this.SendPropertyChanged("ArrivalDeadline");
					this.OnArrivalDeadlineChanged();
				}
			}
		}
		
		[Column(Name="RoteSpecification", Storage="_RoteSpecification", DbType="VarBinary(8000)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public List<DDDSample.Messages.LegDTO> RouteSpecification
		{
			get
			{
				return this._RoteSpecification;
			}
			set
			{
				if ((this._RoteSpecification != value))
				{
					this.OnRouteSpecificationChanging(value);
					this.SendPropertyChanging();
					this._RoteSpecification = value;
					this.SendPropertyChanged("RouteSpecification");
					this.OnRouteSpecificationChanged();
				}
			}
		}
		
		[Column(Name="CurrentInformation", Storage="_CurrentInformation", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CurrentInformationId
		{
			get
			{
				return this._CurrentInformation;
			}
			set
			{
				if ((this._CurrentInformation != value))
				{
					this.OnCurrentInformationIdChanging(value);
					this.SendPropertyChanging();
					this._CurrentInformation = value;
					this.SendPropertyChanged("CurrentInformationId");
					this.OnCurrentInformationIdChanged();
				}
			}
		}
		
		[Association(Name="Cargo_Delivery", Storage="_Deliveries", ThisKey="Id", OtherKey="CargoId")]
		public EntitySet<Delivery> DeliveryHistory
		{
			get
			{
				return this._Deliveries;
			}
			set
			{
				this._Deliveries.Assign(value);
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
		
		private void attach_Deliveries(Delivery entity)
		{
			this.SendPropertyChanging();
			entity.Cargo = this;
		}
		
		private void detach_Deliveries(Delivery entity)
		{
			this.SendPropertyChanging();
			entity.Cargo = null;
		}
	}
	
	[Table(Name="reporting.Delivery")]
	public partial class Delivery : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _CargoId;
		
		private bool _IsMisdirected;
		
		private System.Nullable<System.DateTime> _Eta;
		
		private System.DateTime _CalculatedAt;
		
		private bool _UnloadedAtDest;
		
		private RoutingStatus _RoutingStatus;
		
		private TransportStatus _TransportStatus;
		
		private HandlingEventType? _NextExpectedEventType;
		
		private string _NextExpectedLocation;
		
		private HandlingEventType? _LastKnownEventType;
		
		private string _LastKnownLocation;
		
		private EntityRef<Cargo> _Cargo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnCargoIdChanging(System.Guid value);
    partial void OnCargoIdChanged();
    partial void OnIsMisdirectedChanging(bool value);
    partial void OnIsMisdirectedChanged();
    partial void OnEtaChanging(System.Nullable<System.DateTime> value);
    partial void OnEtaChanged();
    partial void OnCalculatedAtChanging(System.DateTime value);
    partial void OnCalculatedAtChanged();
    partial void OnUnloadedAtDestChanging(bool value);
    partial void OnUnloadedAtDestChanged();
    partial void OnRoutingStatusChanging(RoutingStatus value);
    partial void OnRoutingStatusChanged();
    partial void OnTransportStatusChanging(TransportStatus value);
    partial void OnTransportStatusChanged();
    partial void OnNextExpectedEventTypeChanging(HandlingEventType? value);
    partial void OnNextExpectedEventTypeChanged();
    partial void OnNextExpectedLocationChanging(string value);
    partial void OnNextExpectedLocationChanged();
    partial void OnLastKnownEventTypeChanging(HandlingEventType? value);
    partial void OnLastKnownEventTypeChanged();
    partial void OnLastKnownLocationChanging(string value);
    partial void OnLastKnownLocationChanged();
    #endregion
		
		public Delivery()
		{
			this._Cargo = default(EntityRef<Cargo>);
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[Column(Storage="_CargoId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CargoId
		{
			get
			{
				return this._CargoId;
			}
			set
			{
				if ((this._CargoId != value))
				{
					if (this._Cargo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCargoIdChanging(value);
					this.SendPropertyChanging();
					this._CargoId = value;
					this.SendPropertyChanged("CargoId");
					this.OnCargoIdChanged();
				}
			}
		}
		
		[Column(Storage="_IsMisdirected", DbType="Bit NOT NULL")]
		public bool IsMisdirected
		{
			get
			{
				return this._IsMisdirected;
			}
			set
			{
				if ((this._IsMisdirected != value))
				{
					this.OnIsMisdirectedChanging(value);
					this.SendPropertyChanging();
					this._IsMisdirected = value;
					this.SendPropertyChanged("IsMisdirected");
					this.OnIsMisdirectedChanged();
				}
			}
		}
		
		[Column(Storage="_Eta", DbType="DateTime")]
		public System.Nullable<System.DateTime> Eta
		{
			get
			{
				return this._Eta;
			}
			set
			{
				if ((this._Eta != value))
				{
					this.OnEtaChanging(value);
					this.SendPropertyChanging();
					this._Eta = value;
					this.SendPropertyChanged("Eta");
					this.OnEtaChanged();
				}
			}
		}
		
		[Column(Storage="_CalculatedAt", DbType="DateTime NOT NULL")]
		public System.DateTime CalculatedAt
		{
			get
			{
				return this._CalculatedAt;
			}
			set
			{
				if ((this._CalculatedAt != value))
				{
					this.OnCalculatedAtChanging(value);
					this.SendPropertyChanging();
					this._CalculatedAt = value;
					this.SendPropertyChanged("CalculatedAt");
					this.OnCalculatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_UnloadedAtDest", DbType="Bit NOT NULL")]
		public bool UnloadedAtDest
		{
			get
			{
				return this._UnloadedAtDest;
			}
			set
			{
				if ((this._UnloadedAtDest != value))
				{
					this.OnUnloadedAtDestChanging(value);
					this.SendPropertyChanging();
					this._UnloadedAtDest = value;
					this.SendPropertyChanged("UnloadedAtDest");
					this.OnUnloadedAtDestChanged();
				}
			}
		}
		
		[Column(Storage="_RoutingStatus", DbType="Int NOT NULL", CanBeNull=false)]
		public RoutingStatus RoutingStatus
		{
			get
			{
				return this._RoutingStatus;
			}
			set
			{
				if ((this._RoutingStatus != value))
				{
					this.OnRoutingStatusChanging(value);
					this.SendPropertyChanging();
					this._RoutingStatus = value;
					this.SendPropertyChanged("RoutingStatus");
					this.OnRoutingStatusChanged();
				}
			}
		}
		
		[Column(Storage="_TransportStatus", DbType="Int NOT NULL", CanBeNull=false)]
		public TransportStatus TransportStatus
		{
			get
			{
				return this._TransportStatus;
			}
			set
			{
				if ((this._TransportStatus != value))
				{
					this.OnTransportStatusChanging(value);
					this.SendPropertyChanging();
					this._TransportStatus = value;
					this.SendPropertyChanged("TransportStatus");
					this.OnTransportStatusChanged();
				}
			}
		}
		
		[Column(Storage="_NextExpectedEventType", DbType="Int", CanBeNull=true)]
		public HandlingEventType? NextExpectedEventType
		{
			get
			{
				return this._NextExpectedEventType;
			}
			set
			{
				if ((this._NextExpectedEventType != value))
				{
					this.OnNextExpectedEventTypeChanging(value);
					this.SendPropertyChanging();
					this._NextExpectedEventType = value;
					this.SendPropertyChanged("NextExpectedEventType");
					this.OnNextExpectedEventTypeChanged();
				}
			}
		}
		
		[Column(Storage="_NextExpectedLocation", DbType="NVarChar(255)")]
		public string NextExpectedLocation
		{
			get
			{
				return this._NextExpectedLocation;
			}
			set
			{
				if ((this._NextExpectedLocation != value))
				{
					this.OnNextExpectedLocationChanging(value);
					this.SendPropertyChanging();
					this._NextExpectedLocation = value;
					this.SendPropertyChanged("NextExpectedLocation");
					this.OnNextExpectedLocationChanged();
				}
			}
		}
		
		[Column(Storage="_LastKnownEventType", DbType="Int", CanBeNull=true)]
		public HandlingEventType? LastKnownEventType
		{
			get
			{
				return this._LastKnownEventType;
			}
			set
			{
				if ((this._LastKnownEventType != value))
				{
					this.OnLastKnownEventTypeChanging(value);
					this.SendPropertyChanging();
					this._LastKnownEventType = value;
					this.SendPropertyChanged("LastKnownEventType");
					this.OnLastKnownEventTypeChanged();
				}
			}
		}
		
		[Column(Storage="_LastKnownLocation", DbType="NVarChar(255)")]
		public string LastKnownLocation
		{
			get
			{
				return this._LastKnownLocation;
			}
			set
			{
				if ((this._LastKnownLocation != value))
				{
					this.OnLastKnownLocationChanging(value);
					this.SendPropertyChanging();
					this._LastKnownLocation = value;
					this.SendPropertyChanged("LastKnownLocation");
					this.OnLastKnownLocationChanged();
				}
			}
		}
		
		[Association(Name="Cargo_Delivery", Storage="_Cargo", ThisKey="CargoId", OtherKey="Id", IsForeignKey=true)]
		public Cargo Cargo
		{
			get
			{
				return this._Cargo.Entity;
			}
			set
			{
				Cargo previousValue = this._Cargo.Entity;
				if (((previousValue != value) 
							|| (this._Cargo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cargo.Entity = null;
						previousValue.DeliveryHistory.Remove(this);
					}
					this._Cargo.Entity = value;
					if ((value != null))
					{
						value.DeliveryHistory.Add(this);
						this._CargoId = value.Id;
					}
					else
					{
						this._CargoId = default(System.Guid);
					}
					this.SendPropertyChanged("Cargo");
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
