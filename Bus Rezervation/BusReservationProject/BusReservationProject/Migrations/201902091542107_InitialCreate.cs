namespace BusReservationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Plate = c.String(),
                        SeatCount = c.Int(nullable: false),
                        Image = c.Binary(),
                        Driver_DriverId = c.Int(),
                    })
                .PrimaryKey(t => t.BusId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .Index(t => t.Driver_DriverId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SurName = c.String(),
                    })
                .PrimaryKey(t => t.DriverId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Plate = c.Int(nullable: false),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId)
                .Index(t => t.Plate, unique: true);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        PassengerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SurName = c.String(),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        IdentificationNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PassengerId);
            
            CreateTable(
                "dbo.TripPassengerInfoes",
                c => new
                    {
                        TripPassengerId = c.Int(nullable: false, identity: true),
                        SeatNumber = c.Int(nullable: false),
                        Passenger_PassengerId = c.Int(),
                        Trip_TripId = c.Int(),
                    })
                .PrimaryKey(t => t.TripPassengerId)
                .ForeignKey("dbo.Passengers", t => t.Passenger_PassengerId)
                .ForeignKey("dbo.Trips", t => t.Trip_TripId)
                .Index(t => t.Passenger_PassengerId)
                .Index(t => t.Trip_TripId);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripId = c.Int(nullable: false, identity: true),
                        Bus_BusId = c.Int(),
                        DepartureCity_CityId = c.Int(),
                        DestinationCity_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.TripId)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .ForeignKey("dbo.Cities", t => t.DepartureCity_CityId)
                .ForeignKey("dbo.Cities", t => t.DestinationCity_CityId)
                .Index(t => t.Bus_BusId)
                .Index(t => t.DepartureCity_CityId)
                .Index(t => t.DestinationCity_CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripPassengerInfoes", "Trip_TripId", "dbo.Trips");
            DropForeignKey("dbo.Trips", "DestinationCity_CityId", "dbo.Cities");
            DropForeignKey("dbo.Trips", "DepartureCity_CityId", "dbo.Cities");
            DropForeignKey("dbo.Trips", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.TripPassengerInfoes", "Passenger_PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Buses", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Trips", new[] { "DestinationCity_CityId" });
            DropIndex("dbo.Trips", new[] { "DepartureCity_CityId" });
            DropIndex("dbo.Trips", new[] { "Bus_BusId" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "Trip_TripId" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "Passenger_PassengerId" });
            DropIndex("dbo.Cities", new[] { "Plate" });
            DropIndex("dbo.Buses", new[] { "Driver_DriverId" });
            DropTable("dbo.Trips");
            DropTable("dbo.TripPassengerInfoes");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Drivers");
            DropTable("dbo.Buses");
        }
    }
}
