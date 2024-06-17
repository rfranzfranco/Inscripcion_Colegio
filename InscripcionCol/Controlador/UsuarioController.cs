using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using InscripcionCol.Modelo;
using System.Data.Entity;

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
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar el usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public List<UsuarioViewModel> Buscar(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
            {
                return Listar();
            }
            else
            {
                if (int.TryParse(param, out int ci))
                {
                    return Listar().Where(registro => registro.ci == ci).ToList();
                }
                else
                {
                    MessageBox.Show("El CI debe ser un número válido.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<UsuarioViewModel>();
                }
            }
        }

        public bool EliminarUsuario(int ci)
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

                    // Encontrar el usuario correspondiente en TUsuario
                    var usuario = _db.TUsuario.SingleOrDefault(u => u.id_registro == registro.id_registro);
                    if (usuario != null)
                    {
                        _db.TUsuario.Remove(usuario);
                    }

                    // Eliminar el registro en TRegistro
                    _db.TRegistro.Remove(registro);

                    _db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error al eliminar el usuario: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<bool> ModificarUsuarioAsync(TRegistro registro, TUsuario usuario)
        {
            try
            {
                // Buscar el registro existente por CI
                var registroExistente = await _db.TRegistro.FirstOrDefaultAsync(r => r.ci == registro.ci);
                if (registroExistente == null)
                {
                    return false; // No se encontró el registro
                }

                // Actualizar los campos del registro
                registroExistente.nombre = registro.nombre;
                registroExistente.ci = registro.ci;
                registroExistente.ap_paterno = registro.ap_paterno;
                registroExistente.ap_materno = registro.ap_materno;
                registroExistente.direccion = registro.direccion;
                registroExistente.celular = registro.celular;
                registroExistente.sexo = registro.sexo;
                registroExistente.fecha_nac = registro.fecha_nac;

                // Buscar el usuario existente por id_registro
                var usuarioExistente = await _db.TUsuario.FirstOrDefaultAsync(u => u.id_registro == registroExistente.id_registro);
                if (usuarioExistente == null)
                {
                    return false; // No se encontró el usuario
                }

                // Actualizar los campos del usuario
                usuarioExistente.usuario = usuario.usuario;
                usuarioExistente.contraseña = usuario.contraseña;
                usuarioExistente.rol = usuario.rol;

                // Guardar los cambios en la base de datos
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                Console.WriteLine($"Error al modificar el usuario: {ex.Message}");
                return false;
            }
        }
        // Complemento: Método para verificar si un CI ya existe en la base de datos
        public async Task<bool> CiExisteAsync(int ci)
        {
            // Verificar si existe algún registro con el CI proporcionado
            var usuarioExistente = await _db.TRegistro.AnyAsync(r => r.ci == ci);
            return usuarioExistente;
        }
    }
}

