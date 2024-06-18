namespace InscripcionCol.Vista
{
    partial class dtp
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar_ci = new System.Windows.Forms.Button();
            this.txtBuscarCi = new System.Windows.Forms.TextBox();
            this.btnAgregarBeca = new System.Windows.Forms.Button();
            this.gbxDatosBeca = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_appaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBeca = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.ComboBox();
            this.gbxDatosBeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeca)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "REGISTRO DE BECAS";
            // 
            // btnBuscar_ci
            // 
            this.btnBuscar_ci.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar_ci.Location = new System.Drawing.Point(259, 24);
            this.btnBuscar_ci.Name = "btnBuscar_ci";
            this.btnBuscar_ci.Size = new System.Drawing.Size(104, 43);
            this.btnBuscar_ci.TabIndex = 8;
            this.btnBuscar_ci.Text = "BUSCAR";
            this.btnBuscar_ci.UseVisualStyleBackColor = true;
            this.btnBuscar_ci.Click += new System.EventHandler(this.btnBuscar_ci_Click);
            // 
            // txtBuscarCi
            // 
            this.txtBuscarCi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCi.Location = new System.Drawing.Point(141, 36);
            this.txtBuscarCi.Name = "txtBuscarCi";
            this.txtBuscarCi.Size = new System.Drawing.Size(98, 26);
            this.txtBuscarCi.TabIndex = 7;
            // 
            // btnAgregarBeca
            // 
            this.btnAgregarBeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.btnAgregarBeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBeca.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarBeca.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarBeca.Name = "btnAgregarBeca";
            this.btnAgregarBeca.Size = new System.Drawing.Size(288, 43);
            this.btnAgregarBeca.TabIndex = 6;
            this.btnAgregarBeca.Text = "REGISTRAR BECA";
            this.btnAgregarBeca.UseVisualStyleBackColor = false;
            this.btnAgregarBeca.Click += new System.EventHandler(this.btnAgregarBeca_Click);
            // 
            // gbxDatosBeca
            // 
            this.gbxDatosBeca.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDatosBeca.Controls.Add(this.label11);
            this.gbxDatosBeca.Controls.Add(this.date_fin);
            this.gbxDatosBeca.Controls.Add(this.date_inicio);
            this.gbxDatosBeca.Controls.Add(this.label10);
            this.gbxDatosBeca.Controls.Add(this.cbx_tipo);
            this.gbxDatosBeca.Controls.Add(this.label7);
            this.gbxDatosBeca.Controls.Add(this.btnCancelar);
            this.gbxDatosBeca.Controls.Add(this.btnGuardar);
            this.gbxDatosBeca.Controls.Add(this.label6);
            this.gbxDatosBeca.Controls.Add(this.txt_monto);
            this.gbxDatosBeca.Controls.Add(this.label5);
            this.gbxDatosBeca.Controls.Add(this.txt_nombre);
            this.gbxDatosBeca.Controls.Add(this.txt_apmaterno);
            this.gbxDatosBeca.Controls.Add(this.label4);
            this.gbxDatosBeca.Controls.Add(this.label3);
            this.gbxDatosBeca.Controls.Add(this.label2);
            this.gbxDatosBeca.Controls.Add(this.txt_appaterno);
            this.gbxDatosBeca.Controls.Add(this.label1);
            this.gbxDatosBeca.Controls.Add(this.txtBuscarCi);
            this.gbxDatosBeca.Controls.Add(this.btnBuscar_ci);
            this.gbxDatosBeca.Enabled = false;
            this.gbxDatosBeca.Location = new System.Drawing.Point(12, 65);
            this.gbxDatosBeca.Name = "gbxDatosBeca";
            this.gbxDatosBeca.Size = new System.Drawing.Size(378, 440);
            this.gbxDatosBeca.TabIndex = 10;
            this.gbxDatosBeca.TabStop = false;
            this.gbxDatosBeca.Text = "Datos de la Beca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha de finalizacion:";
            // 
            // date_fin
            // 
            this.date_fin.Location = new System.Drawing.Point(77, 336);
            this.date_fin.MaxDate = new System.DateTime(2034, 12, 31, 0, 0, 0, 0);
            this.date_fin.MinDate = new System.DateTime(2024, 6, 2, 0, 0, 0, 0);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(286, 26);
            this.date_fin.TabIndex = 26;
            this.date_fin.Value = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            // 
            // date_inicio
            // 
            this.date_inicio.Location = new System.Drawing.Point(77, 275);
            this.date_inicio.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.date_inicio.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(286, 26);
            this.date_inicio.TabIndex = 25;
            this.date_inicio.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha de inicio:";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Location = new System.Drawing.Point(141, 176);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(206, 26);
            this.cbx_tipo.TabIndex = 23;
            this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tipo de beca:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(222, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 43);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(35, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 43);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bs.";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(141, 212);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(72, 26);
            this.txt_monto.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Monto:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(141, 140);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(222, 26);
            this.txt_nombre.TabIndex = 16;
            // 
            // txt_apmaterno
            // 
            this.txt_apmaterno.Location = new System.Drawing.Point(141, 106);
            this.txt_apmaterno.Name = "txt_apmaterno";
            this.txt_apmaterno.Size = new System.Drawing.Size(222, 26);
            this.txt_apmaterno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido Paterno:";
            // 
            // txt_appaterno
            // 
            this.txt_appaterno.Location = new System.Drawing.Point(141, 73);
            this.txt_appaterno.Name = "txt_appaterno";
            this.txt_appaterno.Size = new System.Drawing.Size(222, 26);
            this.txt_appaterno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ci:";
            // 
            // dgvBeca
            // 
            this.dgvBeca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeca.Location = new System.Drawing.Point(406, 91);
            this.dgvBeca.Name = "dgvBeca";
            this.dgvBeca.Size = new System.Drawing.Size(782, 520);
            this.dgvBeca.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(744, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Buscar por: Tipo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1084, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 43);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.FormattingEnabled = true;
            this.txt_buscar.Items.AddRange(new object[] {
            "Académica",
            "Deportiva",
            "Cultural",
            "Socioeconomica",
            "Inclusión"});
            this.txt_buscar.Location = new System.Drawing.Point(872, 51);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(206, 26);
            this.txt_buscar.TabIndex = 24;
            // 
            // dtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.ControlBox = false;
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvBeca);
            this.Controls.Add(this.gbxDatosBeca);
            this.Controls.Add(this.btnAgregarBeca);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dtp";
            this.Text = "Registrar beca";
            this.Load += new System.EventHandler(this.frmbeca_Load);
            this.gbxDatosBeca.ResumeLayout(false);
            this.gbxDatosBeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar_ci;
        private System.Windows.Forms.TextBox txtBuscarCi;
        private System.Windows.Forms.Button btnAgregarBeca;
        private System.Windows.Forms.GroupBox gbxDatosBeca;
        private System.Windows.Forms.DataGridView dgvBeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_appaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.ComboBox txt_buscar;
    }
}