namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreLocalizedDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Store", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PhoneNumber",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CodeISOA2 = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 255),
                        StoreType = c.Int(nullable: false),
                        Site = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Store_Address",
                c => new
                    {
                        Store_Id = c.Guid(nullable: false),
                        Address_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.Address_Id })
                .ForeignKey("dbo.Store", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.Address", t => t.Address_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Store_PhoneNumber",
                c => new
                    {
                        Store_Id = c.Guid(nullable: false),
                        PhoneNumber_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.PhoneNumber_Id })
                .ForeignKey("dbo.Store", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.PhoneNumber", t => t.PhoneNumber_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.PhoneNumber_Id);
            
            CreateTable(
                "dbo.BrazilAddress",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 255),
                        Numero = c.String(nullable: false, maxLength: 255),
                        Complemento = c.String(nullable: false, maxLength: 255),
                        Bairro = c.String(nullable: false, maxLength: 255),
                        Cidade = c.String(nullable: false, maxLength: 255),
                        Estado = c.String(),
                        CEP = c.String(nullable: false, maxLength: 9),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.BrazilPhoneNumber",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DDD = c.String(nullable: false, maxLength: 3),
                        Numero = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhoneNumber", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.BrazilStoreLocalizedDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 255),
                        NomeFantasia = c.String(nullable: false, maxLength: 255),
                        CNPJ = c.String(nullable: false, maxLength: 255),
                        InscricaoEstadual = c.String(maxLength: 255),
                        InscricaoMunicipal = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StoreLocalizedDetails", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BrazilStoreLocalizedDetails", "Id", "dbo.StoreLocalizedDetails");
            DropForeignKey("dbo.BrazilPhoneNumber", "Id", "dbo.PhoneNumber");
            DropForeignKey("dbo.BrazilAddress", "Id", "dbo.Address");
            DropForeignKey("dbo.StoreLocalizedDetails", "Id", "dbo.Store");
            DropForeignKey("dbo.Store_PhoneNumber", "PhoneNumber_Id", "dbo.PhoneNumber");
            DropForeignKey("dbo.Store_PhoneNumber", "Store_Id", "dbo.Store");
            DropForeignKey("dbo.Store_Address", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.Store_Address", "Store_Id", "dbo.Store");
            DropIndex("dbo.BrazilStoreLocalizedDetails", new[] { "Id" });
            DropIndex("dbo.BrazilPhoneNumber", new[] { "Id" });
            DropIndex("dbo.BrazilAddress", new[] { "Id" });
            DropIndex("dbo.Store_PhoneNumber", new[] { "PhoneNumber_Id" });
            DropIndex("dbo.Store_PhoneNumber", new[] { "Store_Id" });
            DropIndex("dbo.Store_Address", new[] { "Address_Id" });
            DropIndex("dbo.Store_Address", new[] { "Store_Id" });
            DropIndex("dbo.StoreLocalizedDetails", new[] { "Id" });
            DropTable("dbo.BrazilStoreLocalizedDetails");
            DropTable("dbo.BrazilPhoneNumber");
            DropTable("dbo.BrazilAddress");
            DropTable("dbo.Store_PhoneNumber");
            DropTable("dbo.Store_Address");
            DropTable("dbo.Store");
            DropTable("dbo.Country");
            DropTable("dbo.PhoneNumber");
            DropTable("dbo.StoreLocalizedDetails");
            DropTable("dbo.Address");
        }
    }
}
