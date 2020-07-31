using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria.Model
{
    public class reponseArticulo
    {
        public bool success { get; set; }
        public List<article> articles { get; set; }
        public string error_msg { get; set; }
    }
}
