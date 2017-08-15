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
    public partial class Form1 : Form
    {
        public FormTest formtest;
        FormFuction ffuction = new FormFuction();
        public Form1()
        {
            InitializeComponent();
            this.button1.Enter += ffuction.btn_Enter;
            this.button1.Leave += ffuction.btn_Leave;

            this.button2.Enter += ffuction.btn_Enter;
            this.button2.Leave += ffuction.btn_Leave;
        }
    }
}
