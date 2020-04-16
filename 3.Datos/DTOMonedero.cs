using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Datos
{
    public class DTOMonedero
    {
        public float saldo { get; set; }
        public int idMonedero { get; set; }
        public string divisa { get; set; }
        public int idUsuario { get; set; }
        public DTOMonedero()
        {

        }
    }
}