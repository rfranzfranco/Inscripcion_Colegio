using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    internal class UsuarioViewModel
    {
        public int ci { get; set; }
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string direccion { get; set; }
        public int celular { get; set; }
        public string sexo { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string rol { get; set; }
        public string id_registro { get; set; }
    }
}
