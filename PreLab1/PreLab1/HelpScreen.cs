using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab1
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
        }
        private void btn_About_Click(object sender, EventArgs e)
        {
            FormAboutUs formAboutUs = new FormAboutUs();
            formAboutUs.ShowDialog();
        }
    }
}
