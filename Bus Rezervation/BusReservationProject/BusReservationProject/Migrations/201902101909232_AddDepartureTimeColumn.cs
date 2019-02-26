namespace BusReservationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartureTimeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "DepartureTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "DepartureTime");
        }
    }
}
