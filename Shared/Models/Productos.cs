using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PedidosBlazorWebAssembly.Shared.Models
{
    public class Productos
    {
       
        public int productoId { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public int inventario { get; set; }

        public Productos()
        {
            productoId = 0;
            descripcion = string.Empty;
            costo = 0;
            inventario = 0;
        }
    }
}