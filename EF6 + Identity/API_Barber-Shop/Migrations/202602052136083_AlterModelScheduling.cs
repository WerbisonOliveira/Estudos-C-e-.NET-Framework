namespace API_Barber_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterModelScheduling : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedulings", "ClientId", "dbo.Clients");
            DropIndex("dbo.Schedulings", new[] { "ClientId" });
            AddColumn("dbo.Schedulings", "Client_Id", c => c.Int());
            AlterColumn("dbo.Schedulings", "ClientId", c => c.String(nullable: false));
            CreateIndex("dbo.Schedulings", "Client_Id");
            AddForeignKey("dbo.Schedulings", "Client_Id", "dbo.Clients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedulings", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Schedulings", new[] { "Client_Id" });
            AlterColumn("dbo.Schedulings", "ClientId", c => c.Int(nullable: false));
            DropColumn("dbo.Schedulings", "Client_Id");
            CreateIndex("dbo.Schedulings", "ClientId");
            AddForeignKey("dbo.Schedulings", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
    }
}
