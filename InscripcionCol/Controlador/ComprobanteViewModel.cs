﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class ComprobanteViewModel
    {
        public int CI_estudiante {  get; set; }
        public Int64 RUDE { get; set; }
        public string ap_paterno {  get; set; }
        public string ap_materno { get; set; }
        public string Nombre { get; set; }
        public int grado { get; set; }
        public string paralelo { get; set; }
    }
}
