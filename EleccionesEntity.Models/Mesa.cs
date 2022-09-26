using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Mesa
    {
        public int id { get; set; }
        public int numeroMesa { get; set; }

        public List<Voto> votos { get; set; }

        public Padron padron { get; set; }
    }
}
