using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U2A1IDEASMR.DAO;

namespace U2A1IDEASMR
{
    public partial class FrmBuscarAMR : Form
    {
        public FrmBuscarAMR()
        {
            InitializeComponent();
            llenaCboMedicos();//para llamar al metodo que muestra la lista de medicos disponibles
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxListaMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
               
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Toma el idMedico seleccionado del comboBox           
            int idMedico = Int32.Parse(cbxMedicos.SelectedValue.ToString());
            
            //Crea una instancia de PacienteDAO 
            PacienteDAO datosPacienteXmedico = new PacienteDAO();

            //crea una instancia de DataTable
            DataTable datospaciente = new DataTable();
            //llena datospaciente con el metodo cargaPacientesAllbyidMedico de PacienteDAO utilizando como parametro el idMedico
            datospaciente = datosPacienteXmedico.cargaPacientesAllbyidMedico(idMedico);

            //Muestra en el dataGridView los datos obtenidos en datospaciente
            dataGPacientes.DataSource = datospaciente;


        }


        private void llenaCboMedicos()
        {
            //2
            //cbxMedicos.DataSource = null
            cbxMedicos.Items.Clear();
            //cbxMedicos.Items.Add("Carlos Alberto Lagun");
            //cbxMedicos.Items.Add("Nain Maldonado Guz");
            //cbxMedicos.Items.Add("Edgar Cerón García");
            //cbxMedicos.Items.Add("Rafael Arteaga Covar");
            //cbxMedicos.Items.Add("Esther Gaitán Ortiz");



            //invocar metodo listaMedicosALL para recuperar datos del medico
            MedicoDAO obtenerDatosMedico = new MedicoDAO();
            DataTable datosRecuperados = obtenerDatosMedico.listaMedicosALL();



            //Insertar en listado de medico en datatable al combo
            //asignar los datos de la consulta a un combobox
            cbxMedicos.ValueMember = "idMedico";
            cbxMedicos.DisplayMember = "nombreCompleto"; //lo que se va a mostrar
            cbxMedicos.DataSource = datosRecuperados; //para llenar el combobox 

        }
    }
}
