using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Controlador;

namespace InscripcionCol.Vista
{
    public partial class frminforme : Form
    {
        public frminforme()
        {
            InitializeComponent();
        }

        private void frminforme_Load(object sender, EventArgs e)
        {
            // Configuración predeterminada de los DateTimePicker
            dtpStartDate.Value = DateTime.Now.AddMonths(-1); // Predeterminado a un mes atrás
            dtpEndDate.Value = DateTime.Now; // Predeterminado a hoy
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Obtener las fechas de los DateTimePicker
            var fechaInicio = dtpStartDate.Value;
            var fechaFin = dtpEndDate.Value;

            // Llamar al método para generar el informe con las fechas seleccionadas
            InformeFechas(new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0),
                          new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, 23, 59, 59));
        }

        private void InformeFechas(DateTime startDate, DateTime endDate)
        {
            // Crear una instancia del modelo de datos del informe
            InformeDatosView reportModel = new InformeDatosView();

            // Llenar el modelo de datos con los detalles de los estudiantes
            reportModel.CrearInformeEstudiante(startDate, endDate);

            // Construir la ruta completa del archivo de informe
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Reportes\info.rdlc");

            // Verificar si el archivo de informe existe
            if (!File.Exists(reportPath))
            {
                // Mostrar un mensaje de error si el archivo no se encuentra
                MessageBox.Show($"El archivo de reporte no se encuentra en la ruta especificada: {reportPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configurar el ReportViewer con la ruta del informe
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.DataSources.Clear(); // Limpiar cualquier fuente de datos previa

            // Crear una nueva fuente de datos para el ReportViewer
            var rds = new Microsoft.Reporting.WinForms.ReportDataSource("EstudiantesDataSet", reportModel.DetalleEstudiantes);
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Crear parámetros para pasar al informe (opcional)
            var reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate.ToString("yyyy-MM-dd")),
                new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate.ToString("yyyy-MM-dd"))
            };

            // Asignar los parámetros al informe (comentado si no se usan en el RDLC)
            // reportViewer1.LocalReport.SetParameters(reportParameters);

            // Refrescar el ReportViewer para mostrar el informe actualizado
            reportViewer1.RefreshReport();
        }

        private void detalleEstudianteBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void informeDatosViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

