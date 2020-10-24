using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazorWebAssembly.Shared.Models
{
    public class OrdenesDetalle
    {
        public int ordenDetalleId { get; set; }
        public int ordenId { get; set; }
        public int productoId { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }

        public OrdenesDetalle()
        {
            ordenDetalleId = 0;
            ordenId = 0;
            productoId = 0;
            cantidad = 0;
            costo = 0;
        }


    }
}