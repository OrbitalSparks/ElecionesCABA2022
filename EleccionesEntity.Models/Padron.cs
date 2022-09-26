using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Padron
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Elector> electores { get; set; }
    }
}
