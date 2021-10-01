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
    public partial class FrmMedicosAdmAMR : Form
    {
        public FrmMedicosAdmAMR()
        {
            InitializeComponent();
            llenaCboMedicos();//para llamar al metodo que muestra la lista de medicos disponibles
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Toma el idMedico seleccionado del comboBox           
            int idMedico = Int32.Parse(cbxMedicos.SelectedValue.ToString());

            //Crea una instancia de PacienteDAO 
            MedicoDAO datosXmedico = new MedicoDAO();

            //crea una instancia de DataTable
            DataTable datosMedico = new DataTable();
            //llena datospaciente con el metodo cargaPacientesAllbyidMedico de PacienteDAO utilizando como parametro el idMedico
            datosMedico = datosXmedico.cargaMedicoAllbyidMedico(idMedico);

            //Muestra en el dataGridView los datos obtenidos en datosMedico
            dataGMedico.DataSource = datosMedico;



        }

        private void TxtNombreMedico_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void llenaCboMedicos()
        {

            cbxMedicos.Items.Clear();

            //invocar metodo listaMedicosALL para recuperar datos del medico
            MedicoDAO obtenerDatosMedico = new MedicoDAO();
            DataTable datosRecuperados = obtenerDatosMedico.listaMedicosALL();

            //Insertar en listado de medico en datatable al combo
            //asignar los datos de la consulta a un combobox
            cbxMedicos.ValueMember = "idMedico";
            cbxMedicos.DisplayMember = "nombreCompleto"; //lo que se va a mostrar
            cbxMedicos.DataSource = datosRecuperados; //para llenar el combobox 

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}

