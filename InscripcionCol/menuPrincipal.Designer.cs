namespace InscripcionCol
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCuposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCuposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarBecasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesEInformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuarioToolStripMenuItem,
            this.gestionarEstudiantesToolStripMenuItem,
            this.gestionarBecasToolStripMenuItem,
            this.reportesEInformesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarUsuarioToolStripMenuItem
            // 
            this.gestionarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarUsuarioToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.usuario;
            this.gestionarUsuarioToolStripMenuItem.Name = "gestionarUsuarioToolStripMenuItem";
            this.gestionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.gestionarUsuarioToolStripMenuItem.Text = "Gestionar Usuario";
            this.gestionarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuarioToolStripMenuItem_Click);
            // 
            // gestionarEstudiantesToolStripMenuItem
            // 
            this.gestionarEstudiantesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarCuposToolStripMenuItem,
            this.visualizarCuposToolStripMenuItem1});
            this.gestionarEstudiantesToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.estudiante;
            this.gestionarEstudiantesToolStripMenuItem.Name = "gestionarEstudiantesToolStripMenuItem";
            this.gestionarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.gestionarEstudiantesToolStripMenuItem.Text = "Gestionar Estudiantes";
            this.gestionarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.gestionarEstudiantesToolStripMenuItem_Click);
            // 
            // visualizarCuposToolStripMenuItem
            // 
            this.visualizarCuposToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.estudiantes;
            this.visualizarCuposToolStripMenuItem.Name = "visualizarCuposToolStripMenuItem";
            this.visualizarCuposToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.visualizarCuposToolStripMenuItem.Text = "Registrar Estudiantes";
            this.visualizarCuposToolStripMenuItem.Click += new System.EventHandler(this.visualizarCuposToolStripMenuItem_Click);
            // 
            // visualizarCuposToolStripMenuItem1
            // 
            this.visualizarCuposToolStripMenuItem1.Image = global::InscripcionCol.Properties.Resources.vision;
            this.visualizarCuposToolStripMenuItem1.Name = "visualizarCuposToolStripMenuItem1";
            this.visualizarCuposToolStripMenuItem1.Size = new System.Drawing.Size(283, 28);
            this.visualizarCuposToolStripMenuItem1.Text = "Visualizar Cupos";
            // 
            // gestionarBecasToolStripMenuItem
            // 
            this.gestionarBecasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarBecasToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.beca;
            this.gestionarBecasToolStripMenuItem.Name = "gestionarBecasToolStripMenuItem";
            this.gestionarBecasToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.gestionarBecasToolStripMenuItem.Text = "Gestionar Becas";
            // 
            // reportesEInformesToolStripMenuItem
            // 
            this.reportesEInformesToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.grafico;
            this.reportesEInformesToolStripMenuItem.Name = "reportesEInformesToolStripMenuItem";
            this.reportesEInformesToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.reportesEInformesToolStripMenuItem.Text = "Reportes e Informes";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarBecasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesEInformesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCuposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCuposToolStripMenuItem1;
    }
}