namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualiza_usuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "SALT", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Usuario", "Senha", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "Senha", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.Usuario", "SALT");
        }
    }
}
