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
    public partial class Formsbzj : Form
    {
        public Formcx fcx;
        FormFuction ffuction = new FormFuction();
        public Formsbzj()
        {
            InitializeComponent();
            this.btnXHZJ1.Enter += ffuction.btn_Enter;
            this.btnCYZJ2.Leave += ffuction.btn_Leave;
            this.btnJJZJ3.Leave += ffuction.btn_Leave;
            this.btnJPZJ4.Leave += ffuction.btn_Leave;
            this.btnTSYCS5.Leave += ffuction.btn_Leave;
            this.btnQX0.Leave += ffuction.btn_Leave;

            this.btnXHZJ1.Leave += ffuction.btn_Leave;
            this.btnCYZJ2.Enter += ffuction.btn_Enter;
            this.btnJJZJ3.Leave += ffuction.btn_Leave;
            this.btnJPZJ4.Leave += ffuction.btn_Leave;
            this.btnTSYCS5.Leave += ffuction.btn_Leave;
            this.btnQX0.Leave += ffuction.btn_Leave;

            this.btnXHZJ1.Leave += ffuction.btn_Leave;
            this.btnCYZJ2.Leave += ffuction.btn_Leave;
            this.btnJJZJ3.Enter += ffuction.btn_Enter;
            this.btnJPZJ4.Leave += ffuction.btn_Leave;
            this.btnTSYCS5.Leave += ffuction.btn_Leave;
            this.btnQX0.Leave += ffuction.btn_Leave;

            this.btnXHZJ1.Leave += ffuction.btn_Leave;
            this.btnCYZJ2.Leave += ffuction.btn_Leave;
            this.btnJJZJ3.Leave += ffuction.btn_Leave;
            this.btnJPZJ4.Enter += ffuction.btn_Enter;
            this.btnTSYCS5.Leave += ffuction.btn_Leave;
            this.btnQX0.Leave += ffuction.btn_Leave;

            this.btnXHZJ1.Leave += ffuction.btn_Leave;
            this.btnCYZJ2.Leave += ffuction.btn_Leave;
            this.btnJJZJ3.Leave += ffuction.btn_Leave;
            this.btnJPZJ4.Leave += ffuction.btn_Leave;
            this.btnTSYCS5.Enter += ffuction.btn_Enter;
            this.btnQX0.Leave += ffuction.btn_Leave;

            this.btnXHZJ1.Leave += ffuction.btn_Leave;
            this.btnCYZJ2.Leave += ffuction.btn_Leave;
            this.btnJJZJ3.Leave += ffuction.btn_Leave;
            this.btnJPZJ4.Leave += ffuction.btn_Leave;
            this.btnTSYCS5.Leave += ffuction.btn_Leave;
            this.btnQX0.Enter += ffuction.btn_Enter;


        }

        private void btnXHZJ1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A is key");
        }

        private void btnXHZJ1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    btnXHZJ1_Click(null, null);
                    break;
                case Keys.B:
                    btnXHZJ1_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void Formsbzj_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("I 0");
        }

        private void btnQX0_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOnMost.g_sFormfocusmost = "cx";
        }

        private void btnQX0_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    btnQX0_Click(null, null);
                    break;
                case Keys.D0:
                    btnQX0_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
