using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class AgrupacionPolitica
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Candidato> candidatos { get; set; }
    }
}
