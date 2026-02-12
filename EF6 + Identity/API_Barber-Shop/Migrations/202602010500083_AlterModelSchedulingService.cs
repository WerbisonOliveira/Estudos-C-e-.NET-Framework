namespace API_Barber_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterModelSchedulingService : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedulings", "BarberId", "dbo.Barbers");
            DropIndex("dbo.Schedulings", new[] { "BarberId" });
            AlterColumn("dbo.Schedulings", "BarberId", c => c.Int());
            CreateIndex("dbo.Schedulings", "BarberId");
            AddForeignKey("dbo.Schedulings", "BarberId", "dbo.Barbers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedulings", "BarberId", "dbo.Barbers");
            DropIndex("dbo.Schedulings", new[] { "BarberId" });
            AlterColumn("dbo.Schedulings", "BarberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Schedulings", "BarberId");
            AddForeignKey("dbo.Schedulings", "BarberId", "dbo.Barbers", "Id", cascadeDelete: true);
        }
    }
}
