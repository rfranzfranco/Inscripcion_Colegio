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
    public partial class frmcupo : Form
    {
        private EstudianteController _estudianteController = new EstudianteController();

        public frmcupo()
        {
            InitializeComponent();
        }               
        private async void frmcupo_Load(object sender, EventArgs e)
        {
            await CargarCuposDisponibles();
            CargarGrados();
            AjustarAnchoFormulario();
        }
        private async Task CargarCuposDisponibles()
        {
            var cupos = await _estudianteController.ObtenerCuposDisponiblesAsync();
            dgvCupo.DataSource = cupos;
        }
        private void CargarGrados()
        {
            using (var context = new RegistroColegioDBEntities())
            {
                var grados = context.TCurso.Select(c => c.grado).Distinct().ToList();
                cbxGrado.DataSource = grados;
                dgvCupo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private async void btnbuscarGrado_Click(object sender, EventArgs e)
        {
            if (cbxGrado.SelectedItem != null)
            {
                int gradoSeleccionado = (int)cbxGrado.SelectedItem;
                var cupos = await _estudianteController.ObtenerCuposDisponiblesPorGradoAsync(gradoSeleccionado);
                dgvCupo.DataSource = cupos;
                AjustarAnchoFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un grado.");
            }
        }
        private void AjustarAnchoFormulario()
        {
            int totalWidth = dgvCupo.RowHeadersWidth; // Ancho de los encabezados de fila

            // Sumar el ancho de todas las columnas visibles
            foreach (DataGridViewColumn column in dgvCupo.Columns)
            {
                if (column.Visible)
                {
                    totalWidth += column.Width;
                }
            }

            // Agregar márgenes si es necesario
            int margen = 40;
            this.Width = totalWidth + margen;

            // Opcional: Ajustar el tamaño del DataGridView para que coincida con el formulario
            dgvCupo.Width = totalWidth;
        }
        private void btncerrarcupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
