using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Distrito
    {
        public int id { get; set; }

        public string nombre { get; set; }//CABA

        public List<Seccion> secciones { get; set; }
    }
}
