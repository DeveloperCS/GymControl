namespace Control_Gimmnacio
{
    partial class us
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreUs = new System.Windows.Forms.TextBox();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.txtPassUs = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.groupBoxUS = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregaUs = new System.Windows.Forms.Button();
            this.cbTipoUs = new System.Windows.Forms.ComboBox();
            this.btnEditarUs = new System.Windows.Forms.Button();
            this.btnEliminaUs = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxUS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuarios Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(523, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 390);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contraseña:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirmar contraseña:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de Usuario:";
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUs.Location = new System.Drawing.Point(176, 51);
            this.txtNombreUs.Name = "txtNombreUs";
            this.txtNombreUs.Size = new System.Drawing.Size(239, 27);
            this.txtNombreUs.TabIndex = 2;
            // 
            // txtUs
            // 
            this.txtUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUs.Location = new System.Drawing.Point(176, 95);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(239, 27);
            this.txtUs.TabIndex = 3;
            // 
            // txtPassUs
            // 
            this.txtPassUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassUs.Location = new System.Drawing.Point(176, 140);
            this.txtPassUs.Name = "txtPassUs";
            this.txtPassUs.PasswordChar = '*';
            this.txtPassUs.Size = new System.Drawing.Size(151, 27);
            this.txtPassUs.TabIndex = 4;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(264, 189);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(151, 27);
            this.txtConfirmPass.TabIndex = 5;
            // 
            // groupBoxUS
            // 
            this.groupBoxUS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxUS.Controls.Add(this.txtID);
            this.groupBoxUS.Controls.Add(this.btnGuardar);
            this.groupBoxUS.Controls.Add(this.btnCancelar);
            this.groupBoxUS.Controls.Add(this.btnAgregaUs);
            this.groupBoxUS.Controls.Add(this.cbTipoUs);
            this.groupBoxUS.Controls.Add(this.label3);
            this.groupBoxUS.Controls.Add(this.txtConfirmPass);
            this.groupBoxUS.Controls.Add(this.label4);
            this.groupBoxUS.Controls.Add(this.txtPassUs);
            this.groupBoxUS.Controls.Add(this.label5);
            this.groupBoxUS.Controls.Add(this.txtUs);
            this.groupBoxUS.Controls.Add(this.label6);
            this.groupBoxUS.Controls.Add(this.txtNombreUs);
            this.groupBoxUS.Controls.Add(this.label7);
            this.groupBoxUS.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUS.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxUS.Location = new System.Drawing.Point(21, 38);
            this.groupBoxUS.Name = "groupBoxUS";
            this.groupBoxUS.Size = new System.Drawing.Size(444, 524);
            this.groupBoxUS.TabIndex = 6;
            this.groupBoxUS.TabStop = false;
            this.groupBoxUS.Text = "Nuevo Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(146, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 41);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(231, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregaUs
            // 
            this.btnAgregaUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaUs.Location = new System.Drawing.Point(66, 342);
            this.btnAgregaUs.Name = "btnAgregaUs";
            this.btnAgregaUs.Size = new System.Drawing.Size(146, 41);
            this.btnAgregaUs.TabIndex = 7;
            this.btnAgregaUs.Text = "Agregar";
            this.btnAgregaUs.UseVisualStyleBackColor = true;
            this.btnAgregaUs.Click += new System.EventHandler(this.btnAgregaUs_Click);
            // 
            // cbTipoUs
            // 
            this.cbTipoUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUs.FormattingEnabled = true;
            this.cbTipoUs.Location = new System.Drawing.Point(209, 236);
            this.cbTipoUs.Name = "cbTipoUs";
            this.cbTipoUs.Size = new System.Drawing.Size(206, 29);
            this.cbTipoUs.TabIndex = 6;
            // 
            // btnEditarUs
            // 
            this.btnEditarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUs.Location = new System.Drawing.Point(638, 520);
            this.btnEditarUs.Name = "btnEditarUs";
            this.btnEditarUs.Size = new System.Drawing.Size(107, 43);
            this.btnEditarUs.TabIndex = 7;
            this.btnEditarUs.Text = "Editar";
            this.btnEditarUs.UseVisualStyleBackColor = true;
            this.btnEditarUs.Click += new System.EventHandler(this.btnEditarUs_Click);
            // 
            // btnEliminaUs
            // 
            this.btnEliminaUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaUs.Location = new System.Drawing.Point(768, 519);
            this.btnEliminaUs.Name = "btnEliminaUs";
            this.btnEliminaUs.Size = new System.Drawing.Size(107, 43);
            this.btnEliminaUs.TabIndex = 8;
            this.btnEliminaUs.Text = "Eliminar";
            this.btnEliminaUs.UseVisualStyleBackColor = true;
            this.btnEliminaUs.Click += new System.EventHandler(this.btnEliminaUs_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(800, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(362, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 23);
            this.txtID.TabIndex = 10;
            // 
            // us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnEliminaUs);
            this.Controls.Add(this.btnEditarUs);
            this.Controls.Add(this.groupBoxUS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "us";
            this.Load += new System.EventHandler(this.us_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxUS.ResumeLayout(false);
            this.groupBoxUS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreUs;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.TextBox txtPassUs;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.GroupBox groupBoxUS;
        private System.Windows.Forms.ComboBox cbTipoUs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregaUs;
        private System.Windows.Forms.Button btnEditarUs;
        private System.Windows.Forms.Button btnEliminaUs;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtID;
    }
}