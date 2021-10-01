using MySql.Data.MySqlClient;
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
using U2A1IDEASMR.Model;

namespace U2A1IDEASMR
{
    public partial class FormularioPaciente : Form
    {
        public FormularioPaciente()
        {
            InitializeComponent();
            llenaCboEstadoCivil();//Llena el cbo de estado civil
            llenaCboMedicos();//para llamar al metodo que muestra la lista de medicos disponibles
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Hacer validaciones tipo de sexo
            char sexo;
            if (radiobtnFemenino.Checked){
                
                sexo = char.Parse("F");
            }else if (radiobtnMasculino.Checked){
                
                sexo = char.Parse("M");
            }else{
                
                MessageBox.Show("Favor de seleccionar el sexo");
                return;
            }


            //crear el objeto de la clase paciente 
            String NombreCompleto = TxtNombreC.Text;
            String direccion = txtDireccion.Text;
            String telefonoFijo = txtTelFijo.Text;
            String celular = txtCelular.Text;
            int edad = int.Parse(txtEdad.Text);
            String email = txtEmail.Text;

            int idEstadocivil = Int32.Parse(CbxEdoCivil.SelectedValue.ToString());
            int idMedico = Int32.Parse(cbxMedicos.SelectedValue.ToString());

            //Prueba de conexion a la BD
            //ConnectionDB sdfsdf = new ConnectionDB();
            //sdfsdf.abrir();


            //Paciente agregar = new Paciente();
            Paciente registrarPaciente = new Paciente(NombreCompleto, direccion, telefonoFijo, celular,edad, sexo, email, idEstadocivil, idMedico);

            int idPacienteRegistrado = PacienteDAO.insert(registrarPaciente);

            if (idPacienteRegistrado == 0) {
                MessageBox.Show("Ocurrio un error");
            }
            else{
                MessageBox.Show("El paciente se registro correctamente con el número: " + idPacienteRegistrado);
            }



            //Notificación anterior que mostraba si el paciente fue registrado.
            //Boolean paso = PacienteDAO.insert(registrarPaciente);

            //if (paso)
            //{
            //    MessageBox.Show("Se Agrego correctamente");
            //}
            //else
            //{
            //    MessageBox.Show("Ocurrio un error");
            //}

         


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        //metodos
        private void llenaCboMedicos() {

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

        private void llenaCboEstadoCivil()
        {

            CbxEdoCivil.Items.Clear();
            
            //invocar metodo listaEstadoCivilsALL
            PacienteDAO obtenerDatosEstadoCivil = new PacienteDAO();
            DataTable datosRecuperados = obtenerDatosEstadoCivil.listaEstadoCivilALL();

            //Insertar en listado de Sexo en datatable al combo
            //asignar los datos de la consulta a un combobox
            CbxEdoCivil.ValueMember = "idEstadocivil";
            CbxEdoCivil.DisplayMember = "edoCivil"; //lo que se va a mostrar
            CbxEdoCivil.DataSource = datosRecuperados; //para llenar el combobox edoCivil


        }

    }
}
