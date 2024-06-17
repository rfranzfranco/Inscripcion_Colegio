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
            VerificarRolUsuarioActual();
        }

        private void VerificarRolUsuarioActual()
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
        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposVacios())
                {
                    MessageBox.Show("Faltan datos por llenar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ConfirmarContraseña = txtrepetirContra.Text;
                if (txtContrasena.Text != ConfirmarContraseña)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                TRegistro registro = new TRegistro
                {
                    ci = int.Parse(txtci.Text),
                    nombre = txtNombre.Text,
                    ap_paterno = txtApPaterno.Text,
                    ap_materno = txtApMaterno.Text,
                    direccion = txtdireccion.Text,
                    celular = int.Parse(txtcelular.Text),
                    sexo = (rbtmasculino.Checked == true) ? "M" : "F",
                    fecha_nac = DateTime.Parse(datefNac.Text),
                };

                TUsuario usuario = new TUsuario
                {
                    usuario = txtNomusuario.Text,
                    contraseña = txtContrasena.Text,
                    rol = cmbRol.Text
                };
                bool registrado = await usuarioController.RegistrarUsuarioAsync(registro, usuario);

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
                MessageBox.Show($"Ha ocurrido un error al guardar el usuario: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CamposVacios()
        {
            //se modifica para el bton modificar
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
                   //  string.IsNullOrWhiteSpace(cmbRol.Text);
                   cmbRol.SelectedIndex == -1;
        }
        private void CargarUsuarios()
        {
            dgvUsuario.DataSource = usuarioController.Listar();
            dgvUsuario.Columns["id_registro"].Visible = false;
            dgvUsuario.Columns["usuario"].Visible = false;
            dgvUsuario.Columns["contraseña"].Visible = false;
        }

        private void HabilitarCampos()
        {
            txtci.Enabled = true;
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
            txtci.Enabled = false;
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
            cmbRol.SelectedIndex = -1;  // Restablece la selección
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametroBusqueda = txtBuscar.Text.Trim();

            // Realizar la búsqueda y actualizar el DataGridView
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

                if (usuarioController.EliminarUsuario(ci))
                {
                    MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios(); // Recargar los datos en el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            // Aquí iría la lógica para modificar un usuario
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

                TRegistro registro = new TRegistro
                {
                    ci = int.Parse(txtci.Text),
                    nombre = txtNombre.Text,
                    ap_paterno = txtApPaterno.Text,
                    ap_materno = txtApMaterno.Text,
                    direccion = txtdireccion.Text,
                    celular = int.Parse(txtcelular.Text),
                    sexo = (rbtmasculino.Checked == true) ? "M" : "F",
                    fecha_nac = DateTime.Parse(datefNac.Text)
                };

                TUsuario usuario = new TUsuario
                {
                    id_registro = (int)dgvUsuario.SelectedRows[0].Cells["id_registro"].Value,
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al modificar el usuario: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

