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
    public partial class Formmsxz : Form
    {
        public FormTest formtest;
        FormFuction ffuction = new FormFuction();
        //Formmsxz fmsxz = new Formmsxz();
        public Formmsxz()
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();

        }

        private void Formmsxz_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
        }

        private void Formmsxz_KeyDown(object sender, KeyEventArgs e)
        {
            //if()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }

        private void Formmsxz_Load(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "ms";
        }
        //调车状态
        public  Formdczt fdczt;
        private void button3_Click(object sender, EventArgs e)
        {
            
            fdczt = new Formdczt();
            fdczt.Disposed += new EventHandler(fdczt_Disposed);
            fdczt.StartPosition = FormStartPosition.CenterScreen;
            fdczt.Show(this);
        }
        public void fdczt_Disposed(object sender, EventArgs e)
        {
            if(FormOnMost.g_sFormfocusmost=="0")
            {
                this.Dispose();
            }
            
        }
        //期间作业
        public Formqjzy fqjzy;
        private void button4_Click(object sender, EventArgs e)
        {
            fqjzy = new Formqjzy();
            fqjzy.Disposed += new EventHandler(fqjzy_Disposed);
            fqjzy.StartPosition = FormStartPosition.CenterScreen;
            fqjzy.Show(this);
        }
        public void  fqjzy_Disposed(object sender, EventArgs e)
        {
            if (FormOnMost.g_sFormfocusmost == "0")
            {
                this.Dispose();
            }
        }
        public void CloseAll()
        {
            button0_Click(null, null);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
        }
    }
}
