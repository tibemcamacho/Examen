using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria.Model
{
    public class reponseAlmacen
    {
        public bool success { get; set; }
        public List<Store> stores { get; set; }
        public string error_msg { get; set; }
    }
}
