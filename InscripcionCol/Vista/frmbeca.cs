using InscripcionCol.Controlador;
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
    public partial class dtp : Form
    {
        public dtp()
        {
            InitializeComponent();
        }
        BecaController becaController = new BecaController();
        EstudianteViewModel estudiante;
        public void cargarBeca()
        {
            var becas = becaController.ListarBecas();
            dgvBeca.DataSource = becas;
            dgvBeca.Columns["Id_Beca"].Visible = false;
            dgvBeca.Columns["Id_Estudiante"].Visible = false;
            dgvBeca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void frmbeca_Load(object sender, EventArgs e)
        {
            cargarBeca();
            date_inicio.MinDate = new DateTime(2018, 1, 1);
            date_inicio.MaxDate = DateTime.Now;

            date_fin.MinDate = DateTime.Now;
            date_fin.MaxDate = new DateTime(2030, 12, 31);
            // Añadir los tipos de beca al ComboBox
            cbx_tipo.Items.AddRange(new string[] { "Académica", "Deportiva", "Cultural", "Socioeconomica", "Inclusión" });

            // Añadir el evento SelectedIndexChanged al ComboBox
            cbx_tipo.SelectedIndexChanged += cbx_tipo_SelectedIndexChanged;
            date_inicio.Value = date_inicio.MaxDate;
            date_fin.Value = date_fin.MaxDate;
        }
        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cbx_tipo.SelectedItem.ToString();
            decimal monto = becaController.ObtenerMontoPorTipo(tipoSeleccionado);
            txt_monto.Text = monto.ToString("F2");
        }
        private void btnAgregarBeca_Click(object sender, EventArgs e)
        {
            becaController.activargroupbox(gbxDatosBeca);
            txtBuscarCi.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarCi.Text = "";
            txt_appaterno.Text = "";
            txt_apmaterno.Text = "";
            txt_nombre.Text = "";
            cbx_tipo.Text = "";
            txt_monto.Text = "";
            date_inicio.Value=date_inicio.MaxDate;
            date_fin.Value = date_fin.MaxDate;
        }

        private void btnBuscar_ci_Click(object sender, EventArgs e)
        {
            int ci;
            if (int.TryParse(txtBuscarCi.Text, out ci))
            {
                estudiante = becaController.BuscarEstudiantePorCI(ci);

                if (estudiante != null)
                {
                    txt_appaterno.Text = estudiante.Ap_Paterno_E;
                    txt_apmaterno.Text = estudiante.Ap_Materno_E;
                    txt_nombre.Text = estudiante.Nombre_E;
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.");
                    txt_appaterno.Text = "";
                    txt_apmaterno.Text = "";
                    txt_nombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un CI válido.");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estudiante == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un estudiante primero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cbx_tipo.Text) || string.IsNullOrEmpty(txt_monto.Text) || date_inicio.Value == DateTime.MinValue || date_fin.Value == DateTime.MinValue)
            {
                MessageBox.Show("Existen campos vacíos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var beca = new BecaViewModel
                {
                    Tipo = cbx_tipo.Text,
                    Monto = Convert.ToDecimal(txt_monto.Text),
                    FechaIni = date_inicio.Value,
                    FechaFin = date_fin.Value,
                    Id_Estudiante = estudiante.Id_Estudiante
                };

                bool resultado = await becaController.RegistrarBecaAsync(beca);

                if (resultado)
                {
                    MessageBox.Show("Beca registrada exitosamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar_Click(sender, e);  // Limpiar campos después de guardar
                }
                else
                {
                    MessageBox.Show("Error al registrar la beca.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBeca.DataSource= becaController.BuscarBeca(txt_buscar.Text);
        }

        
    }
}
