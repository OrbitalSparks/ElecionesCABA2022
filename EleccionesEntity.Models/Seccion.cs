using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Seccion
    {
        public int id { get; set; }
        public string nombre { get; set; }// Primera, segunda
        public List<Circuito> circuitos { get; set; }
    }
}
