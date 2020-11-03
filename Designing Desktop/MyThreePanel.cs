using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designing_Desktop
{
    public partial class MyThreePanel : UserControl
    {
        public MyThreePanel()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 8)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"ImageGallery\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
