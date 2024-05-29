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
            this.gestionarProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesEInformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuarioToolStripMenuItem,
            this.gestionarEstudiantesToolStripMenuItem,
            this.gestionarBecasToolStripMenuItem,
            this.gestionarProfesoresToolStripMenuItem,
            this.reportesEInformesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarUsuarioToolStripMenuItem
            // 
            this.gestionarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarUsuarioToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.usuario;
            this.gestionarUsuarioToolStripMenuItem.Name = "gestionarUsuarioToolStripMenuItem";
            this.gestionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.gestionarUsuarioToolStripMenuItem.Text = "Gestionar Usuario";
            this.gestionarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuarioToolStripMenuItem_Click);
            // 
            // gestionarEstudiantesToolStripMenuItem
            // 
            this.gestionarEstudiantesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarCuposToolStripMenuItem,
            this.visualizarCuposToolStripMenuItem1});
            this.gestionarEstudiantesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarEstudiantesToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.estudiante;
            this.gestionarEstudiantesToolStripMenuItem.Name = "gestionarEstudiantesToolStripMenuItem";
            this.gestionarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.gestionarEstudiantesToolStripMenuItem.Text = "Gestionar Estudiantes";
            this.gestionarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.gestionarEstudiantesToolStripMenuItem_Click);
            // 
            // visualizarCuposToolStripMenuItem
            // 
            this.visualizarCuposToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.estudiantes;
            this.visualizarCuposToolStripMenuItem.Name = "visualizarCuposToolStripMenuItem";
            this.visualizarCuposToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.visualizarCuposToolStripMenuItem.Text = "Registrar Estudiantes";
            this.visualizarCuposToolStripMenuItem.Click += new System.EventHandler(this.visualizarCuposToolStripMenuItem_Click);
            // 
            // visualizarCuposToolStripMenuItem1
            // 
            this.visualizarCuposToolStripMenuItem1.Image = global::InscripcionCol.Properties.Resources.vision;
            this.visualizarCuposToolStripMenuItem1.Name = "visualizarCuposToolStripMenuItem1";
            this.visualizarCuposToolStripMenuItem1.Size = new System.Drawing.Size(282, 28);
            this.visualizarCuposToolStripMenuItem1.Text = "Visualizar Cupos";
            this.visualizarCuposToolStripMenuItem1.Click += new System.EventHandler(this.visualizarCuposToolStripMenuItem1_Click);
            // 
            // gestionarBecasToolStripMenuItem
            // 
            this.gestionarBecasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionarBecasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarBecasToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.beca;
            this.gestionarBecasToolStripMenuItem.Name = "gestionarBecasToolStripMenuItem";
            this.gestionarBecasToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.gestionarBecasToolStripMenuItem.Text = "Registrar Beca";
            this.gestionarBecasToolStripMenuItem.Click += new System.EventHandler(this.gestionarBecasToolStripMenuItem_Click);
            // 
            // gestionarProfesoresToolStripMenuItem
            // 
            this.gestionarProfesoresToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarProfesoresToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.chequeo;
            this.gestionarProfesoresToolStripMenuItem.Name = "gestionarProfesoresToolStripMenuItem";
            this.gestionarProfesoresToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.gestionarProfesoresToolStripMenuItem.Text = "Gestionar Profesor";
            this.gestionarProfesoresToolStripMenuItem.Click += new System.EventHandler(this.gestionarProfesoresToolStripMenuItem_Click);
            // 
            // reportesEInformesToolStripMenuItem
            // 
            this.reportesEInformesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.reportesEInformesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesEInformesToolStripMenuItem.Image = global::InscripcionCol.Properties.Resources.grafico;
            this.reportesEInformesToolStripMenuItem.Name = "reportesEInformesToolStripMenuItem";
            this.reportesEInformesToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.reportesEInformesToolStripMenuItem.Text = "Reportes e Informes";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 495);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.ToolStripMenuItem gestionarProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}