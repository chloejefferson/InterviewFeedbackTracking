namespace InterviewFeedbackTracking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Company", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Company", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Interview", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Interview", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Company", "ModifiedDate");
            DropColumn("dbo.Company", "CreatedDate");
        }
    }
}
