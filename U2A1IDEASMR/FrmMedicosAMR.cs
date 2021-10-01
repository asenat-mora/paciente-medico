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
    public partial class FrmMedicosAMR : Form
    {
        public FrmMedicosAMR()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnGuardar_Click(object sender, EventArgs e)
        {
                      
            //crear el objeto de la clase paciente 
            String NombreCompleto = TxtNombreMedico.Text;
            String cedula = txtCedula.Text;
            String especialidad = txtEspecialidad.Text;
       
          
            Medico registrarMedico = new Medico(NombreCompleto, cedula, especialidad);

            int idMedicoRegistrado = MedicoDAO.insertMedico(registrarMedico);

            if (idMedicoRegistrado == 0)
            {
                MessageBox.Show("Ocurrio un error");
            }
            else
            {
                MessageBox.Show("El paciente se registro correctamente con el número: " + idMedicoRegistrado);
            }

        }

        private void TxtNombreMedico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
