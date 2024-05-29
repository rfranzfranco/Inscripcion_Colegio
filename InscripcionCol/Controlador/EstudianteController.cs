using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using InscripcionCol.Modelo;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace InscripcionCol.Controlador
{
    public class EstudianteController
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
                        join nac in _db.TNacimiento on est.id_estudiante equals nac.id_estudiante
                        select new EstudianteViewModel
                        {
                            Id_Estudiante = est.id_estudiante,
                            Codigo_Rude = est.codigo_rude,
                            Ap_Paterno_E = est.ap_paterno,
                            Ap_Materno_E = est.ap_materno,
                            Nombre_E = est.nombre,
                            Ci_E = est.ci,
                            Ci_T = tu.ci,
                            Ap_Paterno_T = tu.ap_paterno,
                            Ap_Materno_T = tu.ap_materno,
                            Nombre_T = tu.nombre,
                            Telefono_Fijo = cont.telefono_fijo,
                            Celular = cont.celular,
                            Grado = cu.grado,
                            Paralelo = cu.paralelo,
                            Sexo=est.sexo,
                            fecha_Nacimiento=est.fec_nacimiento,
                            //no mostrar
                            Complemento=est.complemento,
                            Expedido=est.expedido,
                            Pais=nac.pais,
                            Departamento=nac.dpto,
                            Provincia=nac.provincia,
                            Localidad=nac.localidad,
                            sexo=est.sexo,
                            NumeroViviendaActual=dir.nro_vivienda,
                            DepartamentoActual=dir.dpto,
                            ProvinciaActual=dir.provincia,
                            MunicipioActual=dir.municipio,
                            LocalidadActual=dir.localidad,
                            ZonaActual=dir.zona,
                            AvenidaActual=dir.avenida,
                            ComplementoTutor=tu.complemento,
                            ExpedidoTutor=tu.expedido,
                            DepartamentoComprobante=co.lugar_dpto,
                            FechaRegistroComprobante=co.fecha_reg
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
        public bool EliminarEstudiante(int idEstudiante)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Eliminar registros en TTutor_Est
                    var tutorEstList = _db.TTutor_Est.Where(te => te.id_estudiante == idEstudiante).ToList();
                    _db.TTutor_Est.RemoveRange(tutorEstList);
                    // Eliminar registros en TDir_Est
                    var dirEstList = _db.TDir_Est.Where(de => de.id_estudiante == idEstudiante).ToList();
                    _db.TDir_Est.RemoveRange(dirEstList);
                    // Eliminar registros en TComprobante
                    var comprobantes = _db.TComprobante.Where(c => c.id_estudiante == idEstudiante).ToList();
                    _db.TComprobante.RemoveRange(comprobantes);
                    // Eliminar registros en TNacimiento
                    var nacimientos = _db.TNacimiento.Where(n => n.id_estudiante == idEstudiante).ToList();
                    _db.TNacimiento.RemoveRange(nacimientos);
                    // Eliminar registros en TDireccion y TContacto
                    foreach (var dirEst in dirEstList)
                    {
                        var direcciones = _db.TDireccion.Where(d => d.id_direccion == dirEst.id_direccion).ToList();
                        foreach (var direccion in direcciones)
                        {
                            var contactos = _db.TContacto.Where(c => c.id_direccion == direccion.id_direccion).ToList();
                            _db.TContacto.RemoveRange(contactos);
                            _db.TDireccion.Remove(direccion);
                        }
                    }
                    // Eliminar registros en TTutor
                    foreach (var tutorEst in tutorEstList)
                    {
                        var tutores = _db.TTutor.Where(t => t.id_tutor == tutorEst.id_tutor).ToList();
                        _db.TTutor.RemoveRange(tutores);
                    }
                    // Finalmente, eliminar el estudiante
                    TEstudiante estudiante = _db.TEstudiante.Find(idEstudiante);
                    _db.TEstudiante.Remove(estudiante);

                    _db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public async Task<bool> ModificarEstudianteAsync(TEstudiante estudiante)
        {
            _db.Entry(estudiante).State=EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> ModificarNacimientoAsync(TNacimiento nacimiento)
        {
            _db.Entry(nacimiento).State = EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> ModificarDireccionAsync(TDireccion direccion)
        {
            _db.Entry(direccion).State = EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> ModificarContactoAsync(TContacto contacto)
        {
            _db.Entry(contacto).State = EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> ModificarTutorAsync(TTutor tutor)
        {
            _db.Entry(tutor).State = EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> ModificarComprobanteAsync(TComprobante comprobante)
        {
            _db.Entry(comprobante).State = EntityState.Modified;
            int result = await _db.SaveChangesAsync();
            return result > 0; 
        }
    }
}
