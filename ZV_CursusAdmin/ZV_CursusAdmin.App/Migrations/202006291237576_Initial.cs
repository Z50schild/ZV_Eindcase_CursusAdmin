namespace ZV_CursusAdmin.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titel = c.String(maxLength: 300),
                        Code = c.String(maxLength: 10),
                        Duur = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CursusInstanties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDatum = c.DateTime(nullable: false),
                        Cursus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursus", t => t.Cursus_Id)
                .Index(t => t.Cursus_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CursusInstanties", "Cursus_Id", "dbo.Cursus");
            DropIndex("dbo.CursusInstanties", new[] { "Cursus_Id" });
            DropTable("dbo.CursusInstanties");
            DropTable("dbo.Cursus");
        }
    }
}
