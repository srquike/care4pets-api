namespace Care4Pets.Api.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableSpecies : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PetTypes", newName: "Species");
            RenameColumn(table: "dbo.Foods", name: "PetTypeId", newName: "SpeciesId");
            RenameIndex(table: "dbo.Foods", name: "IX_PetTypeId", newName: "IX_SpeciesId");
            AddColumn("dbo.Pets", "SpeciesId", c => c.Int());
            CreateIndex("dbo.Pets", "SpeciesId");
            AddForeignKey("dbo.Pets", "SpeciesId", "dbo.Species", "Id");
            DropColumn("dbo.Pets", "Specie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Specie", c => c.String());
            DropForeignKey("dbo.Pets", "SpeciesId", "dbo.Species");
            DropIndex("dbo.Pets", new[] { "SpeciesId" });
            DropColumn("dbo.Pets", "SpeciesId");
            RenameIndex(table: "dbo.Foods", name: "IX_SpeciesId", newName: "IX_PetTypeId");
            RenameColumn(table: "dbo.Foods", name: "SpeciesId", newName: "PetTypeId");
            RenameTable(name: "dbo.Species", newName: "PetTypes");
        }
    }
}
