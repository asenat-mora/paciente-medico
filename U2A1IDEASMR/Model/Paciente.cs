using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2A1IDEASMR.Model
{
    class Paciente //5
    {
       // public int idPaciente { get; set; }
        public String NombreCompleto { get; set; }
        public String direccion { get; set; }
        public String telefonoFijo { get; set; }
        public String celular { get; set; }
        public int edad { get; set; }
        public char sexo { get; set; }
        public String email { get; set; }
        public int edoCivil { get; set; }
        public int idMedico { get; set; }
        

        public Paciente() { 
        
        }
        
        //contructor con argumentos
        //int idPaciente,
        public Paciente( string nombreCompleto, string direccion, string telefonoFijo, string celular, int edad, char sexo, string email, int edoCivil,int idMedico)
        {
            //this.idPaciente = idPaciente;
            NombreCompleto = nombreCompleto;
            this.direccion = direccion;
            this.telefonoFijo = telefonoFijo;
            this.celular = celular;
            this.edad = edad;
            this.sexo = sexo;
            this.email = email;
            this.edoCivil = edoCivil;
            this.idMedico = idMedico;


        }






    }
}
