namespace AcunMedyaHospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SocialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
