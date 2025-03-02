namespace AcunMedyaHospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig15022025 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Department_Id", c => c.Int());
            CreateIndex("dbo.Appointments", "Department_Id");
            AddForeignKey("dbo.Appointments", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Appointments", new[] { "Department_Id" });
            DropColumn("dbo.Appointments", "Department_Id");
        }
    }
}
