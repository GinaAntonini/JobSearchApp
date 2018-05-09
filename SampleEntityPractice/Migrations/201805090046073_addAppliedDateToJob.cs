namespace SampleEntityPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAppliedDateToJob : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobAlerts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        Location = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Jobs", "DateApplied", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "DateApplied");
            DropTable("dbo.JobAlerts");
        }
    }
}
