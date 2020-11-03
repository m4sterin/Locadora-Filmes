namespace Locadora.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bresque : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Filmes", newName: "Filme");
            AlterColumn("dbo.Filme", "Nome", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Filme", "IdAlbum");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Filme", new[] { "IdAlbum" });
            AlterColumn("dbo.Filme", "Nome", c => c.String());
            RenameTable(name: "dbo.Filme", newName: "Filmes");
        }
    }
}
