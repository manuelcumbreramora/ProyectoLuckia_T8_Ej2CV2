using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    public class Transaccion
    {
        public Transaccion(int importe, int idMonedero, string tipoTransaccion)
        {
            this.importe = importe;
            this.idMonedero = idMonedero;
            this.tipoTransaccion = tipoTransaccion;
            this.fechaCreacion = DateTime.Now;
            this.idTransaccion = 1; //Generar o get
        }
        public Transaccion()
        {

        }
        public int idTransaccion { get; set; }
        public int importe { get; set; }
        public int idMonedero { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string tipoTransaccion { get; set; }






    }
}
