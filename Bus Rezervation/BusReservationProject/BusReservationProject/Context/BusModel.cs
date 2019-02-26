namespace BusReservationProject.Context
{
    using Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusModel : DbContext
    {
        // Your context has been configured to use a 'BusModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BusReservationProject.Context.BusModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BusModel' 
        // connection string in the application configuration file.
        public BusModel()
            : base("name=BusModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripPassengerInfo> TripPassengerInfos { get; set; }
        public virtual DbSet<DailyArchive> DailyArchives { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}