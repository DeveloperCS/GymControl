namespace Control_Gimmnacio
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.btnAgregaSocio = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.groupPersonales = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtAñoFecha = new System.Windows.Forms.TextBox();
            this.cbMesFecha = new System.Windows.Forms.ComboBox();
            this.cbNumeroFecha = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupMembresia = new System.Windows.Forms.GroupBox();
            this.txtClaveM = new System.Windows.Forms.TextBox();
            this.btnCancelarMem = new System.Windows.Forms.Button();
            this.btnPagaMem = new System.Windows.Forms.Button();
            this.checkDesc = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pickIni = new System.Windows.Forms.DateTimePicker();
            this.pickFin = new System.Windows.Forms.DateTimePicker();
            this.cbDescProm = new System.Windows.Forms.ComboBox();
            this.lbTotal1 = new System.Windows.Forms.Label();
            this.cbTipoMembrecia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelaSocio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregaSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPersonales.SuspendLayout();
            this.groupMembresia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregaSocio
            // 
            this.btnAgregaSocio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregaSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaSocio.FlatAppearance.BorderSize = 2;
            this.btnAgregaSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnAgregaSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAgregaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaSocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaSocio.Location = new System.Drawing.Point(382, 243);
            this.btnAgregaSocio.Name = "btnAgregaSocio";
            this.btnAgregaSocio.Size = new System.Drawing.Size(129, 51);
            this.btnAgregaSocio.TabIndex = 2;
            this.btnAgregaSocio.Text = "Agregar Socio";
            this.btnAgregaSocio.UseVisualStyleBackColor = true;
            this.btnAgregaSocio.Click += new System.EventHandler(this.btnAgregaSocio_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(352, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(284, 27);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Completo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(273, 157);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(363, 27);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(684, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tel: ";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(735, 72);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(259, 27);
            this.txtTel.TabIndex = 7;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(221, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Naciemiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(814, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Facebook";
            // 
            // txtFB
            // 
            this.txtFB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFB.Location = new System.Drawing.Point(737, 157);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(258, 27);
            this.txtFB.TabIndex = 8;
            // 
            // groupPersonales
            // 
            this.groupPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPersonales.BackColor = System.Drawing.SystemColors.Control;
            this.groupPersonales.Controls.Add(this.pictureBox3);
            this.groupPersonales.Controls.Add(this.cbSexo);
            this.groupPersonales.Controls.Add(this.txtAñoFecha);
            this.groupPersonales.Controls.Add(this.cbMesFecha);
            this.groupPersonales.Controls.Add(this.cbNumeroFecha);
            this.groupPersonales.Controls.Add(this.pictureBox1);
            this.groupPersonales.Controls.Add(this.txtFB);
            this.groupPersonales.Controls.Add(this.label2);
            this.groupPersonales.Controls.Add(this.txtNom);
            this.groupPersonales.Controls.Add(this.txtTel);
            this.groupPersonales.Controls.Add(this.txtDireccion);
            this.groupPersonales.Controls.Add(this.label6);
            this.groupPersonales.Controls.Add(this.label12);
            this.groupPersonales.Controls.Add(this.label4);
            this.groupPersonales.Controls.Add(this.label5);
            this.groupPersonales.Controls.Add(this.label7);
            this.groupPersonales.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersonales.ForeColor = System.Drawing.Color.Orange;
            this.groupPersonales.Location = new System.Drawing.Point(12, 33);
            this.groupPersonales.Name = "groupPersonales";
            this.groupPersonales.Size = new System.Drawing.Size(1012, 204);
            this.groupPersonales.TabIndex = 0;
            this.groupPersonales.TabStop = false;
            this.groupPersonales.Text = "Datos de Socio";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(572, 102);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(64, 29);
            this.cbSexo.TabIndex = 5;
            // 
            // txtAñoFecha
            // 
            this.txtAñoFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoFecha.Location = new System.Drawing.Point(364, 107);
            this.txtAñoFecha.MaxLength = 4;
            this.txtAñoFecha.Name = "txtAñoFecha";
            this.txtAñoFecha.Size = new System.Drawing.Size(100, 27);
            this.txtAñoFecha.TabIndex = 4;
            this.txtAñoFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñoFecha_KeyPress);
            // 
            // cbMesFecha
            // 
            this.cbMesFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesFecha.FormattingEnabled = true;
            this.cbMesFecha.Location = new System.Drawing.Point(282, 106);
            this.cbMesFecha.Name = "cbMesFecha";
            this.cbMesFecha.Size = new System.Drawing.Size(76, 29);
            this.cbMesFecha.TabIndex = 3;
            // 
            // cbNumeroFecha
            // 
            this.cbNumeroFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumeroFecha.FormattingEnabled = true;
            this.cbNumeroFecha.Location = new System.Drawing.Point(212, 105);
            this.cbNumeroFecha.Name = "cbNumeroFecha";
            this.cbNumeroFecha.Size = new System.Drawing.Size(63, 29);
            this.cbNumeroFecha.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(581, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sexo";
            // 
            // groupMembresia
            // 
            this.groupMembresia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMembresia.Controls.Add(this.txtClaveM);
            this.groupMembresia.Controls.Add(this.btnCancelarMem);
            this.groupMembresia.Controls.Add(this.btnPagaMem);
            this.groupMembresia.Controls.Add(this.checkDesc);
            this.groupMembresia.Controls.Add(this.label13);
            this.groupMembresia.Controls.Add(this.label8);
            this.groupMembresia.Controls.Add(this.pickIni);
            this.groupMembresia.Controls.Add(this.pickFin);
            this.groupMembresia.Controls.Add(this.cbDescProm);
            this.groupMembresia.Controls.Add(this.pictureBox2);
            this.groupMembresia.Controls.Add(this.lbTotal1);
            this.groupMembresia.Controls.Add(this.cbTipoMembrecia);
            this.groupMembresia.Controls.Add(this.label10);
            this.groupMembresia.Controls.Add(this.lbDesc);
            this.groupMembresia.Controls.Add(this.label3);
            this.groupMembresia.Controls.Add(this.label1);
            this.groupMembresia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMembresia.ForeColor = System.Drawing.Color.Orange;
            this.groupMembresia.Location = new System.Drawing.Point(12, 304);
            this.groupMembresia.Name = "groupMembresia";
            this.groupMembresia.Size = new System.Drawing.Size(1012, 284);
            this.groupMembresia.TabIndex = 4;
            this.groupMembresia.TabStop = false;
            this.groupMembresia.Text = "Datos de Membresia";
            // 
            // txtClaveM
            // 
            this.txtClaveM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveM.Location = new System.Drawing.Point(80, 43);
            this.txtClaveM.Name = "txtClaveM";
            this.txtClaveM.Size = new System.Drawing.Size(135, 26);
            this.txtClaveM.TabIndex = 12;
            // 
            // btnCancelarMem
            // 
            this.btnCancelarMem.FlatAppearance.BorderSize = 2;
            this.btnCancelarMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnCancelarMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCancelarMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarMem.Location = new System.Drawing.Point(701, 205);
            this.btnCancelarMem.Name = "btnCancelarMem";
            this.btnCancelarMem.Size = new System.Drawing.Size(100, 42);
            this.btnCancelarMem.TabIndex = 11;
            this.btnCancelarMem.Text = "Cancelar";
            this.btnCancelarMem.UseVisualStyleBackColor = true;
            this.btnCancelarMem.Click += new System.EventHandler(this.btnCancelarMem_Click);
            // 
            // btnPagaMem
            // 
            this.btnPagaMem.FlatAppearance.BorderSize = 2;
            this.btnPagaMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnPagaMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPagaMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagaMem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagaMem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPagaMem.Location = new System.Drawing.Point(817, 205);
            this.btnPagaMem.Name = "btnPagaMem";
            this.btnPagaMem.Size = new System.Drawing.Size(100, 42);
            this.btnPagaMem.TabIndex = 10;
            this.btnPagaMem.Text = "Pagar";
            this.btnPagaMem.UseVisualStyleBackColor = true;
            this.btnPagaMem.Click += new System.EventHandler(this.btnPagaMem_Click);
            // 
            // checkDesc
            // 
            this.checkDesc.AutoSize = true;
            this.checkDesc.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDesc.ForeColor = System.Drawing.Color.Black;
            this.checkDesc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkDesc.Location = new System.Drawing.Point(23, 135);
            this.checkDesc.Name = "checkDesc";
            this.checkDesc.Size = new System.Drawing.Size(243, 36);
            this.checkDesc.TabIndex = 9;
            this.checkDesc.Text = "Agregar Descuento/Promocion";
            this.checkDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkDesc.UseVisualStyleBackColor = true;
            this.checkDesc.CheckedChanged += new System.EventHandler(this.checkDesc_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(294, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(294, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fin:";
            // 
            // pickIni
            // 
            this.pickIni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickIni.Location = new System.Drawing.Point(351, 92);
            this.pickIni.Name = "pickIni";
            this.pickIni.Size = new System.Drawing.Size(259, 23);
            this.pickIni.TabIndex = 6;
            this.pickIni.Value = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            // 
            // pickFin
            // 
            this.pickFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickFin.Location = new System.Drawing.Point(351, 137);
            this.pickFin.Name = "pickFin";
            this.pickFin.Size = new System.Drawing.Size(259, 23);
            this.pickFin.TabIndex = 6;
            this.pickFin.Value = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            // 
            // cbDescProm
            // 
            this.cbDescProm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescProm.FormattingEnabled = true;
            this.cbDescProm.Items.AddRange(new object[] {
            "Descuento 25%",
            "Descuento 50%",
            "Promocion por cumpleaños"});
            this.cbDescProm.Location = new System.Drawing.Point(279, 202);
            this.cbDescProm.Name = "cbDescProm";
            this.cbDescProm.Size = new System.Drawing.Size(229, 25);
            this.cbDescProm.TabIndex = 5;
            this.cbDescProm.SelectedIndexChanged += new System.EventHandler(this.cbDescProm_SelectedIndexChanged);
            // 
            // lbTotal1
            // 
            this.lbTotal1.AutoSize = true;
            this.lbTotal1.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotal1.Location = new System.Drawing.Point(796, 119);
            this.lbTotal1.Name = "lbTotal1";
            this.lbTotal1.Size = new System.Drawing.Size(54, 25);
            this.lbTotal1.TabIndex = 3;
            this.lbTotal1.Text = "0.00";
            // 
            // cbTipoMembrecia
            // 
            this.cbTipoMembrecia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMembrecia.FormattingEnabled = true;
            this.cbTipoMembrecia.Items.AddRange(new object[] {
            "Semanal",
            "Mensual"});
            this.cbTipoMembrecia.Location = new System.Drawing.Point(65, 90);
            this.cbTipoMembrecia.Name = "cbTipoMembrecia";
            this.cbTipoMembrecia.Size = new System.Drawing.Size(150, 25);
            this.cbTipoMembrecia.TabIndex = 1;
            this.cbTipoMembrecia.SelectedIndexChanged += new System.EventHandler(this.cbTipoMembrecia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(745, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total a Pagar:";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.Color.Black;
            this.lbDesc.Location = new System.Drawing.Point(89, 203);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(185, 19);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Descuento/Promocion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // btnCancelaSocio
            // 
            this.btnCancelaSocio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelaSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaSocio.FlatAppearance.BorderSize = 2;
            this.btnCancelaSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnCancelaSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCancelaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaSocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaSocio.Location = new System.Drawing.Point(532, 243);
            this.btnCancelaSocio.Name = "btnCancelaSocio";
            this.btnCancelaSocio.Size = new System.Drawing.Size(129, 51);
            this.btnCancelaSocio.TabIndex = 5;
            this.btnCancelaSocio.Text = "Cancelar";
            this.btnCancelaSocio.UseVisualStyleBackColor = true;
            this.btnCancelaSocio.Click += new System.EventHandler(this.btnCancelaSocio_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaSociosToolStripMenuItem,
            this.historialDeSociosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregaSociosToolStripMenuItem
            // 
            this.agregaSociosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.agregaSociosToolStripMenuItem.Name = "agregaSociosToolStripMenuItem";
            this.agregaSociosToolStripMenuItem.Size = new System.Drawing.Size(134, 21);
            this.agregaSociosToolStripMenuItem.Text = "Historial de socios";
            this.agregaSociosToolStripMenuItem.Click += new System.EventHandler(this.agregaSociosToolStripMenuItem_Click);
            // 
            // historialDeSociosToolStripMenuItem
            // 
            this.historialDeSociosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.historialDeSociosToolStripMenuItem.Name = "historialDeSociosToolStripMenuItem";
            this.historialDeSociosToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(650, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(767, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnCancelaSocio);
            this.Controls.Add(this.groupMembresia);
            this.Controls.Add(this.groupPersonales);
            this.Controls.Add(this.btnAgregaSocio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro";
            this.Load += new System.EventHandler(this.registro_Load);
            this.groupPersonales.ResumeLayout(false);
            this.groupPersonales.PerformLayout();
            this.groupMembresia.ResumeLayout(false);
            this.groupMembresia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregaSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.GroupBox groupPersonales;
        private System.Windows.Forms.ComboBox cbMesFecha;
        private System.Windows.Forms.ComboBox cbNumeroFecha;
        private System.Windows.Forms.GroupBox groupMembresia;
        private System.Windows.Forms.Label lbTotal1;
        private System.Windows.Forms.ComboBox cbTipoMembrecia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbDescProm;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickIni;
        private System.Windows.Forms.DateTimePicker pickFin;
        private System.Windows.Forms.Button btnCancelaSocio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregaSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeSociosToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkDesc;
        private System.Windows.Forms.Button btnCancelarMem;
        private System.Windows.Forms.Button btnPagaMem;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtAñoFecha;
        private System.Windows.Forms.TextBox txtClaveM;
        private System.Windows.Forms.Label label3;
    }
}