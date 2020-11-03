using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designing_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            firstCustomerControl2.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            firstCustomerControl2.BringToFront();
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEatIn.Height;
            SidePanel.Top = btnEatIn.Top;
            mySecondCustomerControl2.BringToFront();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGallery.Height;
            SidePanel.Top = btnGallery.Top;
            myThreePanel1.BringToFront();

        }

        private void pbOnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void pbOnOff_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}