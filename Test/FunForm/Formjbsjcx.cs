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
    public partial class Formjbsjcx : Form
    {
        FormFuction ffuction = new FormFuction();
        public Formjbsjcx()
        {
            InitializeComponent();
            this.button1.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Enter += ffuction.btn_Enter;
            this.button3.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button3.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
            this.button1.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button0.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button1.Leave += ffuction.btn_Leave;
        }

        private void Formjbsjcx_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "cx9";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "cx";
            Dispose();
        }
    }
}
