using InscripcionCol.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscripcionCol
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void gestionarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuario frmUsuario = new frmusuario();
            frmUsuario.MdiParent = this;
            frmUsuario.WindowState = FormWindowState.Maximized;
            frmUsuario.Show();
        }

        private void gestionarEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void visualizarCuposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestudiante frmEstudiante = new frmestudiante();
            frmEstudiante.MdiParent = this;
            frmEstudiante.WindowState = FormWindowState.Maximized;
            frmEstudiante.Show();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        void salir()
        {
            if (MessageBox.Show("Estas seguro de cerrar la aplicacion?", "Cerrar aplicacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gestionarProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdocente frmdocente = new frmdocente();
            frmdocente.MdiParent = this;
            frmdocente.WindowState = FormWindowState.Maximized;
            frmdocente.Show();
        }

        private void gestionarBecasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtp frmBeca = new dtp();
            frmBeca.MdiParent = this;
            frmBeca.WindowState = FormWindowState.Maximized;
            frmBeca.Show();
        }

        private void visualizarCuposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcupo frmCupo = new frmcupo();
            frmCupo.Show();
        }
        private void frmmenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        public void CerrarSesion()
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la sesión actual?", "Cerrar sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                Application.Restart(); // Reiniciar la aplicación para mostrar el formulario de inicio de sesión
            }
        }
        private void btncerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmenuIni frmmenuIni = new frmmenuIni();
            frmmenuIni.MdiParent = this;
            frmmenuIni.WindowState = FormWindowState.Maximized;
            frmmenuIni.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreporte frmreporte = new frmreporte();
            frmreporte.MdiParent = this;
            frmreporte.WindowState = FormWindowState.Maximized;
            frmreporte.Show();
        }
    }
}
