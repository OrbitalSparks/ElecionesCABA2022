using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Circuito
    {
        public int id { get; set; }

        public string nombre { get; set; } //Parte de CABA
        public List<Mesa> mesas { get; set; }
    }
}
