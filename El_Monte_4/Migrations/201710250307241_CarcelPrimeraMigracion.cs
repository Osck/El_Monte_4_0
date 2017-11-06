namespace El_Monte_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarcelPrimeraMigracion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Condena", newName: "Condenas");
            RenameTable(name: "dbo.CondenaDelito", newName: "CondenaDelitos");
            RenameTable(name: "dbo.Delito", newName: "Delitos");
            RenameTable(name: "dbo.Juez", newName: "Jueces");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Jueces", newName: "Juez");
            RenameTable(name: "dbo.Delitos", newName: "Delito");
            RenameTable(name: "dbo.CondenaDelitos", newName: "CondenaDelito");
            RenameTable(name: "dbo.Condenas", newName: "Condena");
        }
    }
}
