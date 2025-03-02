namespace AcunMedyaHospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig090220251818ımgurldepart : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "ImageUrl", c => c.Int(nullable: false));
        }
    }
}
