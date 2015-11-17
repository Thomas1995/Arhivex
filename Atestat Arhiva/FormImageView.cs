using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Arhiva
{
    public partial class FormImageView : Form
    {
        public FormImageView(Image mainImage)
        {
            InitializeComponent();

            this.Height = mainImage.Height;
            this.Width = mainImage.Width;
            pbImage.BackgroundImage = mainImage;
        }

        private void pbImage_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
