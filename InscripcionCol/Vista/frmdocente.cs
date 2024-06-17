using InscripcionCol.Controlador;
using InscripcionCol.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscripcionCol.Vista
{
    public partial class frmdocente : Form
    {
        private DocenteController docenteController;
        public frmdocente()
        {
            InitializeComponent();
            docenteController = new DocenteController();
        }

        private void frmdocente_Load(object sender, EventArgs e)
        {
            CargarDocentes();
            DeshabilitarCampos();
            btnmodificar.Visible = false;
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de entradas
                if (string.IsNullOrEmpty(txtci.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtApPaterno.Text) || string.IsNullOrEmpty(txtespecialidad.Text))
                    
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sexo = rbtmasculino.Checked ? "M" : (rbtfemenino.Checked ? "F" : string.Empty);
                if (string.IsNullOrEmpty(sexo))
                {
                    MessageBox.Show("Seleccione el sexo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                TRegistro registro = new TRegistro
                {


                    ci = Convert.ToInt32(txtci.Text),
                    nombre = txtNombre.Text,
                    ap_paterno = txtApPaterno.Text,
                    ap_materno = txtApMaterno.Text,
                    direccion = txtdireccion.Text,
                    celular = Convert.ToInt32(txtcelular.Text),
                    sexo = (rbtmasculino.Checked) ? "M" : "F",                  
                    
                    fecha_nac = DateTime.Parse(datefNacimiento.Text),
                    
                };

                TDocente docente = new TDocente
                {
                    especialidad = txtespecialidad.Text,
                    nivel_educativo = cmbNivelEducativo.Text,
                    grado_acad = cmbGradoAcademico.Text,
                    fec_contratacion = DateTime.Parse(dateContratacion.Text),
                    


            };

                bool docenteRegistrado = await docenteController.RegistrarDocenteAsync(registro);

                if (docenteRegistrado)
                {
                    docente.id_registro = registro.id_registro;
                    docente.especialidad = txtespecialidad.Text;
                    docente.grado_acad = cmbGradoAcademico.Text;
                    docente.fec_contratacion = dateContratacion.Value.Date;
                    docente.id_curso = Convert.ToInt32(cmbCurso.Text);

                    await docenteController.RegistrarDocAsync(docente);

                    MessageBox.Show("Docente guardado con éxito.");
                    CargarDocentes();
                    LimpiarCampos();
                    DeshabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el docente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un ERROR AL GUARDAR el docente: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDocentes()
        {
            dgvProfesor.DataSource = docenteController.Listar();
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
            datefNacimiento.Enabled = true;
            txtespecialidad.Enabled = true;
            cmbNivelEducativo.Enabled = true;
            cmbGradoAcademico.Enabled = true;
            dateContratacion.Enabled = true;
            cmbCurso.Enabled = true;
            
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
            datefNacimiento.Enabled = false;
            txtespecialidad.Enabled = false;
            cmbNivelEducativo.Enabled = false;
            cmbGradoAcademico.Enabled = false;
            dateContratacion.Enabled = false;
            cmbCurso.Enabled = false;
            
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
            datefNacimiento.Checked = false;
            txtespecialidad.Clear();
            cmbNivelEducativo.SelectedIndex = -1;
            cmbGradoAcademico.SelectedIndex = -1;
            dateContratacion.Checked = false;
            cmbCurso .SelectedIndex = -1;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarProfesor.Text, out int ci))
            {
                var docentesEncontrados = docenteController.Buscar(ci);

                if (docentesEncontrados.Any())
                {
                    dgvProfesor.DataSource = docentesEncontrados;
                }
                else
                {
                    MessageBox.Show("No se encontraron docentes con el CI especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un CI válido.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void asignarcurso()
        {
            TDocente docente = new TDocente();
            Random rnd = new Random();
            int minCurso, maxCurso;

            switch (Convert.ToInt32(cmbCurso.Text))
            {
                case 1:
                    minCurso = 1;
                    maxCurso = 5;
                    break;
                case 2:
                    minCurso = 6;
                    maxCurso = 10;
                    break;
                case 3:
                    minCurso = 11;
                    maxCurso = 15;
                    break;
                case 4:
                    minCurso = 16;
                    maxCurso = 20;
                    break;
                case 5:
                    minCurso = 21;
                    maxCurso = 25;
                    break;
                case 6:
                    minCurso = 26;
                    maxCurso = 30;
                    break;
                default:
                    throw new InvalidOperationException("Grado no válido");
            }

            docente.id_curso = rnd.Next(minCurso, maxCurso);
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.SelectedRows.Count > 0)
            {
                int ci = Convert.ToInt32(dgvProfesor.SelectedRows[0].Cells["ci"].Value);

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este docente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (docenteController.EliminarDocente(ci))
                    {
                        MessageBox.Show("Docente eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDocentes(); // Recargar los datos en el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un docente para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
    
}
