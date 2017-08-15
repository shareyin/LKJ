using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.FunForm
{
    public partial class Formsbzkcx : Form
    {
        public Formcx fcx;
        public Formsbzkcx()
        {
            InitializeComponent();
        }

        private void Formsbzkcx_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "cx4";
            this.Focus();
        }

        private void Formsbzkcx_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    FormOnMost.g_sFormfocusmost = "cx";
                    Dispose();
                    break;
                default:
                    break;
            }
        }
    }
}
