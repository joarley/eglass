namespace Rajastech.EGlass.Infrastructure.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255),
                        Rua = c.String(maxLength: 255),
                        Numero = c.String(maxLength: 255),
                        Complemento = c.String(maxLength: 255),
                        Bairro = c.String(maxLength: 255),
                        Cidade = c.String(maxLength: 255),
                        CEP = c.String(maxLength: 9),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreLocalizedDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RazaoSocial = c.String(maxLength: 255),
                        NomeFantasia = c.String(maxLength: 255),
                        CNPJ = c.String(maxLength: 255),
                        InscricaoEstadual = c.String(maxLength: 255),
                        InscricaoMunicipal = c.String(maxLength: 255),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhoneNumber",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255),
                        DDD = c.String(maxLength: 3),
                        Numero = c.String(maxLength: 255),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CodeISOA2 = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 255),
                        StoreType = c.Int(nullable: false),
                        Site = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreAddressBase",
                c => new
                    {
                        Store_Id = c.Guid(nullable: false),
                        AddressBase_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.AddressBase_Id })
                .ForeignKey("dbo.Store", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.Address", t => t.AddressBase_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.AddressBase_Id);
            
            CreateTable(
                "dbo.StorePhoneNumberBase",
                c => new
                    {
                        Store_Id = c.Guid(nullable: false),
                        PhoneNumberBase_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.PhoneNumberBase_Id })
                .ForeignKey("dbo.Store", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.PhoneNumber", t => t.PhoneNumberBase_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.PhoneNumberBase_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StorePhoneNumberBase", "PhoneNumberBase_Id", "dbo.PhoneNumber");
            DropForeignKey("dbo.StorePhoneNumberBase", "Store_Id", "dbo.Store");
            DropForeignKey("dbo.StoreAddressBase", "AddressBase_Id", "dbo.Address");
            DropForeignKey("dbo.StoreAddressBase", "Store_Id", "dbo.Store");
            DropIndex("dbo.StorePhoneNumberBase", new[] { "PhoneNumberBase_Id" });
            DropIndex("dbo.StorePhoneNumberBase", new[] { "Store_Id" });
            DropIndex("dbo.StoreAddressBase", new[] { "AddressBase_Id" });
            DropIndex("dbo.StoreAddressBase", new[] { "Store_Id" });
            DropTable("dbo.StorePhoneNumberBase");
            DropTable("dbo.StoreAddressBase");
            DropTable("dbo.Store");
            DropTable("dbo.Country");
            DropTable("dbo.PhoneNumber");
            DropTable("dbo.StoreLocalizedDetails");
            DropTable("dbo.Address");
        }
    }
}
