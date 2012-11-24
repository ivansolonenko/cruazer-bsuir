﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Lab05
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LogisticsModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LogisticsModelContainer object using the connection string found in the 'LogisticsModelContainer' section of the application configuration file.
        /// </summary>
        public LogisticsModelContainer() : base("name=LogisticsModelContainer", "LogisticsModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LogisticsModelContainer object.
        /// </summary>
        public LogisticsModelContainer(string connectionString) : base(connectionString, "LogisticsModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LogisticsModelContainer object.
        /// </summary>
        public LogisticsModelContainer(EntityConnection connection) : base(connection, "LogisticsModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cargo> CargoSet
        {
            get
            {
                if ((_CargoSet == null))
                {
                    _CargoSet = base.CreateObjectSet<Cargo>("CargoSet");
                }
                return _CargoSet;
            }
        }
        private ObjectSet<Cargo> _CargoSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Car> CarSet
        {
            get
            {
                if ((_CarSet == null))
                {
                    _CarSet = base.CreateObjectSet<Car>("CarSet");
                }
                return _CarSet;
            }
        }
        private ObjectSet<Car> _CarSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CargoSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCargoSet(Cargo cargo)
        {
            base.AddObject("CargoSet", cargo);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CarSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCarSet(Car car)
        {
            base.AddObject("CarSet", car);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LogisticsModel", Name="Car")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Car : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Car object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="capacity">Initial value of the Capacity property.</param>
        public static Car CreateCar(global::System.Int32 id, global::System.Int32 capacity)
        {
            Car car = new Car();
            car.Id = id;
            car.Capacity = capacity;
            return car;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Capacity
        {
            get
            {
                return _Capacity;
            }
            set
            {
                OnCapacityChanging(value);
                ReportPropertyChanging("Capacity");
                _Capacity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Capacity");
                OnCapacityChanged();
            }
        }
        private global::System.Int32 _Capacity;
        partial void OnCapacityChanging(global::System.Int32 value);
        partial void OnCapacityChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LogisticsModel", Name="Cargo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cargo : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cargo object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="cargoTitle">Initial value of the CargoTitle property.</param>
        /// <param name="cargoSize">Initial value of the CargoSize property.</param>
        public static Cargo CreateCargo(global::System.Int32 id, global::System.String cargoTitle, global::System.Int32 cargoSize)
        {
            Cargo cargo = new Cargo();
            cargo.Id = id;
            cargo.CargoTitle = cargoTitle;
            cargo.CargoSize = cargoSize;
            return cargo;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CargoTitle
        {
            get
            {
                return _CargoTitle;
            }
            set
            {
                OnCargoTitleChanging(value);
                ReportPropertyChanging("CargoTitle");
                _CargoTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CargoTitle");
                OnCargoTitleChanged();
            }
        }
        private global::System.String _CargoTitle;
        partial void OnCargoTitleChanging(global::System.String value);
        partial void OnCargoTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CargoSize
        {
            get
            {
                return _CargoSize;
            }
            set
            {
                OnCargoSizeChanging(value);
                ReportPropertyChanging("CargoSize");
                _CargoSize = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CargoSize");
                OnCargoSizeChanged();
            }
        }
        private global::System.Int32 _CargoSize;
        partial void OnCargoSizeChanging(global::System.Int32 value);
        partial void OnCargoSizeChanged();

        #endregion
    
    }

    #endregion
    
}
