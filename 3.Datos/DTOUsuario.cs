using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Datos
{
    public class DTOUsuario
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string estadoCuenta { get; set; }
        public int idUsuario { get; set; }
        //public DTOMonedero monederoUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }

        public bool CrearUsuario(string login, string pass)
        {
            //Llamada a la BBDD
            return false;
        }
    }
}
