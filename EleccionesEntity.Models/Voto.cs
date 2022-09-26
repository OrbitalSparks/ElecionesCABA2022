using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Voto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Candidato cantidatoVotado { get; set; }
    }
}
