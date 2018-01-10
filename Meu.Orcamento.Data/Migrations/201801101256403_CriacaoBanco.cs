namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lancamento",
                c => new
                    {
                        LancamentoId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 100, unicode: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.LancamentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lancamento");
        }
    }
}
