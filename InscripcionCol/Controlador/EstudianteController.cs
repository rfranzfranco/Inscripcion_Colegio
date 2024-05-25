using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InscripcionCol.Modelo;
using InscripcionCol.Vista;

namespace InscripcionCol.Controlador
{
    internal class EstudianteController
    {
        RegistroColegioDBEntities _db=new RegistroColegioDBEntities();
        public List<TEstudiante> listar()
        {
            return _db.TEstudiante.ToList();
        }
    }
}
