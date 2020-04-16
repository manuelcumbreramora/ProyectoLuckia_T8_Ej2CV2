using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;


namespace _3.Datos {
    public static class RepositoryDAL {
        public static List<DTOUsuario> DDBBUsuarios = new List<DTOUsuario>();
        public static List<DTOMonedero> DDBBMonederos = new List<DTOMonedero>();
        public static List<DTOTransaccion> DDBBTransacciones = new List<DTOTransaccion>();
        public static void CrearDDBB() {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string currPath, currJson;
            //Poblar usuarios
            currPath = Path.Combine(path, @"json\d_usuario.json");
            currJson = File.ReadAllText( currPath );
            DDBBUsuarios = JsonConvert.DeserializeObject<List<DTOUsuario>>(currJson);

            //Poblar monedero
            currPath = Path.Combine(path, @"json\d_monedero.json");
            currJson = File.ReadAllText(currPath);
            DDBBMonederos = JsonConvert.DeserializeObject<List<DTOMonedero>>(currJson);

            //Poblar transacciones
            currPath = Path.Combine(path, @"json\d_trans.json");
            currJson = File.ReadAllText(currPath);
            DDBBTransacciones = JsonConvert.DeserializeObject<List<DTOTransaccion>>(currJson);
        }

        public static void ComprobarLogin(string login)
        {
            bool correcto=false;
            foreach (var usuario in DDBBUsuarios)
            {
                if (usuario.login.Equals(login))
                    correcto = true;
            }
            if (correcto)
            {
                Console.WriteLine("El usuario existe");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }

            
        }
        public static void verificarLogin(string login, string pass)
        {
            bool correcto = false;
            foreach (var usuario in DDBBUsuarios)
            {
                if (usuario.login.Equals(login) && usuario.pass.Equals(pass))
                    correcto = true;
            }
            if (correcto)
            {
                Console.WriteLine("Datos de acceso correctos");
            }
            else
            {
                Console.WriteLine("El usuario/contraseña no son correctos");
            }
        }

        public static void listarTransacciones()
        {
            foreach(var trans in DDBBTransacciones)
            {
                Console.WriteLine(string.Format("Id: {0}", trans.idTransaccion));
                Console.WriteLine(string.Format("Tipo: {0}", trans.tipoTransaccion));
                Console.WriteLine(string.Format("Importe: {0}", trans.importe));
                Console.WriteLine(string.Format("Fecha: {0}", trans.fechaCreacion));
            }
        }

        public static DTOMonedero recuperarMonedero(int idMonedero)
        {
            foreach (var monedero in DDBBMonederos)
            {
                if (monedero.idMonedero == idMonedero)
                {
                    return monedero;
                }
            }
            return null;
        }

    }
}
