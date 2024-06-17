using InscripcionCol.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dt_inicio.Value = DateTime.Now.AddMonths(-1); // Predeterminado a un mes atrás
            dt_fin.Value = DateTime.Now; // Predeterminado a hoy
           // this.reportViewer1.RefreshReport();
        }
        private void ReporteFechas(DateTime startDate, DateTime endDate)
        {
            InformeDatosView informeDatos = new InformeDatosView(); 
            
            informeDatos.CrearInformeEstudiante(startDate, endDate);
            informeDatosViewBindingSource.DataSource = informeDatos;
            detalleEstudianteBindingSource.DataSource = informeDatos.DetalleEstudiantes;
            this.reportViewer1.RefreshReport();
        }
        private void btn_GenerarInforme_Click(object sender, EventArgs e)
        {
            var fechaInicio = dt_inicio.Value;
            var fechaFinal = dt_fin.Value;
            ReporteFechas(new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0), new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 23, 59, 59));
        }
    }
}
