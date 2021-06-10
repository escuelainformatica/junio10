using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.repo
{
    public class UsuarioRepo
    {
        public static string ObtenerToken(Usuarios usr)
        {
            var resultado="";
            using(var contexto=new Model1())
            {
                var encontrado=contexto.Usuarios
                    .Where( u => u.Usuario==usr.Usuario)
                    .Where( u => u.Clave==usr.Clave)
                    .FirstOrDefault();   
                 if(encontrado==null)
                {
                    resultado=null;
                } else
                {
                    resultado=encontrado.Token;
                }
            }
           return resultado;
            
        }
    }
}