using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U2A1IDEASMR.Model;

namespace U2A1IDEASMR.DAO
{
    class MedicoDAO
    {

        //metodo para mostrar una lista de todos los medicos
        public DataTable listaMedicosALL()
        {
            DataTable Datos = new DataTable();

            //generar la consulta
            string queryListamedicos = String.Format("Select idMedico, nombreCompleto FROM tbMedico");

            // Se establece conexion a la BD
            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryListamedicos, conexionBD.Conectarbd);
                MySqlDataAdapter data = new MySqlDataAdapter(command);//MySqlDataAdapter adaptador de funciones con la consulta y lo que encuentre lo guarda en comand
                data.Fill(Datos);
            }
            catch (Exception ex) {
                MessageBox.Show("Error no se cargo la lista de medicos " + ex.Message);
            }

            return Datos;
        }




        //metodo para dar de alta un medico
        public static int insertMedico(Medico medico)//8
        {//9

            //int idPaciente = new int();
            int idMedico = 0;
            String queryInsert = String.Format(
            "insert into tbPaciente (`nombreCompleto`,`cedula`,`especialidad`) " +
            "values ('{0}','{1}','{2}'); SELECT LAST_INSERT_ID();",
            medico.NombreCompleto, medico.cedula, medico.especialidad);


            //Se establece conexion a la BD 
            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryInsert, conexionBD.Conectarbd);
                command.Connection.Open();
                idMedico = Convert.ToInt32(command.ExecuteScalar());
                conexionBD.Conectarbd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return idMedico;
        }


        //Metodo para cargar un medico 
        public DataTable cargaMedicoAllbyidMedico(int idMedico)
        {

            DataTable datosMedico = new DataTable();

            String queryDatatable = String.Format("Select * from tbPaciente WHERE idMedico = {0}", idMedico);

            try
            {
                ConnectionDB conexionBD = new ConnectionDB();
                MySqlCommand command = new MySqlCommand(queryDatatable, conexionBD.Conectarbd);
                conexionBD.abrir();

                // create data adapter
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                // 
                da.Fill(datosMedico);
                conexionBD.cerrar();
                da.Dispose(); //liberar la carga de la instrucción 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return datosMedico;

        }


        //Metodo para actualizar un medico












    }



}

      


