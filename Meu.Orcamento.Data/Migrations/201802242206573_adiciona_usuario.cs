namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adiciona_usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        UltimoNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .Index(t => t.Email, unique: true, name: "UK_USUARIO_EMAIL");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "UK_USUARIO_EMAIL");
            DropTable("dbo.Usuario");
        }
    }
}
