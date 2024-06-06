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
        public void Imprimir(ComprobanteController compi)
        {
            doc.PrinterSettings.PrinterName=doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(ImprimeComprobante);
            vista.Document = doc;
            vista.Show();
            //doc.Print();
        }
        public void ImprimeComprobante(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            Font fuente = new Font("Arial", 12, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;
                e.Graphics.DrawImage(Logotipo, 15, 20, 100, 100);
                posY += 110;
                e.Graphics.DrawString(Colegio, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Direccion, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Telefono, fuente, Brushes.Black, posX, posY);
                posY += 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
