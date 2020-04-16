using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Datos;

namespace _2.Negocio
{
    class Sistema
    {
        Usuario usuario = new Usuario();
        Monedero monedero = new Monedero();
        Transaccion transaccion;
        //Registro del usuario
        public Usuario registroUsuario(string login, string pass)
        {
            usuario.CrearUsuario(login, pass);
            monedero.CrearMonedero(usuario.idUsuario, 0);
            asignarMonederoAUsuario(usuario, monedero);
            return usuario;
            
        }
        //Verifica si existe el login y la pass del usuario que se pasa 
        public void verificarLogin(string login, string pass)
        {
            RepositoryDAL.verificarLogin(login, pass);
        }
        //Comprueba si el login existe en los registros
        public void existeLogin(string login)
        {
            RepositoryDAL.ComprobarLogin(login);
        }
        public void realizarTransaccion(int importe, int idMonedero, string tipoTransaccion)
        {
            recuperarMonederoDeDB(idMonedero);
            monedero.ComprobarSaldo();
            monedero.RestarSaldo(importe);
            transaccion = new Transaccion(importe, idMonedero, tipoTransaccion);
            //TODO: Metodo que guarde el la transaccion el DB
        }
        private void asignarMonederoAUsuario(Usuario usuario, Monedero monedero)
        {
            usuario.monederoUsuario = monedero;
        }
        private void recuperarMonederoDeDB(int idMonedero)
        {
            try
            {
                DTOMonedero dtMone = RepositoryDAL.recuperarMonedero(idMonedero);
                monedero.idMonedero = dtMone.idMonedero;
                monedero.idUsuario = dtMone.idUsuario;
                monedero.saldo = dtMone.saldo;
                monedero.divisa = dtMone.divisa;
                
            }catch(NullReferenceException ex)
            {
            }
        }

        public void historialTransacciones()
        {
            RepositoryDAL.listarTransacciones();
        }
    }
}
