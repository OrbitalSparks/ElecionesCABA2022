using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Eleccion
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int año { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        public Distrito distrito { get; set; }

        public List<AgrupacionPolitica> agrupacionPolitica { get; set; }


        public string GetDatosEleccion()
        {
            return $"{nombre} {año}";
        }

    }

}
