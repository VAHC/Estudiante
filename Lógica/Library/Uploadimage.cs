using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lógica.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public void CargarImagen(PictureBox pictureBox)
        {
            // Establecer la propiedad  de WaitOnLoad a true significa que la imagen
            // se carga de forma sincrónica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
