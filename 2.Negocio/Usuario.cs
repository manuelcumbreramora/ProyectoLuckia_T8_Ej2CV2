using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    public class Usuario
    {
        public Usuario()
        {
            this.idUsuario = 1;
        }

        public string login { get; set; }
        public string pass { get; set; }
        public string estadoCuenta { get; set; }
        public int idUsuario { get; set; }
        public Monedero monederoUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }

        public void CrearUsuario(string login,string pass)
        {
            this.login = login;
            this.pass = pass;
        }
    }
}
