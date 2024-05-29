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
    internal class UsuarioController
    {
        private readonly RegistroColegioDBEntities _db = new RegistroColegioDBEntities();

        public List<UsuarioViewModel> Listar()
        {
            try
            {
                var query = from usuario in _db.TUsuario
                            join registro in _db.TRegistro on usuario.id_registro equals registro.id_registro
                            select new UsuarioViewModel
                            {
                                ci = registro.ci,
                                nombre = registro.nombre,
                                ap_paterno = registro.ap_paterno,
                                ap_materno = registro.ap_materno,
                                direccion = registro.direccion,
                                celular = registro.celular,
                                sexo = registro.sexo,
                                fecha_nac = registro.fecha_nac,
                                usuario = usuario.usuario,
                                contraseña = usuario.contraseña,
                                rol = usuario.rol
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al listar los usuarios: {ex.Message}");
                return new List<UsuarioViewModel>();
            }
        }

        public async Task<bool> RegistrarUsuarioAsync(TRegistro registro, TUsuario usuario)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.TRegistro.Add(registro);
                    await _db.SaveChangesAsync();

                    usuario.id_registro = registro.id_registro;
                    _db.TUsuario.Add(usuario);
                    await _db.SaveChangesAsync();

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }      

    }
}

