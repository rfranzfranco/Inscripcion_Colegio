using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class ReporteDatosView
    {
        public DateTime fechaReporte { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int TotalEstudiantes { get; set; }
        public List<cursoDetalles> CursoDetalles { get; set; }
        public void crearReporteCurso(DateTime fechaInicio, DateTime fechaFin)
        {
            fechaReporte = DateTime.Now;
            fecha_inicio = fechaInicio;
            fecha_fin = fechaFin;
            //crear lista de curso
            var reporteCont = new ReporteController();
            var result = reporteCont.ReporteEstFechas(fechaInicio, fechaFin); // Usa fechaInicio y fechaFin en lugar de fechaReporte

            CursoDetalles = new List<cursoDetalles>();
            TotalEstudiantes = 0;
            foreach (System.Data.DataRow row in result.Rows)
            {
                var c = new cursoDetalles
                {
                    grado = Convert.ToInt32(row["grado"]),
                    paralelo = Convert.ToString(row["paralelo"]),
                    totalEst = Convert.ToInt32(row["cantidad_estudiantes"])
                };
                CursoDetalles.Add(c);
                TotalEstudiantes += c.totalEst;
            }
        }
    }
}
