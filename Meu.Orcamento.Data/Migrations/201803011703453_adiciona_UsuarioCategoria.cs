namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adiciona_UsuarioCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioCategoria",
                c => new
                    {
                        UsuarioId = c.Guid(nullable: false),
                        CategoriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UsuarioId, t.CategoriaId })
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.UsuarioId)
                .Index(t => t.CategoriaId);
            
            AddColumn("dbo.Categoria", "TipoCategoria", c => c.Int(nullable: false));
            AddColumn("dbo.Lancamento", "UsuarioId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Lancamento", "UsuarioId");
            AddForeignKey("dbo.Lancamento", "UsuarioId", "dbo.Usuario", "UsuarioId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lancamento", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.UsuarioCategoria", "CategoriaId", "dbo.Categoria");
            DropForeignKey("dbo.UsuarioCategoria", "UsuarioId", "dbo.Usuario");
            DropIndex("dbo.UsuarioCategoria", new[] { "CategoriaId" });
            DropIndex("dbo.UsuarioCategoria", new[] { "UsuarioId" });
            DropIndex("dbo.Lancamento", new[] { "UsuarioId" });
            DropColumn("dbo.Lancamento", "UsuarioId");
            DropColumn("dbo.Categoria", "TipoCategoria");
            DropTable("dbo.UsuarioCategoria");
        }
    }
}
