using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class oewu : Form
    {
        public oewu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignInPage label1 = new SignInPage();
            label1.Show();
        }
    }
}
