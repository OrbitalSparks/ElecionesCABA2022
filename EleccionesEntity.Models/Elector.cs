using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesEntity.Models
{
    public class Elector : Persona
    {
        public bool? voto { get; set; } //Para saber si votó o no.
        public bool? habilitado { get; set; } //para saber si está habilitado.
    }
}
