using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Junio10.repo
{
    public class CompraRepo
    {
        public static List<ClaseResultadoAgrupacion> ListarAgrupado()
        {
            var r=new List<ClaseResultadoAgrupacion>();
            using(var contexto=new Model1())
            {
                r=contexto.Compras
                    .GroupBy(c=>c.NumeroMes) 
                    .Select(g => new ClaseResultadoAgrupacion
                    {
                        NumMes=g.Key,
                        Total=g.Sum(c=>c.Monto)
                    })
                    .ToList();
            }
            Thread.Sleep(5000);
            return r;
        }
    }
}