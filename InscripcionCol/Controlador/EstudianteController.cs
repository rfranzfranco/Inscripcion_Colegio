using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using InscripcionCol.Modelo;

namespace InscripcionCol.Controlador
{
    internal class EstudianteController
    {
        private readonly RegistroColegioDBEntities _db=new RegistroColegioDBEntities();        
        public List<TEstudiante> listar()
        {
            return _db.TEstudiante.ToList();
        }
        public async Task<bool> RegistrarEstudianteAsync(TEstudiante estudiante)
        {
            _db.TEstudiante.Add(estudiante);
            return await _db.SaveChangesAsync() > 0;
        }
        public async Task<bool> RegistrarNacimientoAsync(TNacimiento onacimiento)
        {
            _db.TNacimiento.Add(onacimiento);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RegistrarDireccionAsync(TDireccion odireccion)
        {
            _db.TDireccion.Add(odireccion);
            return await _db.SaveChangesAsync() > 0;
        }
        public async Task<bool> RegistrarDir_EstAsync(TDir_Est oDir_Est)
        {
            _db.TDir_Est.Add(oDir_Est);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RegistrarContactoAsync(TContacto ocontacto)
        {
            _db.TContacto.Add(ocontacto);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RegistrarTutorAsync(TTutor otutor)
        {
            _db.TTutor.Add(otutor);
            return await _db.SaveChangesAsync() > 0;
        }
        public async Task<bool> RegistrarTutor_EstAsync(TTutor_Est otutor_Est)
        {
            _db.TTutor_Est.Add(otutor_Est);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RegistrarComprobanteAsync(TComprobante ocomprobante)
        {
            _db.TComprobante.Add(ocomprobante);
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
