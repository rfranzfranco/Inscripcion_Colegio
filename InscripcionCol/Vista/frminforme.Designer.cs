namespace InscripcionCol.Vista
{
    partial class frminforme
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_GenerarInforme = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detalleEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informeDatosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeDatosViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dt_fin);
            this.panel1.Controls.Add(this.dt_inicio);
            this.panel1.Controls.Add(this.btn_GenerarInforme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 165);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "INFORME";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Finalizacion";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // dt_fin
            // 
            this.dt_fin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_fin.Location = new System.Drawing.Point(535, 91);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(200, 26);
            this.dt_fin.TabIndex = 2;
            // 
            // dt_inicio
            // 
            this.dt_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_inicio.Location = new System.Drawing.Point(272, 91);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(200, 26);
            this.dt_inicio.TabIndex = 1;
            // 
            // btn_GenerarInforme
            // 
            this.btn_GenerarInforme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_GenerarInforme.Location = new System.Drawing.Point(816, 72);
            this.btn_GenerarInforme.Name = "btn_GenerarInforme";
            this.btn_GenerarInforme.Size = new System.Drawing.Size(208, 53);
            this.btn_GenerarInforme.TabIndex = 0;
            this.btn_GenerarInforme.Text = "GENERAR INFORME";
            this.btn_GenerarInforme.UseVisualStyleBackColor = true;
            this.btn_GenerarInforme.Click += new System.EventHandler(this.btn_GenerarInforme_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.detalleEstudianteBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.informeDatosViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InscripcionCol.Vista.informeEs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 165);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 458);
            this.reportViewer1.TabIndex = 1;
            // 
            // detalleEstudianteBindingSource
            // 
            this.detalleEstudianteBindingSource.DataSource = typeof(InscripcionCol.Controlador.detalleEstudiante);
            // 
            // informeDatosViewBindingSource
            // 
            this.informeDatosViewBindingSource.DataSource = typeof(InscripcionCol.Controlador.InformeDatosView);
            // 
            // frminforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frminforme";
            this.Text = "frminforme";
            this.Load += new System.EventHandler(this.frminforme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeDatosViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_fin;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.Button btn_GenerarInforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detalleEstudianteBindingSource;
        private System.Windows.Forms.BindingSource informeDatosViewBindingSource;
        private System.Windows.Forms.Label label3;
    }
}