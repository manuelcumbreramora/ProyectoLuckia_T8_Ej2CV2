using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    public class Monedero
    {
        public float saldo { get; set; }
        public int idMonedero { get; set; }
        public string divisa { get; set; }
        public int idUsuario { get; set; }
        public Monedero()
        {

        }

        public bool CrearMonedero(int idUsuario, int saldo)
        {
            return true;
        }
        public int ComprobarSaldo()
        {
            return 1;
        }
        public void RestarSaldo(float importe)
        {
            this.saldo = this.saldo - importe;
        }
        public void SumarSaldo(float importe)
        {
            this.saldo = this.saldo + importe;
        }

    }
}
