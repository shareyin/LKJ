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
    public partial class Formqjzy : Form
    {
        FormFuction ffuction = new FormFuction();
        public Formqjzy()
        {
            InitializeComponent();
            this.button1.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Enter += ffuction.btn_Enter;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Enter += ffuction.btn_Enter;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Enter += ffuction.btn_Enter;
            this.button5.Leave += ffuction.btn_Leave;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Enter += ffuction.btn_Enter;
            this.button0.Leave += ffuction.btn_Leave;

            this.button1.Leave += ffuction.btn_Leave;
            this.button2.Leave += ffuction.btn_Leave;
            this.button4.Leave += ffuction.btn_Leave;
            this.button3.Leave += ffuction.btn_Leave;
            this.button5.Leave += ffuction.btn_Leave;
            this.button0.Enter += ffuction.btn_Enter;
        }
        //区间作业防碰
        public Formqjzyfp fqjzyfp;
        private void button3_Click(object sender, EventArgs e)
        {
            fqjzyfp = new Formqjzyfp();
            fqjzyfp.StartPosition = FormStartPosition.CenterScreen;
            fqjzyfp.Show(this);

        }
        //区间作业编组
        public Formqjzybz fqjzybz;
        private void button4_Click(object sender, EventArgs e)
        {
            fqjzybz = new Formqjzybz();
            fqjzybz.StartPosition = FormStartPosition.CenterScreen;
            fqjzybz.Show(this);

        }

        private void Formqjzy_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "zy";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(Ctrltype.IsfromQJ)
            {
                FormOnMost.g_sFormfocusmost = "0";
                Ctrltype.IsfromQJ = false;
                Dispose();
            }
            else
            {
                FormOnMost.g_sFormfocusmost = "ms";
                Dispose();
            }
            
        }
        //作业进入
        public Formqjzyjr fqjzyjr;
        private void button1_Click(object sender, EventArgs e)
        {
            fqjzyjr = new Formqjzyjr();
            fqjzyjr.StartPosition = FormStartPosition.CenterScreen;
            fqjzyjr.Show(this);

        }
        //作业返回
        public Formqjzyfh fqjzyfh;
        private void button2_Click(object sender, EventArgs e)
        {
            fqjzyfh = new Formqjzyfh();
            fqjzyfh.StartPosition = FormStartPosition.CenterScreen;
            fqjzyfh.Show(this);

        }

        private void Formqjzy_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
