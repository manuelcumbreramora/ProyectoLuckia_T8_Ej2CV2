using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    class Sistema
    {
        Usuario usuario = new Usuario();
        Monedero monedero = new Monedero();
        Transaccion transaccion;
        //protected string nombreMiembro;
        //Registro del usuario
        public Usuario registroUsuario(string login, string pass)
        {
            usuario.CrearUsuario(login, pass);
            monedero.CrearMonedero(usuario.idUsuario, 0);
            asignarMonederoAUsuario(usuario, monedero);
            return usuario;
            
        }
        //Verifica si existe el login y la pass del usuario que se pasa 
        public Usuario verificarLogin(string login, string pass)
        {
            if (usuario.login == login && usuario.pass == pass)
            {
                Console.WriteLine("Usuario verificado con exito.");
                return usuario;
            } else
            {
                Console.WriteLine("El usuario no esta verificado.");
                return null;
            }
        }
        //Comprueba si el login existe en los registros
        public void existeLogin(string login)
        {
            if (usuario.login == login)
            {
                Console.WriteLine("El usuario existe en nuestros registros");
            }
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
            //TODO: Metodo que enlaza el monedero seleccionado con su respectivo usuario
        }
        private void recuperarMonederoDeDB(int idMonedero)
        {
            monedero.idMonedero = idMonedero;
            //TODO: Metodo que busca la informacion en la DB
        }
    }
}
