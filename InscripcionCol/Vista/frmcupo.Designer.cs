namespace InscripcionCol.Vista
{
    partial class frmcupo
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
            this.tbxbuscargrado = new System.Windows.Forms.TextBox();
            this.btnbuscarGrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncerrarcupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxbuscargrado
            // 
            this.tbxbuscargrado.Location = new System.Drawing.Point(732, 66);
            this.tbxbuscargrado.Margin = new System.Windows.Forms.Padding(4);
            this.tbxbuscargrado.Name = "tbxbuscargrado";
            this.tbxbuscargrado.Size = new System.Drawing.Size(67, 26);
            this.tbxbuscargrado.TabIndex = 0;
            // 
            // btnbuscarGrado
            // 
            this.btnbuscarGrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscarGrado.Location = new System.Drawing.Point(807, 57);
            this.btnbuscarGrado.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarGrado.Name = "btnbuscarGrado";
            this.btnbuscarGrado.Size = new System.Drawing.Size(117, 42);
            this.btnbuscarGrado.TabIndex = 5;
            this.btnbuscarGrado.Text = "BUSCAR";
            this.btnbuscarGrado.UseVisualStyleBackColor = true;
            this.btnbuscarGrado.Click += new System.EventHandler(this.btnbuscarGrado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por: Grado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "VISUALIZAR CUPO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1114, 526);
            this.dataGridView1.TabIndex = 8;
            // 
            // btncerrarcupo
            // 
            this.btncerrarcupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrarcupo.Location = new System.Drawing.Point(1000, 57);
            this.btncerrarcupo.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrarcupo.Name = "btncerrarcupo";
            this.btncerrarcupo.Size = new System.Drawing.Size(117, 42);
            this.btncerrarcupo.TabIndex = 9;
            this.btncerrarcupo.Text = "CERRAR";
            this.btncerrarcupo.UseVisualStyleBackColor = true;
            // 
            // frmcupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1139, 653);
            this.Controls.Add(this.btncerrarcupo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscarGrado);
            this.Controls.Add(this.tbxbuscargrado);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmcupo";
            this.Text = "Visualizar cupo";
            this.Load += new System.EventHandler(this.frmcupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxbuscargrado;
        private System.Windows.Forms.Button btnbuscarGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncerrarcupo;
    }
}