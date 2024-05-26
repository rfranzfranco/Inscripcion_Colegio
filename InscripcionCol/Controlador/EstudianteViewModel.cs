using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    internal class EstudianteViewModel
    {
        public int Ci_Est { get; set; }
        public string Ap_Paterno_Est { get; set; }
        public string Ap_Materno_Est { get; set; }
        public string Nombre_Est { get; set; }        
        public string Codigo_Rude { get; set; }
        public string Sexo { get; set; }
        public DateTime fecha_Nac { get; set; }
        public int Grado { get; set; }
        public string Paralelo { get; set; }
        public int TCi { get; set; }
        public string TAp_Paterno { get; set; }
        public string TAp_Materno { get; set; }
        public string TNombre { get; set; }
        public int Telefono_Fijo { get; set; }
        public int Celular { get; set; }      
    }
}
