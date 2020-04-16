using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    public class Usuario
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string estadoCuenta { get; set; }
        public int idUsuario { get; set; }
        public Monedero monederoUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }

        public bool CrearUsuario(string login,string pass)
        {
            //Llamada a la BBDD
            return false;
        }
    }
}
