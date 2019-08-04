using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UnivaEats.Classes
{
    class Usuario
    {
        public int  matricula { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        public string apellidopaterno { get; set; }

        public string apellidomaterno { get; set; }

        public string password { get; set; }
        public string tipo { get; set; }

    }
}
