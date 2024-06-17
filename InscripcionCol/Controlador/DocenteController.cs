using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using InscripcionCol.Modelo;

namespace InscripcionCol.Controlador
{
    internal class DocenteController
    {
        private readonly RegistroColegioDBEntities _db = new RegistroColegioDBEntities();

        public List<DocenteViewModel> Listar()
        {
            try
            {
                var query = from docente in _db.TDocente
                            join registro in _db.TRegistro on docente.id_registro equals registro.id_registro
                            select new DocenteViewModel
                            {
                                id_docente = docente.id_docente,
                                especialidad = docente.especialidad,
                                nivel_educativo = docente.nivel_educativo,
                                grado_acad = docente.grado_acad,
                                fec_contratacion = docente.fec_contratacion,
                                id_registro = registro.id_registro,
                                ci = registro.ci,
                                nombre = registro.nombre,
                                ap_paterno = registro.ap_paterno,
                                ap_materno = registro.ap_materno,
                                direccion = registro.direccion,
                                celular = registro.celular,
                                sexo = registro.sexo,
                                fecha_nac = registro.fecha_nac,
                                id_curso = docente.id_curso,
                                
                                
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al listar los docentes: {ex.Message}");
                return new List<DocenteViewModel>();
            }
        }

        public async Task<bool> RegistrarDocenteAsync(TRegistro registro)
        {
            
                    _db.TRegistro.Add(registro);
                    return await _db.SaveChangesAsync()>0;                 
                                                  
            
        }
        public async Task<bool> RegistrarDocAsync(TDocente docente)
        {
            _db.TDocente.Add(docente);
            return await _db.SaveChangesAsync()>0;
        }

        public List<DocenteViewModel> Buscar(int ci)
        {
            try
            {
                var query = from docente in _db.TDocente
                            join registro in _db.TRegistro on docente.id_registro equals registro.id_registro
                            join curso in _db.TCurso on docente.id_curso equals curso.id_curso
                            where registro.ci == ci
                            select new DocenteViewModel
                            {
                                ci = registro.ci,
                                nombre = registro.nombre,
                                ap_paterno = registro.ap_paterno,
                                ap_materno = registro.ap_materno,
                                direccion = registro.direccion,
                                celular = registro.celular,
                                sexo = registro.sexo,
                                fecha_nac = registro.fecha_nac,
                                especialidad = docente.especialidad,
                                nivel_educativo = docente.nivel_educativo,
                                grado_acad = docente.grado_acad,
                                fec_contratacion = docente.fec_contratacion,
                                id_curso = curso.id_curso
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al buscar el docente: {ex.Message}");
                return new List<DocenteViewModel>();
            }
        }

        public bool EliminarDocente(int ci)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Encontrar el registro correspondiente en TRegistro
                    var registro = _db.TRegistro.SingleOrDefault(r => r.ci == ci);
                    if (registro == null)
                    {
                        MessageBox.Show("No se encontró el registro correspondiente.");
                        return false;
                    }

                    // Encontrar el docente correspondiente en TDocente
                    var docente = _db.TDocente.SingleOrDefault(d => d.id_registro == registro.id_registro);
                    if (docente != null)
                    {
                        _db.TDocente.Remove(docente);
                    }

                    // Eliminar el registro en TRegistro
                    _db.TRegistro.Remove(registro);

                    _db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error al eliminar el docente: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }


    }
}
