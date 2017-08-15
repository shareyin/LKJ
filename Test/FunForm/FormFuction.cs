using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.FunForm
{
    class FormFuction
    {
        public void btn_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = SystemColors.Control;
        }

        public void btn_Enter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        public void SetCtrltype(TextBox tb,int type,string outstring)
        {
            tb.Text = outstring;
            if(type==0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.ForeColor= System.Drawing.SystemColors.WindowFrame;
            }
            else if(type==1)
            {
                tb.BackColor = System.Drawing.SystemColors.Highlight;
                tb.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }
    }
}
