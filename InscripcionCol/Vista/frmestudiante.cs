﻿using System;
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
        
        public frmestudiante()
        {
            InitializeComponent();
            
        }
        EstudianteController estudianteController = new EstudianteController();
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
            frmRegistrarEst frmRegistrar = new frmRegistrarEst(this);
            frmRegistrar.Show();
        }
    }
}
