using Junio10.Models;
using Junio10.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Junio10.api
{
    // RESTFUL

    public class CompraAPIController : ApiController
    {
        [Route("CompraAPI/ListarAgrupado")]  // {argumento}
        public List<ClaseResultadoAgrupacion> GetListarAgrupado()
        {
            return CompraRepo.ListarAgrupado();
        }
        // string usuario,string clave

        [Route("CompraAPI/ObtenerToken")]
        public string PostObtenerToken(Usuarios usr)
        {
            var r="";                
            r=UsuarioRepo.ObtenerToken(usr);
            return r;
        }

        [Route("CompraAPI/ListarAgrupado2")]
        public List<int?> GetListarAgrupado2()
        {
            List<string> encabezado =Request.Headers.GetValues("token").ToList();
            if(encabezado.Count()==0)
            {
                return null;
            }
            if(encabezado[0]!="ABC123456")
            {
                return null;
            }
            List<int?> lista=CompraRepo
                    .ListarAgrupado()
                    .Select(la=>la.Total)
                    .ToList();

            return lista;
        }

    }
}
