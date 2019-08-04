using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UnivaEats.Classes
{
    class Pedidos
    {
        public int matricula { get; set; }

        [StringLength(50)]

        public string pedido { get; set; }

        public string total { get; set; }

        public DateTime fecha { get; set; }
    }
}
