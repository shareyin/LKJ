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
    public partial class Formcssd : Form
    {
        public FormTest formtest;
        FormFuction ffuction = new FormFuction();
        public Formcssd()
        {
            InitializeComponent();
            this.btnFH0.Enter += ffuction.btn_Enter;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Enter += ffuction.btn_Enter;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Enter += ffuction.btn_Enter;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Enter += ffuction.btn_Enter;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Enter += ffuction.btn_Enter;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Enter += ffuction.btn_Enter;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Enter += ffuction.btn_Enter;
            this.btnLSXS1.Leave += ffuction.btn_Leave;

            this.btnFH0.Leave += ffuction.btn_Leave;
            this.btnQR7.Leave += ffuction.btn_Leave;
            this.btnSJ6.Leave += ffuction.btn_Leave;
            this.btnXT5.Leave += ffuction.btn_Leave;
            this.btnGL4.Leave += ffuction.btn_Leave;
            this.btnXHDL3.Leave += ffuction.btn_Leave;
            this.btnLCDL2.Leave += ffuction.btn_Leave;
            this.btnLSXS1.Enter += ffuction.btn_Enter;

            input6.Enter+=new EventHandler(input6_Enter);
            input4.Enter+=new EventHandler(input4_Enter);
        }
        public void input6_Enter(object sender, EventArgs e)
        {
            label14.Text = "提示：当前交线为" + input6.Text;
        }
        public void input4_Enter(object sender, EventArgs e)
        {
            label14.Text = "提示：0-本务，1-补务";
            input4.DroppedDown = true;
            
        }

        public static int keyDownCount = -1;
        public void LeftRightKey()
        {
            if (keyDownCount == 0)
            {
                btnFH0.Focus();
            }
            keyDownCount = -1;
        }

        private void Formcssd_Load(object sender, EventArgs e)
        {
            keyDownCount = 0;
        }

        public Formrgjs frgjs;
        private void btnLSXS1_Click(object sender, EventArgs e)
        {
            frgjs = new Formrgjs();
            frgjs.fcssd = this;
            frgjs.StartPosition = FormStartPosition.CenterScreen;
            frgjs.Show(this);
        }

        private void btnQR7_Click(object sender, EventArgs e)
        {
            //
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
            //Close();

        }
        
        private void btnFH0_Click(object sender, EventArgs e)
        {
            FormOnMost.g_sFormfocusmost = "0";
            Dispose();
            //Close();
            
        }
        //管理
        public Formglcssr fglcssr;
        private void btnGL4_Click(object sender, EventArgs e)
        {
            fglcssr = new Formglcssr();
            fglcssr.StartPosition = FormStartPosition.CenterScreen;
            fglcssr.Show(this);

        }

        private void btnXT5_Click(object sender, EventArgs e)
        {

        }
        //时间
        public Formsjsz fsjsz;
        private void btnSJ6_Click(object sender, EventArgs e)
        {
            fsjsz = new Formsjsz();
            fsjsz.StartPosition = FormStartPosition.CenterScreen;
            fsjsz.Show(this);
        }

        private void input4_KeyDown(object sender, KeyEventArgs e)
        {
            //switch(e.KeyCode)
            //{
            //    case:
            //        break;
            //}
                
        }
    }
}
