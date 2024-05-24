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
    public partial class frmestudiante : Form
    {
        public frmestudiante()
        {
            InitializeComponent();
        }

        private void btnestudiante_Click(object sender, EventArgs e)
        {
            frmRegistrarEst Registrar = new frmRegistrarEst();
            Registrar.Show();
        }
    }
}
