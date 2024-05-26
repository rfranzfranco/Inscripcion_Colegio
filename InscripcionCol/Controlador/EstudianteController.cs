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
        public List<EstudianteViewModel> Listar()
        {
            var query = from est in _db.TEstudiante
                        join tuest in _db.TTutor_Est on est.id_estudiante equals tuest.id_estudiante
                        join tu in _db.TTutor on tuest.id_tutor equals tu.id_tutor
                        join direst in _db.TDir_Est on est.id_estudiante equals direst.id_estudiante
                        join dir in _db.TDireccion on direst.id_direccion equals dir.id_direccion
                        join cont in _db.TContacto on dir.id_direccion equals cont.id_direccion
                        join co in _db.TComprobante on est.id_estudiante equals co.id_estudiante
                        join cu in _db.TCurso on co.id_curso equals cu.id_curso
                        select new EstudianteViewModel
                        {
                            Ap_Paterno_Est = est.ap_paterno,
                            Ap_Materno_Est = est.ap_materno,
                            Nombre_Est = est.nombre,
                            Ci_Est = est.ci,
                            Codigo_Rude = est.codigo_rude,
                            TCi = tu.ci,
                            TAp_Paterno = tu.ap_paterno,
                            TAp_Materno = tu.ap_materno,
                            TNombre = tu.nombre,
                            Telefono_Fijo = cont.telefono_fijo,
                            Celular = cont.celular,
                            Grado = cu.grado,
                            Paralelo = cu.paralelo,
                            Sexo=est.sexo,
                            fecha_Nac=est.fec_nacimiento
                        };

            return query.ToList();
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
        public List<EstudianteViewModel> Buscar(string param)
        {
            if(param.Trim().Equals(string.Empty))
            {
                return Listar();
            }
            else
            {
                return Listar().Where(estudiante => estudiante.Codigo_Rude.Contains(param)).ToList();
            }
        }        
    }
}
