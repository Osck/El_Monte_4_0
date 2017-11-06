namespace El_Monte_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarcelSegundaMigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Condenas", "CondenaDelitoId", c => c.Int(nullable: false));
            AddColumn("dbo.Presos", "Condena_ID", c => c.Int());
            CreateIndex("dbo.Condenas", "JuezId");
            CreateIndex("dbo.Condenas", "CondenaDelitoId");
            CreateIndex("dbo.CondenaDelitos", "DelitoId");
            CreateIndex("dbo.Presos", "Condena_ID");
            AddForeignKey("dbo.CondenaDelitos", "DelitoId", "dbo.Delitos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Condenas", "CondenaDelitoId", "dbo.CondenaDelitos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Condenas", "JuezId", "dbo.Jueces", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Presos", "Condena_ID", "dbo.Condenas", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Presos", "Condena_ID", "dbo.Condenas");
            DropForeignKey("dbo.Condenas", "JuezId", "dbo.Jueces");
            DropForeignKey("dbo.Condenas", "CondenaDelitoId", "dbo.CondenaDelitos");
            DropForeignKey("dbo.CondenaDelitos", "DelitoId", "dbo.Delitos");
            DropIndex("dbo.Presos", new[] { "Condena_ID" });
            DropIndex("dbo.CondenaDelitos", new[] { "DelitoId" });
            DropIndex("dbo.Condenas", new[] { "CondenaDelitoId" });
            DropIndex("dbo.Condenas", new[] { "JuezId" });
            DropColumn("dbo.Presos", "Condena_ID");
            DropColumn("dbo.Condenas", "CondenaDelitoId");
        }
    }
}
