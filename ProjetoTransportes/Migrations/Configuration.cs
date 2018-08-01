namespace ProjetoTransportes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoTransportes.Models.TransporteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjetoTransportes.Models.TransporteDBContext context)
        {
            context.Motoristas.AddOrUpdate(i => i.NomeCompleto,
                new Models.Motorista
                {
                    NomeCompleto = "José da Fonseca",
                    CPF = "04791690358",
                    RG = "29859401",
                    UF = "PR",
                    Emissor = "SSP",
                    DataEmissao = new DateTime(2000, 10, 24),
                    Bairro = "Alto Boqueirão",
                    Cidade = "Curitiba",
                    Endereco = "Rua 15 deNovembro",
                    Numero = 143,
                    Complemento = "Casa 6",
                    Celular = "41 992584362",
                    Operadora = "Vivo",
                    Estado = "Paraná",
                    DataNascimento = new DateTime(1987, 02, 10),
                    PrimeiraHabilitacao = new DateTime(2007, 10, 09),
                    Categoria = 'D',
                    DataEmissaoCNH = new DateTime(2014, 05, 23),
                    Validade = new DateTime(2019, 05, 23),
                    Detran = "PR",
                    PontuacaoAtual = 0
                },
                new Models.Motorista
                {
                    NomeCompleto = "Roberto Da Estrada",
                    CPF = "49102682077",
                    RG = "18440280",
                    UF = "SP",
                    Emissor = "SSP",
                    DataEmissao = new DateTime(1988, 03, 04),
                    Bairro = "Centro",
                    Cidade = "Registro",
                    Endereco = "Rua da cuabra",
                    Numero = 13345,
                    Complemento = "",
                    Celular = "11 993402341",
                    Operadora = "Tim",
                    Estado = "São Paulo",
                    DataNascimento = new DateTime(1970, 12, 04),
                    PrimeiraHabilitacao = new DateTime(1988, 04, 06),
                    Categoria = 'E',
                    DataEmissaoCNH = new DateTime(2017, 02, 16),
                    Validade = new DateTime(2022, 02, 16),
                    Detran = "SP",
                    PontuacaoAtual = 12
                });
        }
    }
}
