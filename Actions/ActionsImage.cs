using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitioEyes
{
    class ActionsImage : IActionsImage
    {
        public Bitmap LoadImage()
        {
            Bitmap LoadImage = null; 

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.bmp)|*.bmp|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadImage = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();

            return LoadImage;
        }

        public void SaveImage()
        {
            throw new NotImplementedException();
        }

    }
}
