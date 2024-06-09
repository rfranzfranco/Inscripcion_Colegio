using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Controlador;

namespace InscripcionCol.Vista
{
    public partial class frmreporte : Form
    {
        public frmreporte()
        {
            InitializeComponent();
        }

        private void frmreporte_Load(object sender, EventArgs e)
        {
                        
        }
        private void ReporteFechas(DateTime startDate, DateTime endDate)
        {
            ReporteDatosView reportModel= new ReporteDatosView();
            reportModel.crearReporteCurso(startDate, endDate);
            reporteDatosViewBindingSource.DataSource = reportModel;
            cursoDetallesBindingSource.DataSource = reportModel.CursoDetalles;
            this.reportViewer1.RefreshReport();
        }

        private void btn_generarRep_Click(object sender, EventArgs e)
        {
            var fechaInicio=dtp_inicio.Value;
            var fechaFinal=dtp_fin.Value;
            ReporteFechas(fechaInicio, fechaFinal);

        }
    }
}
