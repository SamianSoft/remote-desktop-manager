namespace RemoteDesktopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(maxLength: 250),
                        Address = c.String(maxLength: 1000),
                        CrmLink = c.String(maxLength: 1000),
                        ParentId = c.Long(),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Extention = c.Int(nullable: false),
                        CrmLink = c.String(maxLength: 1000),
                        ClientId = c.Long(),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.RemoteDisplayColors",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ColorDepth = c.Short(nullable: false),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Ip = c.String(nullable: false, maxLength: 250),
                        Port = c.String(nullable: false, maxLength: 5),
                        LastActiveUser = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 1000),
                        ClientId = c.Long(nullable: false),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ColorDepthId = c.Long(),
                        SizeId = c.Long(),
                        IsConsole = c.Boolean(),
                        Status = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RemoteDisplayColors", t => t.ColorDepthId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.RemoteScreenSizes", t => t.SizeId)
                .Index(t => t.ClientId)
                .Index(t => t.ColorDepthId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.SessionLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        User = c.String(nullable: false),
                        LocalIp = c.String(nullable: false),
                        ConnectTime = c.DateTimeOffset(nullable: false, precision: 7),
                        DisconnectTime = c.DateTimeOffset(precision: 7),
                        SessionId = c.Long(),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessions", t => t.SessionId)
                .Index(t => t.SessionId);
            
            CreateTable(
                "dbo.RemoteScreenSizes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Width = c.Int(),
                        Height = c.Int(),
                        Title = c.String(),
                        CreteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "SizeId", "dbo.RemoteScreenSizes");
            DropForeignKey("dbo.SessionLogs", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.Sessions", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Sessions", "ColorDepthId", "dbo.RemoteDisplayColors");
            DropForeignKey("dbo.Contacts", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "ParentId", "dbo.Clients");
            DropIndex("dbo.SessionLogs", new[] { "SessionId" });
            DropIndex("dbo.Sessions", new[] { "SizeId" });
            DropIndex("dbo.Sessions", new[] { "ColorDepthId" });
            DropIndex("dbo.Sessions", new[] { "ClientId" });
            DropIndex("dbo.Contacts", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "ParentId" });
            DropTable("dbo.RemoteScreenSizes");
            DropTable("dbo.SessionLogs");
            DropTable("dbo.Sessions");
            DropTable("dbo.RemoteDisplayColors");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
        }
    }
}
