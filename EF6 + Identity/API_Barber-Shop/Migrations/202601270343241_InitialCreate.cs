namespace API_Barber_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Telefone = c.String(nullable: false, maxLength: 11),
                        Especialidade = c.String(nullable: false, maxLength: 150),
                        Status = c.Int(nullable: false),
                        Admissão = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Barbershops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        IdentityUserId = c.String(nullable: false, maxLength: 128),
                        Contato = c.String(maxLength: 11),
                        Email = c.String(),
                        Endereco = c.String(maxLength: 150),
                        DiasDaSemana = c.Int(nullable: false),
                        Abertura = c.Time(nullable: false, precision: 7),
                        Fechamento = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUserId, cascadeDelete: true)
                .Index(t => t.IdentityUserId);           
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        IdentityUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUserId, cascadeDelete: true)
                .Index(t => t.IdentityUserId);           
            
            CreateTable(
                "dbo.Schedulings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        BarberId = c.Int(nullable: false),
                        DataeHora = c.DateTime(nullable: false),
                        Observacoes = c.String(maxLength: 400),
                        ValorTotal = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarberId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.BarberId);
            
            CreateTable(
                "dbo.SchedulingServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchedulingId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedulings", t => t.SchedulingId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.SchedulingId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Descricao = c.String(maxLength: 500),
                        Preco = c.Double(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SchedulingServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.SchedulingServices", "SchedulingId", "dbo.Schedulings");
            DropForeignKey("dbo.Schedulings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Schedulings", "BarberId", "dbo.Barbers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Clients", "IdentityUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Barbershops", "IdentityUserId", "dbo.AspNetUsers");
            DropIndex("dbo.SchedulingServices", new[] { "ServiceId" });
            DropIndex("dbo.SchedulingServices", new[] { "SchedulingId" });
            DropIndex("dbo.Schedulings", new[] { "BarberId" });
            DropIndex("dbo.Schedulings", new[] { "ClientId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Clients", new[] { "IdentityUserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Barbershops", new[] { "IdentityUserId" });
            DropTable("dbo.Services");
            DropTable("dbo.SchedulingServices");
            DropTable("dbo.Schedulings");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Clients");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Barbershops");
            DropTable("dbo.Barbers");
        }
    }
}
