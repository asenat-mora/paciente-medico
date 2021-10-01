
namespace U2A1IDEASMR
{
    partial class FormularioPaciente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RbdSexo = new System.Windows.Forms.GroupBox();
            this.radiobtnMasculino = new System.Windows.Forms.RadioButton();
            this.radiobtnFemenino = new System.Windows.Forms.RadioButton();
            this.CbxEdoCivil = new System.Windows.Forms.ComboBox();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelFijo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMedicos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RbdSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RbdSexo
            // 
            this.RbdSexo.BackColor = System.Drawing.Color.Azure;
            this.RbdSexo.Controls.Add(this.radiobtnMasculino);
            this.RbdSexo.Controls.Add(this.radiobtnFemenino);
            this.RbdSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdSexo.Location = new System.Drawing.Point(293, 493);
            this.RbdSexo.Name = "RbdSexo";
            this.RbdSexo.Size = new System.Drawing.Size(112, 47);
            this.RbdSexo.TabIndex = 1;
            this.RbdSexo.TabStop = false;
            this.RbdSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiobtnMasculino
            // 
            this.radiobtnMasculino.AutoSize = true;
            this.radiobtnMasculino.Location = new System.Drawing.Point(61, 10);
            this.radiobtnMasculino.Name = "radiobtnMasculino";
            this.radiobtnMasculino.Size = new System.Drawing.Size(47, 28);
            this.radiobtnMasculino.TabIndex = 3;
            this.radiobtnMasculino.TabStop = true;
            this.radiobtnMasculino.Text = "M";
            this.radiobtnMasculino.UseVisualStyleBackColor = true;
            this.radiobtnMasculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radiobtnFemenino
            // 
            this.radiobtnFemenino.AutoSize = true;
            this.radiobtnFemenino.Location = new System.Drawing.Point(12, 10);
            this.radiobtnFemenino.Name = "radiobtnFemenino";
            this.radiobtnFemenino.Size = new System.Drawing.Size(43, 28);
            this.radiobtnFemenino.TabIndex = 2;
            this.radiobtnFemenino.TabStop = true;
            this.radiobtnFemenino.Text = "F";
            this.radiobtnFemenino.UseVisualStyleBackColor = true;
            this.radiobtnFemenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CbxEdoCivil
            // 
            this.CbxEdoCivil.BackColor = System.Drawing.Color.Azure;
            this.CbxEdoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEdoCivil.FormattingEnabled = true;
            this.CbxEdoCivil.Location = new System.Drawing.Point(293, 619);
            this.CbxEdoCivil.Name = "CbxEdoCivil";
            this.CbxEdoCivil.Size = new System.Drawing.Size(272, 33);
            this.CbxEdoCivil.TabIndex = 2;
            this.CbxEdoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.BackColor = System.Drawing.Color.Azure;
            this.TxtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreC.Location = new System.Drawing.Point(293, 216);
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.Size = new System.Drawing.Size(404, 30);
            this.TxtNombreC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado Civil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Completo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnnGuardar
            // 
            this.btnnGuardar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnGuardar.Location = new System.Drawing.Point(572, 760);
            this.btnnGuardar.Name = "btnnGuardar";
            this.btnnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnnGuardar.TabIndex = 7;
            this.btnnGuardar.Text = "Guardar";
            this.btnnGuardar.UseVisualStyleBackColor = false;
            this.btnnGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(136, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "ALTA PACIENTE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Azure;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(293, 271);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(404, 30);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.BackColor = System.Drawing.Color.Azure;
            this.txtTelFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelFijo.Location = new System.Drawing.Point(293, 329);
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(272, 30);
            this.txtTelFijo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Télefono Fijo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.Azure;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(293, 386);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(272, 30);
            this.txtCelular.TabIndex = 15;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.Azure;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(293, 441);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(73, 30);
            this.txtEdad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Edad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Azure;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(293, 566);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 30);
            this.txtEmail.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 684);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Lista de Médicos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbxMedicos
            // 
            this.cbxMedicos.BackColor = System.Drawing.Color.Azure;
            this.cbxMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedicos.FormattingEnabled = true;
            this.cbxMedicos.Location = new System.Drawing.Point(293, 680);
            this.cbxMedicos.Name = "cbxMedicos";
            this.cbxMedicos.Size = new System.Drawing.Size(272, 33);
            this.cbxMedicos.TabIndex = 23;
            this.cbxMedicos.SelectedIndexChanged += new System.EventHandler(this.cbxMedicos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2A1IDEASMR.Properties.Resources._1513479;
            this.pictureBox1.Location = new System.Drawing.Point(465, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 831);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxMedicos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelFijo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreC);
            this.Controls.Add(this.CbxEdoCivil);
            this.Controls.Add(this.RbdSexo);
            this.Name = "FormularioPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Paciente";
            this.RbdSexo.ResumeLayout(false);
            this.RbdSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RbdSexo;
        private System.Windows.Forms.RadioButton radiobtnFemenino;
        private System.Windows.Forms.RadioButton radiobtnMasculino;
        private System.Windows.Forms.ComboBox CbxEdoCivil;
        private System.Windows.Forms.TextBox TxtNombreC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelFijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxMedicos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

