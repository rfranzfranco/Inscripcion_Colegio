using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class BecaViewModel
    {
        public int Id_Beca { get; set; }
        public int CI { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public int Id_Estudiante { get; set; }
    }
}
