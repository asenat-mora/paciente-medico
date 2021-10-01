using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2A1IDEASMR.Model
{
    class Medico
    {
        // public int idMedico { get; set; }
        public String NombreCompleto { get; set; }
        public String cedula { get; set; }
        public String especialidad { get; set; }

        public Medico() { 
        
        }

        public Medico(string nombreCompleto, string cedula, string especialidad)
        {
            NombreCompleto = nombreCompleto;
            this.cedula = cedula;
            this.especialidad = especialidad;
        }




    }
}
