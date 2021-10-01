using MySql.Data.MySqlClient;//9.1
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U2A1IDEASMR.Model;

namespace U2A1IDEASMR.DAO//7
{
    class PacienteDAO //6
    {
        
        public static int insert(Paciente paciente)//8
        {//9

            //int idPaciente = new int();
            int idPaciente = 0;
            String queryInsert = String.Format(
            "insert into tbPaciente (`nombreCompleto`,`direccion`,`telefonoFijo`,`celular`,`edad`,`sexo`,`email`,`idestadocivil`,`idMedico`) " +
            "values ('{0}','{1}','{2}','{3}',{4},'{5}','{6}',{7},{8}); SELECT LAST_INSERT_ID();",
            paciente.NombreCompleto, paciente.direccion, paciente.telefonoFijo, paciente.celular, paciente.edad, paciente.sexo, paciente.email, paciente.idMedico, paciente.idMedico);

            //String otroforma = "INSERT INTO tbpaciente ('nombreCompleto','direccion','telefonoFijo','celular','edad','sexo','email','edoCivil') VALUES (" + "'" + paciente.NombreCompleto + "','" + paciente.direccion + "','" + paciente.telefonoFijo + "','" + paciente.celular + "','" + paciente.edad + "','" + paciente.sexo + "','" + paciente.email + "','" + paciente.edoCivil + "')";

            //Se establece conexion a la BD 
            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryInsert, conexionBD.Conectarbd);
                command.Connection.Open();
                idPaciente = Convert.ToInt32(command.ExecuteScalar());
                conexionBD.Conectarbd.Close();
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            return idPaciente;
        }



        public DataTable listaEstadoCivilALL()
        {
            DataTable Datos = new DataTable();

            //generar la consulta
            string queryListamedicos = String.Format("Select idEstadocivil, edoCivil FROM tbestadocivil");

            // Se establece conexion a la BD
            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryListamedicos, conexionBD.Conectarbd);
                MySqlDataAdapter data = new MySqlDataAdapter(command);//MySqlDataAdapter adaptador de funciones con la consulta y lo que encuentre lo guarda en comand
                data.Fill(Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se cargo la lista de medicos " + ex.Message);
            }

            return Datos;
        }


        /*
         Metodo que trae el catalogo de pacientes por medico
        */


        public DataTable cargaPacientesAllbyidMedico(int idMedico){

            DataTable datospaciente = new DataTable();

            String queryDatatable = String.Format("Select * from tbPaciente WHERE idMedico = {0}", idMedico  );

            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryDatatable, conexionBD.Conectarbd);
                conexionBD.abrir();

                // create data adapter
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                // this will query your database and return the result to your datatable
                da.Fill(datospaciente);
                conexionBD.cerrar();
                da.Dispose(); //liberar la carga de la instrucción 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return datospaciente;

        }


    }

}

