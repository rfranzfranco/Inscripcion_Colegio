using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class InformeDatosView
    {
        public DateTime FechaInforme { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<detalleEstudiante> DetalleEstudiantes { get; set; }

        public void CrearInformeEstudiante(DateTime fechaInicio, DateTime fechaFin)
        {
            FechaInforme = DateTime.Now;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;

            var reporteCont = new InformeController();
            var result = reporteCont.InformeEstFechas(fechaInicio, fechaFin);

            DetalleEstudiantes = new List<detalleEstudiante>();
            foreach (System.Data.DataRow row in result.Rows)
            {
                var detalle = new detalleEstudiante
                {
                    Nombre = row["nombre"].ToString(),
                    ApellidoPa = row["ap_paterno"].ToString(),
                    ApellidoMa = row["ap_materno"].ToString(),
                    Grado = Convert.ToInt32(row["grado"]),
                    Paralelo = row["paralelo"].ToString()
                };
                DetalleEstudiantes.Add(detalle);
            }
        }
    }
}
