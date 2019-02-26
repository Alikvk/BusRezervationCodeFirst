namespace BusReservationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTripIdInTpInfoTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TripPassengerInfoes", "Trip_TripId", "dbo.Trips");
            DropIndex("dbo.TripPassengerInfoes", new[] { "Trip_TripId" });
            RenameColumn(table: "dbo.TripPassengerInfoes", name: "Trip_TripId", newName: "TripId");
            AlterColumn("dbo.TripPassengerInfoes", "TripId", c => c.Int(nullable: false));
            CreateIndex("dbo.TripPassengerInfoes", "TripId");
            AddForeignKey("dbo.TripPassengerInfoes", "TripId", "dbo.Trips", "TripId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripPassengerInfoes", "TripId", "dbo.Trips");
            DropIndex("dbo.TripPassengerInfoes", new[] { "TripId" });
            AlterColumn("dbo.TripPassengerInfoes", "TripId", c => c.Int());
            RenameColumn(table: "dbo.TripPassengerInfoes", name: "TripId", newName: "Trip_TripId");
            CreateIndex("dbo.TripPassengerInfoes", "Trip_TripId");
            AddForeignKey("dbo.TripPassengerInfoes", "Trip_TripId", "dbo.Trips", "TripId");
        }
    }
}
