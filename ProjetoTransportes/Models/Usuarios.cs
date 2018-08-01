using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoTransportes.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public long CPF { get; set; }
        public byte[] Foto { get; set; }
    }
}