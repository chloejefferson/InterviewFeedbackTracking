namespace InterviewFeedbackTracking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatesAndAnnotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Interview", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropIndex("dbo.Interview", new[] { "ApplicationUser_Id" });
            RenameColumn(table: "dbo.Interview", name: "ApplicationUser_Id", newName: "IntervieweeGuid");
            AddColumn("dbo.Company", "StreetAddress", c => c.String(nullable: false));
            AddColumn("dbo.Company", "City", c => c.String(nullable: false));
            AddColumn("dbo.Company", "State", c => c.String(nullable: false));
            AddColumn("dbo.Company", "Zip", c => c.String(nullable: false));
            AddColumn("dbo.ApplicationUser", "FirstName", c => c.String());
            AddColumn("dbo.ApplicationUser", "LastName", c => c.String());
            AlterColumn("dbo.Company", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Company", "Website", c => c.String(nullable: false));
            AlterColumn("dbo.InterviewProfileStep", "Details", c => c.String(nullable: false));
            AlterColumn("dbo.Interview", "Interviewer", c => c.String(nullable: false));
            AlterColumn("dbo.Interview", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Interview", "IntervieweeGuid", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Interview", "IntervieweeGuid");
            AddForeignKey("dbo.Interview", "IntervieweeGuid", "dbo.ApplicationUser", "Id", cascadeDelete: true);
            DropColumn("dbo.Company", "Address");
            DropColumn("dbo.Interview", "Interviewee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interview", "Interviewee", c => c.Guid(nullable: false));
            AddColumn("dbo.Company", "Address", c => c.String());
            DropForeignKey("dbo.Interview", "IntervieweeGuid", "dbo.ApplicationUser");
            DropIndex("dbo.Interview", new[] { "IntervieweeGuid" });
            AlterColumn("dbo.Interview", "IntervieweeGuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Interview", "Comment", c => c.String());
            AlterColumn("dbo.Interview", "Interviewer", c => c.String());
            AlterColumn("dbo.InterviewProfileStep", "Details", c => c.String());
            AlterColumn("dbo.Company", "Website", c => c.String());
            AlterColumn("dbo.Company", "Name", c => c.String());
            DropColumn("dbo.ApplicationUser", "LastName");
            DropColumn("dbo.ApplicationUser", "FirstName");
            DropColumn("dbo.Company", "Zip");
            DropColumn("dbo.Company", "State");
            DropColumn("dbo.Company", "City");
            DropColumn("dbo.Company", "StreetAddress");
            RenameColumn(table: "dbo.Interview", name: "IntervieweeGuid", newName: "ApplicationUser_Id");
            CreateIndex("dbo.Interview", "ApplicationUser_Id");
            AddForeignKey("dbo.Interview", "ApplicationUser_Id", "dbo.ApplicationUser", "Id");
        }
    }
}
