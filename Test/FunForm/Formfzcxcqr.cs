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
    public partial class Formfzcxcqr : Form
    {
        FormFuction ffuction = new FormFuction();
        public Formfzcxcqr()
        {
            InitializeComponent();
            this.button1.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Enter += ffuction.btn_Enter;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Enter += ffuction.btn_Enter;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Enter += ffuction.btn_Enter;
            this.button5.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Enter += ffuction.btn_Enter;
        }

        private void Formfzcxcqr_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "fzc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("禁止操作");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("禁止操作");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("禁止操作");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }
    }
}
