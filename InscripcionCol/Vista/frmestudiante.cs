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

namespace InscripcionCol
{
    public partial class frmestudiante : Form
    {
        public frmestudiante()
        {
            InitializeComponent();
        }
        
        private void btnestudiante_Click(object sender, EventArgs e)
        {
            frmRegistrarEst Registrar = new frmRegistrarEst(this);
            Registrar.Show();
        }

        EstudianteController estudiante = new EstudianteController();
        public void cargar()
        {
            dgvEstudiante.DataSource = estudiante.Listar();
            dgvEstudiante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void frmestudiante_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
