using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazorWebAssembly.Shared.Models
{
    public class Suplidores
    {
        public int suplidorId { get; set; }
        public string nombre { get; set; }

        public Suplidores()
        {
            suplidorId = 0;
            nombre = string.Empty;
        }
    }
}