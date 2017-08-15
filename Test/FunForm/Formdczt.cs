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
    public partial class Formdczt : Form
    {
        public FormTest formtest;
        public Formmsxz fmsxz;
        FormFuction ffuction = new FormFuction();
        public Formdczt()
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

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button3.Enter += ffuction.btn_Enter;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button0.Enter += ffuction.btn_Enter;
        }

        private void Formdczt_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "dc";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(Ctrltype.IsfromDC)
            {
                FormOnMost.g_sFormfocusmost = "0";
                Ctrltype.IsfromDC = false;
                Dispose();
            }
            else
            {
                FormOnMost.g_sFormfocusmost = "ms";
                Dispose();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }
    }
}
