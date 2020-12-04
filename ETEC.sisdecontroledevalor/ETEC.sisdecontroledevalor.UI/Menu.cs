using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEC.sisdecontroledevalor.UI
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            slides1.BringToFront();
        }

        private void btnCadpro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCadpro.Height;
            SidePanel.Top = btnCadpro.Top;
            usContr1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            slides1.BringToFront();
            
        }

        private void btnTelvl_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTelvl.Height;
            SidePanel.Top = btnTelvl.Top;
            gRvalorlucro1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
