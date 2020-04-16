using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Datos;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            RepositoryDAL.CrearDDBB();
            foreach (DTOTest t in RepositoryDAL.tests)
            {
                Console.WriteLine(t.id + t.nombre);
            }
            Console.ReadLine();
        }
    }
}
