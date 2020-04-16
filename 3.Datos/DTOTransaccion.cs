using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Datos
{
    public class DTOTransaccion
    {

        public DTOTransaccion(int importe, int idMonedero, string tipoTransaccion, DateTime fechaCreacion, int idTransaccion)
        {
            this.importe = importe;
            this.idMonedero = idMonedero;
            this.tipoTransaccion = tipoTransaccion;
            this.fechaCreacion = fechaCreacion;
            this.idTransaccion = idTransaccion;
        }

        public int idTransaccion { get; set; }
        public int importe { get; set; }
        public int idMonedero { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string tipoTransaccion { get; set; }





    }
}
