namespace BusReservationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDailyArchiveTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyArchives",
                c => new
                    {
                        DailyArchiveId = c.Int(nullable: false, identity: true),
                        Plate = c.String(),
                        ArchiveDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DailyArchiveId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DailyArchives");
        }
    }
}
