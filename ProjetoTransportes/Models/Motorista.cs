using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTransportes.Models
{
    public class Motorista
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string UF { get; set; }
        public string Emissor { get; set; }
        [Display(Name = "Data de Emissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataEmissao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Celular2 { get; set; }
        public string Operadora { get; set; }
        public string RegistroCNH { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Validade { get; set; }
        public char Categoria { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PrimeiraHabilitacao { get; set; }
        public string Cedula { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataEmissaoCNH { get; set; }
        public string Detran { get; set; }
        public int PontuacaoAtual{ get; set; }
        public List<Referencia> Referencias { get; set; }
    }

    public class Referencia
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string GrauParentesco { get; set; }
        public bool IsProfissional { get; set; }
        public bool IsPessoal { get; set; }
    }

    public class TransporteDBContext : DbContext
    {
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}