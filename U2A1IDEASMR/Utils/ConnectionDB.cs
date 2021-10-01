using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace U2A1IDEASMR
{
    class ConnectionDB
    {
        //objeto para crear una conexion 
        public MySqlConnection Conectarbd = new MySqlConnection();
        //String que tiene el formato para crear una conexión con la bd
        string cadena = String.Format(
            "server={0};user={1};database={2};port={3};password={4};", 
            "localhost", "asenat", "DBU3AMR", "3306", "asenat");
                

        //Constructor
        public ConnectionDB()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
            }
        }
        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }


































        ////private MySqlConnection connection;//3

        //public MySqlConnection Connection{
        //    get { return ConnectionDB; }
        //    set { connection = value; }
        //}

        //public ConnectionDB()//2
        //{
        //    server = "localhost";
        //    uid = "asenat";
        //    password = "asenat";
        //    database = "DBU3AMR";
        //    port = "3306";

        //    connection = new MySqlConnection(String.Format("server={0};user={1};database={2};port={3};password={4};", server, uid, database, port, password));
        // }

        
    }
}
