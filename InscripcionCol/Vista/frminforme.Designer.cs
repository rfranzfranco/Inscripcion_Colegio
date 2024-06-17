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
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.detalleEstudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleEstudianteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informeDatosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeDatosViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdatos
            // 
            this.gbdatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbdatos.Controls.Add(this.label3);
            this.gbdatos.Controls.Add(this.label2);
            this.gbdatos.Controls.Add(this.label1);
            this.gbdatos.Controls.Add(this.dtpEndDate);
            this.gbdatos.Controls.Add(this.dtpStartDate);
            this.gbdatos.Controls.Add(this.btnGenerarReport);
            this.gbdatos.Location = new System.Drawing.Point(1, 0);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(1233, 197);
            this.gbdatos.TabIndex = 0;
            this.gbdatos.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Finalizacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Inicio";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(496, 124);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(214, 124);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 1;
            // 
            // btnGenerarReport
            // 
            this.btnGenerarReport.Location = new System.Drawing.Point(759, 113);
            this.btnGenerarReport.Name = "btnGenerarReport";
            this.btnGenerarReport.Size = new System.Drawing.Size(119, 37);
            this.btnGenerarReport.TabIndex = 0;
            this.btnGenerarReport.Text = "GENERAR";
            this.btnGenerarReport.UseVisualStyleBackColor = true;
            this.btnGenerarReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Gainsboro;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.detalleEstudianteBindingSource1;
            reportDataSource2.Name = "DataSet4";
            reportDataSource2.Value = this.detalleEstudianteBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InscripcionCol.Vista.Info.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 193);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1233, 490);
            this.reportViewer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "INFORME";
            // 
            // detalleEstudianteBindingSource1
            // 
            this.detalleEstudianteBindingSource1.DataSource = typeof(InscripcionCol.Controlador.detalleEstudiante);
            // 
            // detalleEstudianteBindingSource2
            // 
            this.detalleEstudianteBindingSource2.DataSource = typeof(InscripcionCol.Controlador.detalleEstudiante);
            this.detalleEstudianteBindingSource2.CurrentChanged += new System.EventHandler(this.detalleEstudianteBindingSource2_CurrentChanged);
            // 
            // detalleEstudianteBindingSource
            // 
            this.detalleEstudianteBindingSource.DataSource = typeof(InscripcionCol.Controlador.detalleEstudiante);
            // 
            // informeDatosViewBindingSource
            // 
            this.informeDatosViewBindingSource.DataSource = typeof(InscripcionCol.Controlador.InformeDatosView);
            this.informeDatosViewBindingSource.CurrentChanged += new System.EventHandler(this.informeDatosViewBindingSource_CurrentChanged);
            // 
            // tEstudianteBindingSource
            // 
            this.tEstudianteBindingSource.DataSource = typeof(InscripcionCol.Modelo.TEstudiante);
            // 
            // frminforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbdatos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frminforme";
            this.Text = "frminforme";
            this.Load += new System.EventHandler(this.frminforme_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeDatosViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnGenerarReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tEstudianteBindingSource;
        private System.Windows.Forms.BindingSource detalleEstudianteBindingSource;
        private System.Windows.Forms.BindingSource informeDatosViewBindingSource;
        private System.Windows.Forms.BindingSource detalleEstudianteBindingSource1;
        private System.Windows.Forms.BindingSource detalleEstudianteBindingSource2;
        private System.Windows.Forms.Label label3;
    }
}