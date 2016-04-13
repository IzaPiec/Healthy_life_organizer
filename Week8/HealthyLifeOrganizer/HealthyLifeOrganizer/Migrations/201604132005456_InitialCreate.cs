namespace HealthyLifeOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Measurements",
                c => new
                    {
                        MeasurementID = c.Int(nullable: false, identity: true),
                        MeasurementsDate = c.DateTime(nullable: false),
                        Weight = c.Double(nullable: false),
                        Waist = c.Double(nullable: false),
                        Tummy = c.Double(nullable: false),
                        Hips = c.Double(nullable: false),
                        Thigh = c.Double(nullable: false),
                        Calf = c.Double(nullable: false),
                        Breast = c.Double(nullable: false),
                        Biceps = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MeasurementID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Measurements");
        }
    }
}
