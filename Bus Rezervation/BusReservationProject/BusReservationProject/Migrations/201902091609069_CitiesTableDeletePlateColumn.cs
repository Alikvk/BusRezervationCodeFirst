namespace BusReservationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CitiesTableDeletePlateColumn : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cities", new[] { "Plate" });
            DropColumn("dbo.Cities", "Plate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "Plate", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "Plate", unique: true);
        }
    }
}
