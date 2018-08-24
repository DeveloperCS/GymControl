namespace Control_Gimmnacio
{
    partial class vHistorialUs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vHistorialUs));
            this.label1 = new System.Windows.Forms.Label();
            this.dGWHistorial = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.PictureBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnEliminaMemS = new System.Windows.Forms.PictureBox();
            this.btnAgregaMemS = new System.Windows.Forms.PictureBox();
            this.btnLimpiarS = new System.Windows.Forms.Button();
            this.btnGuardarS = new System.Windows.Forms.Button();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtNomS = new System.Windows.Forms.TextBox();
            this.txtClaveS = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGWSocios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionarS = new System.Windows.Forms.Button();
            this.btnEliminarS = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGWHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminaMemS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaMemS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(318, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Vida";
            // 
            // dGWHistorial
            // 
            this.dGWHistorial.AllowUserToAddRows = false;
            this.dGWHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWHistorial.Location = new System.Drawing.Point(30, 336);
            this.dGWHistorial.Name = "dGWHistorial";
            this.dGWHistorial.Size = new System.Drawing.Size(722, 210);
            this.dGWHistorial.TabIndex = 1;
            this.dGWHistorial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGWHistorial_CellFormatting);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.dtNacimiento);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.txtS);
            this.panel1.Controls.Add(this.btnEliminaMemS);
            this.panel1.Controls.Add(this.btnAgregaMemS);
            this.panel1.Controls.Add(this.btnLimpiarS);
            this.panel1.Controls.Add(this.btnGuardarS);
            this.panel1.Controls.Add(this.txtFB);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txtdir);
            this.panel1.Controls.Add(this.txtNomS);
            this.panel1.Controls.Add(this.txtClaveS);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dGWHistorial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(475, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 570);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = global::Control_Gimmnacio.Properties.Resources.icons8_sincronizar_64;
            this.btnActualizar.Location = new System.Drawing.Point(661, 305);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(25, 25);
            this.btnActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.Location = new System.Drawing.Point(347, 126);
            this.txtS.MaxLength = 1;
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(52, 27);
            this.txtS.TabIndex = 10;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            this.txtS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtS_KeyDown);
            this.txtS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtS_KeyPress);
            // 
            // btnEliminaMemS
            // 
            this.btnEliminaMemS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaMemS.Image = global::Control_Gimmnacio.Properties.Resources.if_error_1646012;
            this.btnEliminaMemS.Location = new System.Drawing.Point(727, 305);
            this.btnEliminaMemS.Name = "btnEliminaMemS";
            this.btnEliminaMemS.Size = new System.Drawing.Size(25, 25);
            this.btnEliminaMemS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminaMemS.TabIndex = 9;
            this.btnEliminaMemS.TabStop = false;
            this.btnEliminaMemS.Click += new System.EventHandler(this.btnEliminaMemS_Click);
            // 
            // btnAgregaMemS
            // 
            this.btnAgregaMemS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaMemS.Image = global::Control_Gimmnacio.Properties.Resources.if_plus_1646001;
            this.btnAgregaMemS.Location = new System.Drawing.Point(696, 305);
            this.btnAgregaMemS.Name = "btnAgregaMemS";
            this.btnAgregaMemS.Size = new System.Drawing.Size(25, 25);
            this.btnAgregaMemS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregaMemS.TabIndex = 8;
            this.btnAgregaMemS.TabStop = false;
            this.btnAgregaMemS.Click += new System.EventHandler(this.btnAgregaMemS_Click);
            // 
            // btnLimpiarS
            // 
            this.btnLimpiarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarS.Location = new System.Drawing.Point(136, 243);
            this.btnLimpiarS.Name = "btnLimpiarS";
            this.btnLimpiarS.Size = new System.Drawing.Size(89, 38);
            this.btnLimpiarS.TabIndex = 7;
            this.btnLimpiarS.Text = "Limpiar";
            this.btnLimpiarS.UseVisualStyleBackColor = true;
            this.btnLimpiarS.Click += new System.EventHandler(this.btnLimpiarS_Click);
            // 
            // btnGuardarS
            // 
            this.btnGuardarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarS.Location = new System.Drawing.Point(30, 242);
            this.btnGuardarS.Name = "btnGuardarS";
            this.btnGuardarS.Size = new System.Drawing.Size(89, 38);
            this.btnGuardarS.TabIndex = 7;
            this.btnGuardarS.Text = "Guardar";
            this.btnGuardarS.UseVisualStyleBackColor = true;
            this.btnGuardarS.Click += new System.EventHandler(this.btnGuardarS_Click);
            // 
            // txtFB
            // 
            this.txtFB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFB.Location = new System.Drawing.Point(517, 180);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(250, 27);
            this.txtFB.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(516, 106);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 27);
            this.txtTel.TabIndex = 3;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtdir
            // 
            this.txtdir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdir.Location = new System.Drawing.Point(109, 182);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(364, 27);
            this.txtdir.TabIndex = 3;
            // 
            // txtNomS
            // 
            this.txtNomS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomS.Location = new System.Drawing.Point(189, 63);
            this.txtNomS.Name = "txtNomS";
            this.txtNomS.Size = new System.Drawing.Size(284, 27);
            this.txtNomS.TabIndex = 3;
            this.txtNomS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomS_KeyPress);
            // 
            // txtClaveS
            // 
            this.txtClaveS.Location = new System.Drawing.Point(83, 21);
            this.txtClaveS.Name = "txtClaveS";
            this.txtClaveS.Size = new System.Drawing.Size(103, 20);
            this.txtClaveS.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Control_Gimmnacio.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(747, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(482, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(598, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Facebook";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(351, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(24, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(59, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(24, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre  Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clave:";
            // 
            // dGWSocios
            // 
            this.dGWSocios.AllowUserToAddRows = false;
            this.dGWSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWSocios.Location = new System.Drawing.Point(12, 112);
            this.dGWSocios.Name = "dGWSocios";
            this.dGWSocios.Size = new System.Drawing.Size(457, 335);
            this.dGWSocios.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Socios";
            // 
            // btnSelecionarS
            // 
            this.btnSelecionarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarS.Location = new System.Drawing.Point(73, 465);
            this.btnSelecionarS.Name = "btnSelecionarS";
            this.btnSelecionarS.Size = new System.Drawing.Size(129, 38);
            this.btnSelecionarS.TabIndex = 7;
            this.btnSelecionarS.Text = "Seleccionar";
            this.btnSelecionarS.UseVisualStyleBackColor = true;
            this.btnSelecionarS.Click += new System.EventHandler(this.btnSelecionarS_Click);
            // 
            // btnEliminarS
            // 
            this.btnEliminarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarS.Location = new System.Drawing.Point(242, 465);
            this.btnEliminarS.Name = "btnEliminarS";
            this.btnEliminarS.Size = new System.Drawing.Size(129, 38);
            this.btnEliminarS.TabIndex = 7;
            this.btnEliminarS.Text = "Eliminar";
            this.btnEliminarS.UseVisualStyleBackColor = true;
            this.btnEliminarS.Click += new System.EventHandler(this.btnEliminarS_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Buscar";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacimiento.Location = new System.Drawing.Point(30, 130);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(263, 23);
            this.dtNacimiento.TabIndex = 13;
            // 
            // vHistorialUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 561);
            this.Controls.Add(this.btnEliminarS);
            this.Controls.Add(this.btnSelecionarS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWSocios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vHistorialUs";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vHistorialUs";
            this.Load += new System.EventHandler(this.vHistorialUs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vHistorialUs_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGWHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminaMemS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregaMemS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWHistorial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dGWSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionarS;
        private System.Windows.Forms.TextBox txtClaveS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtNomS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiarS;
        private System.Windows.Forms.Button btnGuardarS;
        private System.Windows.Forms.Button btnEliminarS;
        private System.Windows.Forms.PictureBox btnAgregaMemS;
        private System.Windows.Forms.PictureBox btnEliminaMemS;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnActualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
    }
}