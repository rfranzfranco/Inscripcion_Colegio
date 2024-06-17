using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    internal class DocenteViewModel
    {
        public int id_docente { get; set; }
        public int ci { get; set; }
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string direccion { get; set; }
        public int celular { get; set; }
        public string sexo { get; set; }
        public DateTime fecha_nac { get; set; }
        public string especialidad { get; set; }
        public string nivel_educativo { get; set; }
        public string grado_acad { get; set; }
        public DateTime fec_contratacion { get; set; }
        public int id_registro { get; set; }        
        public int id_curso { get; set; }
    }
}
