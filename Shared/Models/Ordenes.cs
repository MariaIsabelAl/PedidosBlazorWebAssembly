using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazorWebAssembly.Shared.Models
{
    public class Ordenes
    {
        
        public int ordenId { get; set; }

        public DateTime fecha { get; set; }

        public int suplidorId { get; set; }

        public decimal monto { get; set; }

        //[ForeignKey("ordenId")]
        public virtual List<OrdenesDetalle> OrdenDetalles { get; set; }

        public Ordenes()
        {
            ordenId = 0;
            fecha = DateTime.Now;
            suplidorId = 0;
            monto = 0;
            OrdenDetalles = new List<OrdenesDetalle>();
        }
    }
}