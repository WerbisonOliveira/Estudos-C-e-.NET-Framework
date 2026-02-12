namespace API_Barber_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Barbers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Barbers", "Email", c => c.String(nullable: false));
        }
    }
}
