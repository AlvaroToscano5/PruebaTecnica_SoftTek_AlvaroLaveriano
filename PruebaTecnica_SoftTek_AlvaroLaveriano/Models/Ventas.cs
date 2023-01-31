using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica_SoftTek_AlvaroLaveriano.Models
{
    public class Ventas
    {
        public string producto { get; set; }
        public string cantidad { get; set; }
        public string impUnitario { get; set; }
        public string impTotal { get; set; }
    }
}