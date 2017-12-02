namespace IKProjesi.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        PersonelAd = c.String(),
                        PersonelSoyad = c.String(),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Email = c.String(),
                        Telno = c.Int(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false),
                        IlceId = c.Int(nullable: false),
                        BolumId = c.Int(nullable: false),
                        UnvanId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                        YoneticiId = c.Int(),
                        Yoneticimi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("dbo.Bolum", t => t.BolumId, cascadeDelete: true)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.YoneticiId)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .ForeignKey("dbo.Unvan", t => t.UnvanId, cascadeDelete: true)
                .Index(t => t.IlceId)
                .Index(t => t.BolumId)
                .Index(t => t.UnvanId)
                .Index(t => t.EgitimId)
                .Index(t => t.YoneticiId);
            
            CreateTable(
                "dbo.Egitim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlId = c.Int(nullable: false),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Il", t => t.IlId, cascadeDelete: true)
                .Index(t => t.IlId);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        IlId = c.Int(nullable: false, identity: true),
                        IlAd = c.String(),
                    })
                .PrimaryKey(t => t.IlId);
            
            CreateTable(
                "dbo.Unvan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "UnvanId", "dbo.Unvan");
            DropForeignKey("dbo.Personel", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlId", "dbo.Il");
            DropForeignKey("dbo.Personel", "YoneticiId", "dbo.Personel");
            DropForeignKey("dbo.Personel", "EgitimId", "dbo.Egitim");
            DropForeignKey("dbo.Personel", "BolumId", "dbo.Bolum");
            DropIndex("dbo.Ilce", new[] { "IlId" });
            DropIndex("dbo.Personel", new[] { "YoneticiId" });
            DropIndex("dbo.Personel", new[] { "EgitimId" });
            DropIndex("dbo.Personel", new[] { "UnvanId" });
            DropIndex("dbo.Personel", new[] { "BolumId" });
            DropIndex("dbo.Personel", new[] { "IlceId" });
            DropTable("dbo.Unvan");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Egitim");
            DropTable("dbo.Personel");
            DropTable("dbo.Bolum");
        }
    }
}
