using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Controlador;
using InscripcionCol.Vista;

namespace InscripcionCol
{
    public partial class frmestudiante : Form
    {
        EstudianteController estudianteController = new EstudianteController();
        public frmestudiante()
        {
            InitializeComponent();            
        }        
        private void btnestudiante_Click(object sender, EventArgs e)
        {
            MostrarFormularioRegistrarEstudiante();
        }
        private void MostrarFormularioRegistrarEstudiante()
        {
            var formularioRegistrarEst = new frmRegistrarEst(this, estudianteController);
            formularioRegistrarEst.Show();
        }

        private void MostrarFormularioModificarEstudiante(EstudianteViewModel estudianteSeleccionado)
        {
            var formularioRegistrarEst = new frmRegistrarEst(this, estudianteSeleccionado, estudianteController);
            formularioRegistrarEst.Show();
        }
        EstudianteController estudiante = new EstudianteController();
        public void cargar()
        {
            var estudiantes = estudiante.Listar();
            dgvEstudiante.DataSource = estudiantes;
            // Ocultar la columna de Id_Estudiante
            dgvEstudiante.Columns["Id_Estudiante"].Visible = false;
            dgvEstudiante.Columns["Complemento"].Visible = false;
            dgvEstudiante.Columns["Expedido"].Visible = false;
            dgvEstudiante.Columns["Pais"].Visible = false;
            dgvEstudiante.Columns["Departamento"].Visible = false;
            dgvEstudiante.Columns["Provincia"].Visible = false;
            dgvEstudiante.Columns["Localidad"].Visible = false;
            dgvEstudiante.Columns["sexo"].Visible = false;
            dgvEstudiante.Columns["NumeroViviendaActual"].Visible = false;
            dgvEstudiante.Columns["DepartamentoActual"].Visible = false;
            dgvEstudiante.Columns["ProvinciaActual"].Visible = false;
            dgvEstudiante.Columns["MunicipioActual"].Visible = false;
            dgvEstudiante.Columns["LocalidadActual"].Visible = false;
            dgvEstudiante.Columns["ZonaActual"].Visible = false;
            dgvEstudiante.Columns["AvenidaActual"].Visible = false;
            dgvEstudiante.Columns["ComplementoTutor"].Visible = false;
            dgvEstudiante.Columns["ExpedidoTutor"].Visible = false;
            dgvEstudiante.Columns["DepartamentoComprobante"].Visible = false;
            dgvEstudiante.Columns["FechaRegistroComprobante"].Visible = false;
            dgvEstudiante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void frmestudiante_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBuscarEst_Click(object sender, EventArgs e)
        {
            dgvEstudiante.DataSource = estudianteController.Buscar(txtBuscarEst.Text);
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            frmcomprobante frmComprobante=new frmcomprobante();
            frmComprobante.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.SelectedRows.Count > 0)
            {
                var selectedRow = dgvEstudiante.SelectedRows[0];
                var estudianteSeleccionado = (EstudianteViewModel)selectedRow.DataBoundItem;
                MostrarFormularioModificarEstudiante(estudianteSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para modificar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.SelectedRows.Count > 0)
            {
                int idEstudiante = Convert.ToInt32(dgvEstudiante.SelectedRows[0].Cells["Id_Estudiante"].Value);
                if (estudianteController.EliminarEstudiante(idEstudiante))
                {
                    MessageBox.Show("Estudiante eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar(); // Recargar los datos en el DataGridView
                }
                else
                {
                    MessageBox.Show("Error al eliminar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
