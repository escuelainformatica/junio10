using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoNetCore.Models
{
    public partial class Compra
    {
        public int IdCompra { get; set; }
        public int? NumeroMes { get; set; }
        public int? Monto { get; set; }
    }
}
