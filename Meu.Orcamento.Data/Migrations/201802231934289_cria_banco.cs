namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cria_banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaId = c.Guid(nullable: false),
                        Titulo = c.String(maxLength: 50, unicode: false),
                        Cor = c.String(maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Lancamento",
                c => new
                    {
                        LancamentoId = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoLancamento = c.Int(nullable: false),
                        DataLancamento = c.DateTime(nullable: false),
                        CategoriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.LancamentoId)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lancamento", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Lancamento", new[] { "CategoriaId" });
            DropTable("dbo.Lancamento");
            DropTable("dbo.Categoria");
        }
    }
}
