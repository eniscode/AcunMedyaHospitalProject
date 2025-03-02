namespace AcunMedyaHospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig16022025 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Appointments", new[] { "Department_Id" });
            RenameColumn(table: "dbo.Appointments", name: "Department_Id", newName: "DepartmentId");
            AlterColumn("dbo.Appointments", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "DepartmentId");
            AddForeignKey("dbo.Appointments", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: false); // cascadeDelete: false
        }

        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Appointments", new[] { "DepartmentId" });
            AlterColumn("dbo.Appointments", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Appointments", name: "DepartmentId", newName: "Department_Id");
            CreateIndex("dbo.Appointments", "Department_Id");
            AddForeignKey("dbo.Appointments", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
