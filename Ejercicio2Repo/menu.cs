using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Negocio;

namespace Ejercicio2Repo
{
       
    public class Menu
    {
        int eleccionUsuario1, importe, idMonedero;
        string nombre, pass, tipoTransaccion;
        Sistema s = new Sistema();
        public void generarMenu1() {
            Console.WriteLine("Qué quiere hacer?");
            Console.WriteLine("1: Registrar nuevo usuario");
            Console.WriteLine("2: Realizar depósito");
            Console.WriteLine("3: Consultar histórico de transacciones de un jugador");
            Console.WriteLine("4: Salir");
        
        }

        public void ejecucion()
        {
            while (eleccionUsuario1 != 4) {

                switch (eleccionUsuario1)
                {
                    case 1:
                        Console.WriteLine("Ha elegido registrar un nuevo usuario");
                        Console.WriteLine("Introduzca su nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Introduzca su password");
                        pass = Console.ReadLine();
                        s.registroUsuario(nombre, pass);
                        break;

                    case 2:
                        Console.WriteLine("Ha elegido realizar depósito. Cuánto quiere ingresar?");
                        importe = Int32.Parse(Console.ReadLine());
                        idMonedero = 1;
                        tipoTransaccion = "retirada";
                        s.realizarTransaccion(importe, idMonedero, tipoTransaccion);
                        break;

                    case 3:
                        Console.WriteLine("Ha elegido consultar el histórico de transacciones");
                        s.historialTransacciones();
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }


            }


        }




    }
}
