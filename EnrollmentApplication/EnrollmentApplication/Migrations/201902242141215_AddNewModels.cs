namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Enrollments", "AssignedCampus", c => c.String(nullable: false));
            AddColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String(nullable: false));
            AddColumn("dbo.Enrollments", "EnrollmentYear", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Enrollments", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Enrollments", "Grade", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Enrollments", "EnrollmentYear");
            DropColumn("dbo.Enrollments", "EnrollmentSemester");
            DropColumn("dbo.Enrollments", "AssignedCampus");
            DropColumn("dbo.Enrollments", "IsActive");
        }
    }
}
