namespace InscripcionCol.Vista
{
    partial class frmreporte
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
            this.cursoDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDatosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_generarRep = new System.Windows.Forms.Button();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDatosViewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cursoDetallesBindingSource
            // 
            this.cursoDetallesBindingSource.DataSource = typeof(InscripcionCol.Controlador.cursoDetalles);
            // 
            // reporteDatosViewBindingSource
            // 
            this.reporteDatosViewBindingSource.DataSource = typeof(InscripcionCol.Controlador.ReporteDatosView);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cursoDetallesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.reporteDatosViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InscripcionCol.Vista.Reportecursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(237, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(963, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_generarRep);
            this.panel1.Controls.Add(this.dtp_fin);
            this.panel1.Controls.Add(this.dtp_inicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 623);
            this.panel1.TabIndex = 1;
            // 
            // btn_generarRep
            // 
            this.btn_generarRep.Location = new System.Drawing.Point(12, 251);
            this.btn_generarRep.Name = "btn_generarRep";
            this.btn_generarRep.Size = new System.Drawing.Size(200, 50);
            this.btn_generarRep.TabIndex = 4;
            this.btn_generarRep.Text = "Generar Reporte";
            this.btn_generarRep.UseVisualStyleBackColor = true;
            this.btn_generarRep.Click += new System.EventHandler(this.btn_generarRep_Click);
            // 
            // dtp_fin
            // 
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fin.Location = new System.Drawing.Point(12, 187);
            this.dtp_fin.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtp_fin.MinDate = new System.DateTime(2024, 6, 9, 0, 0, 0, 0);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 26);
            this.dtp_fin.TabIndex = 3;
            this.dtp_fin.Value = new System.DateTime(2024, 6, 9, 0, 0, 0, 0);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(12, 80);
            this.dtp_inicio.MaxDate = new System.DateTime(2024, 6, 9, 0, 0, 0, 0);
            this.dtp_inicio.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 26);
            this.dtp_inicio.TabIndex = 2;
            this.dtp_inicio.Value = new System.DateTime(2024, 6, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de finalización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de inicio:";
            // 
            // frmreporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmreporte";
            this.Text = "frmreporte";
            this.Load += new System.EventHandler(this.frmreporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursoDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDatosViewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cursoDetallesBindingSource;
        private System.Windows.Forms.BindingSource reporteDatosViewBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generarRep;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}