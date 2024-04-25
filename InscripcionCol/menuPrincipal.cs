﻿using System;
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
            this.FormClosed += new FormClosedEventHandler(cerrarform);
        }
        private void cerrarform(object sender, EventArgs e)
        {
            frmInicioSesion iniciarnuevo= new frmInicioSesion();
            this.Hide();
            iniciarnuevo.ShowDialog();
        }
    }
}
