using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2A1IDEASMR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            Form altaPaciente = new FormularioPaciente();
            altaPaciente.Show();

        }

        private void btnPacXMed_Click(object sender, EventArgs e)
        {
            Form medicos = new FrmBuscarAMR();
            medicos.Show();
        }

        private void btnModificarEliPaciente_Click(object sender, EventArgs e)
        {
            Form modificarPaciente = new FrmMedicosAdmAMR();
            modificarPaciente.Show();
        }

        private void btnAltaMedico_Click(object sender, EventArgs e)
        {
            Form altaMedico = new FrmMedicosAMR();
            altaMedico.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form modificarMedico = new FrmMedicosAdmAMR();
            modificarMedico.Show();
        }
    }
}
