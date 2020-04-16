/**Formulario de registro de usuario: nueva cuenta de juego, fijando el estado de la cuenta, creación de los wallets del jugador.
	*Formulario para realizar una transacción de tipo depósito.
	*Histórico de transacciones de un jugador.	
	*Aportar comunicación con la aplicación de CASINO para que se puedan registrar las transacciones de juego.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.ejecucion();
            Console.ReadLine();


        }
    }
}
