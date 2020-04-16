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
    }
}
