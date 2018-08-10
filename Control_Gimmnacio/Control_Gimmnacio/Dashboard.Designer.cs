namespace Control_Gimmnacio
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.p_esVisi = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.lbTHoy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalVis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_Mem = new System.Windows.Forms.Panel();
            this.lbTotalMem = new System.Windows.Forms.Label();
            this.lbMemEx = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMemVigentes = new System.Windows.Forms.Label();
            this.p_Mem_ti = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVenderProdc = new System.Windows.Forms.Button();
            this.btnNuevoVis = new System.Windows.Forms.Button();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.timChecar = new System.Windows.Forms.Timer(this.components);
            this.dtGWMemEx = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_esVisi.SuspendLayout();
            this.panel5.SuspendLayout();
            this.p_Mem.SuspendLayout();
            this.p_Mem_ti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGWMemEx)).BeginInit();
            this.SuspendLayout();
            // 
            // p_esVisi
            // 
            this.p_esVisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.p_esVisi.Controls.Add(this.panel5);
            this.p_esVisi.Controls.Add(this.lbTotalVis);
            this.p_esVisi.Controls.Add(this.label3);
            this.p_esVisi.Location = new System.Drawing.Point(29, 26);
            this.p_esVisi.Name = "p_esVisi";
            this.p_esVisi.Size = new System.Drawing.Size(483, 144);
            this.p_esVisi.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbMes);
            this.panel5.Controls.Add(this.lbTHoy);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(164, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 144);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(205, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mes";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbMes
            // 
            this.lbMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMes.Location = new System.Drawing.Point(220, 77);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(22, 24);
            this.lbMes.TabIndex = 0;
            this.lbMes.Text = "0";
            this.lbMes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTHoy
            // 
            this.lbTHoy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTHoy.AutoSize = true;
            this.lbTHoy.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHoy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTHoy.Location = new System.Drawing.Point(70, 77);
            this.lbTHoy.Name = "lbTHoy";
            this.lbTHoy.Size = new System.Drawing.Size(22, 24);
            this.lbTHoy.TabIndex = 0;
            this.lbTHoy.Text = "0";
            this.lbTHoy.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(56, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hoy";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTotalVis
            // 
            this.lbTotalVis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalVis.AutoSize = true;
            this.lbTotalVis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVis.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbTotalVis.Location = new System.Drawing.Point(42, 77);
            this.lbTotalVis.Name = "lbTotalVis";
            this.lbTotalVis.Size = new System.Drawing.Size(22, 24);
            this.lbTotalVis.TabIndex = 0;
            this.lbTotalVis.Text = "0";
            this.lbTotalVis.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visitantes ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // p_Mem
            // 
            this.p_Mem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Mem.BackColor = System.Drawing.Color.DarkOrange;
            this.p_Mem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_Mem.Controls.Add(this.lbTotalMem);
            this.p_Mem.Controls.Add(this.lbMemEx);
            this.p_Mem.Controls.Add(this.label12);
            this.p_Mem.Controls.Add(this.label13);
            this.p_Mem.Controls.Add(this.label11);
            this.p_Mem.Controls.Add(this.lbMemVigentes);
            this.p_Mem.Controls.Add(this.p_Mem_ti);
            this.p_Mem.Cursor = System.Windows.Forms.Cursors.Default;
            this.p_Mem.Location = new System.Drawing.Point(568, 26);
            this.p_Mem.Name = "p_Mem";
            this.p_Mem.Size = new System.Drawing.Size(427, 144);
            this.p_Mem.TabIndex = 0;
            this.p_Mem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_Mem_MouseClick);
            this.p_Mem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Mem_MouseDown);
            this.p_Mem.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.p_Mem.MouseLeave += new System.EventHandler(this.p_Mem_MouseLeave);
            this.p_Mem.MouseHover += new System.EventHandler(this.p_Mem_MouseHover);
            this.p_Mem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_Mem_MouseUp);
            // 
            // lbTotalMem
            // 
            this.lbTotalMem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTotalMem.AutoSize = true;
            this.lbTotalMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalMem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalMem.Location = new System.Drawing.Point(343, 90);
            this.lbTotalMem.Name = "lbTotalMem";
            this.lbTotalMem.Size = new System.Drawing.Size(22, 24);
            this.lbTotalMem.TabIndex = 0;
            this.lbTotalMem.Text = "0";
            this.lbTotalMem.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbMemEx
            // 
            this.lbMemEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemEx.AutoSize = true;
            this.lbMemEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMemEx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemEx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMemEx.Location = new System.Drawing.Point(197, 90);
            this.lbMemEx.Name = "lbMemEx";
            this.lbMemEx.Size = new System.Drawing.Size(22, 24);
            this.lbMemEx.TabIndex = 0;
            this.lbMemEx.Text = "0";
            this.lbMemEx.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(324, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(161, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Expiradas";
            this.label13.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(27, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Vijentes";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbMemVigentes
            // 
            this.lbMemVigentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemVigentes.AutoSize = true;
            this.lbMemVigentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMemVigentes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemVigentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMemVigentes.Location = new System.Drawing.Point(60, 90);
            this.lbMemVigentes.Name = "lbMemVigentes";
            this.lbMemVigentes.Size = new System.Drawing.Size(22, 24);
            this.lbMemVigentes.TabIndex = 0;
            this.lbMemVigentes.Text = "0";
            this.lbMemVigentes.Click += new System.EventHandler(this.label3_Click);
            // 
            // p_Mem_ti
            // 
            this.p_Mem_ti.BackColor = System.Drawing.Color.Black;
            this.p_Mem_ti.Controls.Add(this.label4);
            this.p_Mem_ti.Location = new System.Drawing.Point(0, 0);
            this.p_Mem_ti.Name = "p_Mem_ti";
            this.p_Mem_ti.Size = new System.Drawing.Size(427, 37);
            this.p_Mem_ti.TabIndex = 1;
            this.p_Mem_ti.MouseEnter += new System.EventHandler(this.p_Mem_ti_MouseEnter);
            this.p_Mem_ti.MouseLeave += new System.EventHandler(this.p_Mem_ti_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(158, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Membresias";
            // 
            // btnVenderProdc
            // 
            this.btnVenderProdc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVenderProdc.BackColor = System.Drawing.Color.Chartreuse;
            this.btnVenderProdc.Cursor = System.Windows.Forms.Cursors.No;
            this.btnVenderProdc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVenderProdc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnVenderProdc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVenderProdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderProdc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderProdc.ForeColor = System.Drawing.Color.White;
            this.btnVenderProdc.Image = ((System.Drawing.Image)(resources.GetObject("btnVenderProdc.Image")));
            this.btnVenderProdc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenderProdc.Location = new System.Drawing.Point(282, 188);
            this.btnVenderProdc.Name = "btnVenderProdc";
            this.btnVenderProdc.Padding = new System.Windows.Forms.Padding(0, 2, 0, 15);
            this.btnVenderProdc.Size = new System.Drawing.Size(230, 130);
            this.btnVenderProdc.TabIndex = 4;
            this.btnVenderProdc.Text = "Vender Producto";
            this.btnVenderProdc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenderProdc.UseVisualStyleBackColor = false;
            // 
            // btnNuevoVis
            // 
            this.btnNuevoVis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevoVis.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNuevoVis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoVis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoVis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNuevoVis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnNuevoVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVis.ForeColor = System.Drawing.Color.White;
            this.btnNuevoVis.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoVis.Image")));
            this.btnNuevoVis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoVis.Location = new System.Drawing.Point(29, 188);
            this.btnNuevoVis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNuevoVis.Name = "btnNuevoVis";
            this.btnNuevoVis.Padding = new System.Windows.Forms.Padding(0, 2, 0, 15);
            this.btnNuevoVis.Size = new System.Drawing.Size(225, 130);
            this.btnNuevoVis.TabIndex = 3;
            this.btnNuevoVis.Text = "Nuevo Visitante";
            this.btnNuevoVis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoVis.UseVisualStyleBackColor = false;
            this.btnNuevoVis.Click += new System.EventHandler(this.btnNuevoVis_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // timChecar
            // 
            this.timChecar.Enabled = true;
            this.timChecar.Tick += new System.EventHandler(this.timChecar_Tick);
            // 
            // dtGWMemEx
            // 
            this.dtGWMemEx.AllowUserToAddRows = false;
            this.dtGWMemEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGWMemEx.Location = new System.Drawing.Point(29, 355);
            this.dtGWMemEx.Name = "dtGWMemEx";
            this.dtGWMemEx.Size = new System.Drawing.Size(1001, 226);
            this.dtGWMemEx.TabIndex = 5;
            this.dtGWMemEx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGWMemEx_CellClick);
            this.dtGWMemEx.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGWMemEx_CellFormatting);
            this.dtGWMemEx.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtGWMemEx_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Expiradas";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGWMemEx);
            this.Controls.Add(this.btnVenderProdc);
            this.Controls.Add(this.btnNuevoVis);
            this.Controls.Add(this.p_Mem);
            this.Controls.Add(this.p_esVisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.p_esVisi.ResumeLayout(false);
            this.p_esVisi.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.p_Mem.ResumeLayout(false);
            this.p_Mem.PerformLayout();
            this.p_Mem_ti.ResumeLayout(false);
            this.p_Mem_ti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGWMemEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel p_esVisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p_Mem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTHoy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalVis;
        private System.Windows.Forms.Label lbTotalMem;
        private System.Windows.Forms.Label lbMemEx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbMemVigentes;
        private System.Windows.Forms.Panel p_Mem_ti;
        private System.Windows.Forms.Button btnNuevoVis;
        private System.Windows.Forms.Button btnVenderProdc;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Timer timChecar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.DataGridView dtGWMemEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}