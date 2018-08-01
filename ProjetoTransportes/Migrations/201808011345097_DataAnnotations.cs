namespace ProjetoTransportes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Motoristas", "NomeCompleto", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Motoristas", "NomeCompleto", c => c.String());
        }
    }
}
