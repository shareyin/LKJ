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
    public partial class Formqjzyfh : Form
    {
        public Formqjzy fqjzy;
        FormFuction ffuction = new FormFuction();
        public Formqjzyfh()
        {
            InitializeComponent();
            this.button1.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Enter += ffuction.btn_Enter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "zy";
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "zy";
            Dispose();
        }

        private void Formqjzyfh_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "zy2";
        }
    }
}
