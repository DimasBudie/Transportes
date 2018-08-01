namespace ProjetoTransportes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motoristas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(),
                        CPF = c.String(),
                        RG = c.String(),
                        UF = c.String(),
                        Emissor = c.String(),
                        DataEmissao = c.DateTime(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Endereco = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Celular2 = c.String(),
                        Operadora = c.String(),
                        RegistroCNH = c.String(),
                        Validade = c.DateTime(nullable: false),
                        PrimeiraHabilitacao = c.DateTime(nullable: false),
                        Cedula = c.String(),
                        DataEmissaoCNH = c.DateTime(nullable: false),
                        Detran = c.String(),
                        PontuacaoAtual = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Referencias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        GrauParentesco = c.String(),
                        IsProfissional = c.Boolean(nullable: false),
                        IsPessoal = c.Boolean(nullable: false),
                        Motorista_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Motoristas", t => t.Motorista_ID)
                .Index(t => t.Motorista_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Referencias", "Motorista_ID", "dbo.Motoristas");
            DropIndex("dbo.Referencias", new[] { "Motorista_ID" });
            DropTable("dbo.Referencias");
            DropTable("dbo.Motoristas");
        }
    }
}
