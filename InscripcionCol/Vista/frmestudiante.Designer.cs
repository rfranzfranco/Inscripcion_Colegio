namespace InscripcionCol
{
    partial class frmestudiante
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
            this.btnestudiante = new System.Windows.Forms.Button();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarEst = new System.Windows.Forms.TextBox();
            this.btnBuscarEst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnestudiante
            // 
            this.btnestudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnestudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiante.ForeColor = System.Drawing.Color.LightGray;
            this.btnestudiante.Location = new System.Drawing.Point(15, 48);
            this.btnestudiante.Margin = new System.Windows.Forms.Padding(4);
            this.btnestudiante.Name = "btnestudiante";
            this.btnestudiante.Size = new System.Drawing.Size(324, 42);
            this.btnestudiante.TabIndex = 0;
            this.btnestudiante.Text = "AGREGAR ESTUDIANTE";
            this.btnestudiante.UseVisualStyleBackColor = false;
            this.btnestudiante.Click += new System.EventHandler(this.btnestudiante_Click);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(15, 108);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.Size = new System.Drawing.Size(1151, 509);
            this.dgvEstudiante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar estudiante por: codigo RUDE | Apellido Paterno | Materno | Nombre | Año de" +
    " escolaridad";
            // 
            // txtBuscarEst
            // 
            this.txtBuscarEst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEst.Location = new System.Drawing.Point(375, 66);
            this.txtBuscarEst.Name = "txtBuscarEst";
            this.txtBuscarEst.Size = new System.Drawing.Size(653, 26);
            this.txtBuscarEst.TabIndex = 3;
            // 
            // btnBuscarEst
            // 
            this.btnBuscarEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEst.Location = new System.Drawing.Point(1049, 48);
            this.btnBuscarEst.Name = "btnBuscarEst";
            this.btnBuscarEst.Size = new System.Drawing.Size(117, 42);
            this.btnBuscarEst.TabIndex = 4;
            this.btnBuscarEst.Text = "BUSCAR";
            this.btnBuscarEst.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "GESTION DE ESTUDIANTES";
            // 
            // frmestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEst);
            this.Controls.Add(this.txtBuscarEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.btnestudiante);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmestudiante";
            this.Text = "Gestion de estudiantes";
            this.Load += new System.EventHandler(this.frmestudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnestudiante;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEst;
        private System.Windows.Forms.Button btnBuscarEst;
        private System.Windows.Forms.Label label2;
    }
}