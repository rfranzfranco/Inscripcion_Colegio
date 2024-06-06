using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace InscripcionCol.Controlador
{
    public class ComprobanteController
    {
        public string Colegio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Image Logotipo { get; set; }
        private PrintDocument doc=new PrintDocument();
        private PrintPreviewDialog vista= new PrintPreviewDialog();
        public List<ComprobanteViewModel> ListarCompEst { get; set; } = new List<ComprobanteViewModel>();
        public void Imprimir()
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(ImprimeComprobante);
            vista.Document = doc;
            vista.ShowDialog();
            //doc.Print();
        }
        public void ImprimeComprobante(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            int margenIzquierdo = 50; // Ajusta esto según sea necesario
            Font fuenteControl = new Font("Arial", 10);
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteContenido = new Font("Arial", 14);
            Font fuentePie = new Font("Arial", 10, FontStyle.Italic);
            StringFormat formatoCentro = new StringFormat();
            formatoCentro.Alignment = StringAlignment.Center;
            formatoCentro.LineAlignment = StringAlignment.Center;

            try
            {
                posX = 250;
                posY = 10;
                e.Graphics.DrawImage(Logotipo,10, 20, 100, 100);
                // Imprimir fecha y hora en la parte superior derecha
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                string hora = DateTime.Now.ToString("HH:mm");
                e.Graphics.DrawString("Fecha: " + fecha, fuenteContenido, Brushes.Black, e.PageBounds.Width - 200, 30);
                e.Graphics.DrawString("Hora: " + hora, fuenteContenido, Brushes.Black, e.PageBounds.Width - 200, 50);

                posY += 110;
                e.Graphics.DrawString(Colegio, fuenteControl, Brushes.Black, 10, posY);
                posY += 20;
                e.Graphics.DrawString(Direccion, fuenteControl, Brushes.Black, 10, posY);
                posY += 20;
                e.Graphics.DrawString(Telefono, fuenteControl, Brushes.Black, 10, posY);
                posY += 50;
                e.Graphics.DrawString("COMPROBANTE DE INSCRIPCION", fuenteTitulo, Brushes.Black, e.PageBounds.Width / 2, posY, formatoCentro);
                posY += 60;

                foreach (var estudiante in ListarCompEst)
                {
                    e.Graphics.DrawString("CI: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.CI_estudiante, fuenteContenido, Brushes.Black, posX+200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Código RUDE: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.RUDE, fuenteContenido, Brushes.Black, posX+200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Apellido Paterno: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.ap_paterno, fuenteContenido, Brushes.Black, posX+200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Apellido Materno: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.ap_materno, fuenteContenido, Brushes.Black, posX+200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Nombre: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.Nombre, fuenteContenido, Brushes.Black, posX + 200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Grado: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.grado, fuenteContenido, Brushes.Black, posX + 200, posY);
                    posY += 30;
                    e.Graphics.DrawString("Paralelo: ", fuenteTitulo, Brushes.Black, posX, posY);
                    e.Graphics.DrawString(" " + estudiante.paralelo, fuenteContenido, Brushes.Black, posX + 200, posY);
                    posY += 40; // Espacio adicional antes del siguiente estudiante
                }
                // Espacio adicional antes de las firmas
                posY += 30;

                // Imprimir secciones de firma
                e.Graphics.DrawString("Elaborado por: ___________________", fuenteContenido, Brushes.Black, margenIzquierdo, posY);                
                e.Graphics.DrawString("Recibi Conforme: ___________________", fuenteContenido, Brushes.Black, margenIzquierdo+400, posY);
                posY += 80; // Espacio adicional antes del mensaje general

                // Imprimir mensaje general del comprobante
                string mensajeGeneral = "Este es un comprobante de inscripción de la U.E. Donato Vásquez. Guarde este documento para futuros trámites.";
                e.Graphics.DrawString(mensajeGeneral, fuentePie, Brushes.Black, 50, posY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
