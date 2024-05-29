using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class CupoViewModel
    {
        public int Grado { get; set; }
        public string Paralelo {  get; set; }
        //public string Profesor { get; set; }
        public int Cupo { get; set; } = 30;
        public int Cupo_Disponible { get; set; }
    }
}
