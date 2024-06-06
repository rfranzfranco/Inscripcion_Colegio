using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Controlador;
using static System.Collections.Specialized.BitVector32;

namespace InscripcionCol
{
    public partial class frmInicioSesion : Form
    {
        private UsuarioController _usuarioController;
        private int intentosFallidos = 0; //Variable para contar los intentos fallidos 

        public frmInicioSesion()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void frmInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //bton de sesion
        public static class Sesion
        {
            private static string rolUsuarioActual;

            public static void IniciarSesion(string rol)
            {
                rolUsuarioActual = rol;
            }

            public static string ObtenerRol()
            {
                return rolUsuarioActual;
            }

            public static void CerrarSesion()
            {
                rolUsuarioActual = null;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtusuario.Text;
            var password = txtcontraseña.Text;

            if (username == "USUARIO" || password == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.");
                return;
            }

            var usuario = _usuarioController.Listar().FirstOrDefault(u => u.usuario == username && u.contraseña == password);

            if (usuario != null)
            {
                // Iniciar sesión y almacenar el rol del usuario actual
                Sesion.IniciarSesion(usuario.rol);

                this.Hide();
                frmcarga bienvenida = new frmcarga();
                bienvenida.ShowDialog();
                frmmenu menu = new frmmenu();
                menu.Show();
            }
            else
            {
                // Incrementar el contador de intentos fallidos y verificar el límite
                intentosFallidos++;
                if (intentosFallidos >= 3)
                {
                    // Mostrar mensaje de error y cerrar la aplicación después de 3 intentos fallidos
                    MessageBox.Show("Ha excedido el número máximo de intentos. El sistema se cerrará.");
                    Application.Exit();
                }
                else if (intentosFallidos == 1)
                {
                    // Mostrar mensaje de error indicando el primer intento fallido
                    MessageBox.Show("Usuario o contraseña incorrectos. Primer intento fallido.");
                }
                else if (intentosFallidos == 2)
                {
                    // Mostrar mensaje de error indicando el segundo intento fallido
                    MessageBox.Show("Usuario o contraseña incorrectos. Segundo intento fallido.");
                }
            }
        }
    }
}
