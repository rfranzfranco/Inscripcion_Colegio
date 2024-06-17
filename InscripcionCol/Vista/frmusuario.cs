using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Controlador;
using InscripcionCol.Modelo;
using static InscripcionCol.frmInicioSesion;

namespace InscripcionCol
{
    public partial class frmusuario : Form
    {
        private UsuarioController usuarioController;

        public frmusuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            btnmodificar.Click += btnModificar_Click;
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            DeshabilitarCampos();
           // VerificarRolUsuarioActual();
        }

       /* private void VerificarRolUsuarioActual()
        {
            string rolUsuarioActual = ObtenerRolUsuarioActual();
            if (rolUsuarioActual == "Secretaria/o")
            {
                btnAgregarUsuario.Enabled = false;
                btneliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnmodificar.Enabled = false;
            }
        }

        private string ObtenerRolUsuarioActual()
        {
            return Sesion.ObtenerRol();
        }*/

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos y mostrar advertencia específica
                if (CamposVacios())
                {
                    MessageBox.Show("Faltan datos por llenar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que la contraseña tenga más de 8 caracteres
                if (txtContrasena.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña debe tener más de 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que las contraseñas coincidan
                string ConfirmarContraseña = txtrepetirContra.Text;
                if (txtContrasena.Text != ConfirmarContraseña)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Validar que el CI solo contenga números
                if (!int.TryParse(txtci.Text, out int ci))
                {
                    MessageBox.Show("El CI debe contener solo números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el celular solo contenga números
                if (!int.TryParse(txtcelular.Text, out int celular))
                {
                    MessageBox.Show("El número de celular debe contener solo números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que los campos de texto no contengan números o caracteres no permitidos
                if (ContieneNumerosOCaracteres(txtNombre.Text) || ContieneNumerosOCaracteres(txtApPaterno.Text) || ContieneNumerosOCaracteres(txtApMaterno.Text))
                {
                    MessageBox.Show("Los campos de nombre y apellidos no deben contener números ni caracteres especiales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validar que el rol seleccionado es válido
                if (!RolValido(cmbRol.Text))
                {
                    MessageBox.Show("El rol seleccionado no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Verificar si el CI ya existe
                if (await usuarioController.CiExisteAsync(ci))
                {
                    MessageBox.Show("El CI ya existe en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto de registro con datos validados
                TRegistro registro = new TRegistro
                {
                    ci = ci,
                    nombre = txtNombre.Text,
                    ap_paterno = txtApPaterno.Text,
                    ap_materno = txtApMaterno.Text,
                    direccion = txtdireccion.Text,
                    celular = celular,
                    sexo = (rbtmasculino.Checked == true) ? "M" : "F",
                    fecha_nac = DateTime.Parse(datefNac.Text),
                };

                // Crear objeto de usuario con datos validados
                TUsuario usuario = new TUsuario
                {
                    usuario = txtNomusuario.Text,
                    contraseña = txtContrasena.Text,
                    rol = cmbRol.Text
                };

                // Intentar registrar usuario de manera asíncrona
                bool registrado = await usuarioController.RegistrarUsuarioAsync(registro, usuario);

                // Verificar resultado del registro y mostrar mensaje adecuado
                if (registrado)
                {
                    MessageBox.Show("Usuario guardado con éxito.");
                    CargarUsuarios();
                    LimpiarCampos();
                    DeshabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones y mostrar mensaje de error
                MessageBox.Show($"Ha ocurrido un error al guardar el usuario: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para validar si un campo contiene números o caracteres no permitidos
        private bool ContieneNumerosOCaracteres(string texto)
        {
            foreach (char c in texto)
            {
                if (char.IsDigit(c) || !char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
        // Función para verificar si el rol seleccionado es válido
        private bool RolValido(string rol)
        {
            foreach (var item in cmbRol.Items)
            {
                if (item.ToString() == rol)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CamposVacios()
        {
            return string.IsNullOrWhiteSpace(txtci.Text) ||
                   string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtApPaterno.Text) ||
                   string.IsNullOrWhiteSpace(txtApMaterno.Text) ||
                   string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                   string.IsNullOrWhiteSpace(txtcelular.Text) ||
                   (rbtmasculino.Checked == false && rbtfemenino.Checked == false) ||
                   string.IsNullOrWhiteSpace(datefNac.Text) ||
                   string.IsNullOrWhiteSpace(txtNomusuario.Text) ||
                   string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                   string.IsNullOrWhiteSpace(txtrepetirContra.Text) ||
                   cmbRol.SelectedIndex == -1;
        }

        private void CargarUsuarios()
        {
            dgvUsuario.DataSource = usuarioController.Listar();
            dgvUsuario.Columns["usuario"].Visible = false;
            dgvUsuario.Columns["contraseña"].Visible = false;
        }

        private void HabilitarCampos()
        {
            txtci.Enabled = true;  // Asegúrate de habilitar el campo CI
            txtNombre.Enabled = true;
            txtApPaterno.Enabled = true;
            txtApMaterno.Enabled = true;
            txtdireccion.Enabled = true;
            txtcelular.Enabled = true;
            rbtmasculino.Enabled = true;
            rbtfemenino.Enabled = true;
            datefNac.Enabled = true;
            txtNomusuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtrepetirContra.Enabled = true;
            cmbRol.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            txtci.Enabled = false;  // Aquí deshabilitas el campo CI
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
            txtdireccion.Enabled = false;
            txtcelular.Enabled = false;
            rbtmasculino.Enabled = false;
            rbtfemenino.Enabled = false;
            datefNac.Enabled = false;
            txtNomusuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtrepetirContra.Enabled = false;
            cmbRol.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtci.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtdireccion.Clear();
            txtcelular.Clear();
            rbtmasculino.Checked = false;
            rbtfemenino.Checked = false;
            datefNac.Checked = false;
            txtNomusuario.Clear();
            txtContrasena.Clear();
            txtrepetirContra.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametroBusqueda = txtBuscar.Text.Trim();

            var usuariosEncontrados = usuarioController.Buscar(parametroBusqueda);

            if (usuariosEncontrados.Any())
            {
                dgvUsuario.DataSource = usuariosEncontrados;
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios con el CI especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                int ci = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["ci"].Value);
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar al usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (usuarioController.EliminarUsuario(ci))
                    {
                        MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                txtci.Text = row.Cells["ci"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtApPaterno.Text = row.Cells["ap_paterno"].Value.ToString();
                txtApMaterno.Text = row.Cells["ap_materno"].Value.ToString();
                txtdireccion.Text = row.Cells["direccion"].Value.ToString();
                txtcelular.Text = row.Cells["celular"].Value.ToString();
                if (row.Cells["sexo"].Value.ToString() == "M")
                {
                    rbtmasculino.Checked = true;
                }
                else
                {
                    rbtfemenino.Checked = true;
                }
                datefNac.Value = DateTime.Parse(row.Cells["fecha_nac"].Value.ToString());
                txtNomusuario.Text = row.Cells["usuario"].Value.ToString();
                txtContrasena.Text = row.Cells["contraseña"].Value.ToString();
                cmbRol.Text = row.Cells["rol"].Value.ToString();

                HabilitarCampos();
                btnGuardar.Enabled = true;
                btnmodificar.Enabled = true;
                txtci.Enabled = true;  // Aquí deshabilitas el campo CI para evitar que se modifique accidentalmente
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string confirmarContraseña = txtrepetirContra.Text;
                if (txtContrasena.Text != confirmarContraseña)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                if (CamposVacios())
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                if (dgvUsuario.SelectedRows.Count > 0)
                {
                    int ci = int.Parse(txtci.Text);
                    string nombre = txtNombre.Text;
                    string apPaterno = txtApPaterno.Text;
                    string apMaterno = txtApMaterno.Text;
                    string direccion = txtdireccion.Text;
                    int celular = int.Parse(txtcelular.Text);
                    string sexo = (rbtmasculino.Checked == true) ? "M" : "F";
                    DateTime fechaNac = DateTime.Parse(datefNac.Text);

                    TRegistro registro = new TRegistro
                    {
                        ci = ci,
                        nombre = nombre,
                        ap_paterno = apPaterno,
                        ap_materno = apMaterno,
                        direccion = direccion,
                        celular = celular,
                        sexo = sexo,
                        fecha_nac = fechaNac
                    };

                    TUsuario usuario = new TUsuario
                    {
                        usuario = txtNomusuario.Text,
                        contraseña = txtContrasena.Text,
                        rol = cmbRol.Text
                    };

                    bool modificado = await usuarioController.ModificarUsuarioAsync(registro, usuario);

                    if (modificado)
                    {
                        MessageBox.Show("Usuario modificado con éxito.");
                        CargarUsuarios();
                        LimpiarCampos();
                        DeshabilitarCampos();
                        btnGuardar.Enabled = true;
                        btnmodificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al modificar el usuario: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
