
namespace U2A1IDEASMR
{
    partial class FrmBuscarAMR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaMedicos = new System.Windows.Forms.Label();
            this.cbxMedicos = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGPacientes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaMedicos
            // 
            this.ListaMedicos.AutoSize = true;
            this.ListaMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMedicos.Location = new System.Drawing.Point(73, 191);
            this.ListaMedicos.Name = "ListaMedicos";
            this.ListaMedicos.Size = new System.Drawing.Size(105, 29);
            this.ListaMedicos.TabIndex = 0;
            this.ListaMedicos.Text = "Medicos";
            this.ListaMedicos.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxMedicos
            // 
            this.cbxMedicos.BackColor = System.Drawing.Color.Azure;
            this.cbxMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedicos.ForeColor = System.Drawing.Color.Black;
            this.cbxMedicos.FormattingEnabled = true;
            this.cbxMedicos.Location = new System.Drawing.Point(203, 188);
            this.cbxMedicos.Name = "cbxMedicos";
            this.cbxMedicos.Size = new System.Drawing.Size(272, 37);
            this.cbxMedicos.TabIndex = 1;
            this.cbxMedicos.SelectedIndexChanged += new System.EventHandler(this.cbxListaMedicos_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(540, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGPacientes
            // 
            this.dataGPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGPacientes.Location = new System.Drawing.Point(52, 270);
            this.dataGPacientes.Name = "dataGPacientes";
            this.dataGPacientes.RowHeadersWidth = 51;
            this.dataGPacientes.RowTemplate.Height = 24;
            this.dataGPacientes.Size = new System.Drawing.Size(637, 171);
            this.dataGPacientes.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2A1IDEASMR.Properties.Resources.kisspng_medical_record_computer_icons_patient_hospital_pharma_5abd437551f1c5_4975200815223530133357;
            this.pictureBox1.Location = new System.Drawing.Point(520, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(115, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pacientes por Médico";
            // 
            // FrmBuscarAMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGPacientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxMedicos);
            this.Controls.Add(this.ListaMedicos);
            this.Name = "FrmBuscarAMR";
            this.Text = "FrmBuscarAMR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaMedicos;
        private System.Windows.Forms.ComboBox cbxMedicos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}