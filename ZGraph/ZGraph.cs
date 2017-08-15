#region **引用**
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
#endregion

namespace Pengpai.UI              
{
    /// <summary>
    /// 波形显示控件
    /// 坐标最小差值：1.0
    /// </summary>
    public partial class ZGraph : UserControl
    { 
        /// <summary>
        /// 构造
        /// 初始化坐标值，坐标标定值，坐标标定权值
        /// </summary>
        public ZGraph()
        {
            InitializeComponent();
            //初始化默认坐标值，坐标标定值和坐标标定权值
            _fXBegin = _fXBeginGO = _fXBeginSYS;
            _fYBegin = _fYBeginGO = _fYBeginSYS;
            _fXEnd = _fXEndGO = _fXEndSYS;
            _fYEnd = _fYEndGO = _fYEndSYS;
            _fXQuanBeginGO = X_getQuan(_fXBeginGO);
            _fXQuanEndGO = X_getQuan(_fXEndGO);
            _fYQuanBeginGO = _getQuan(_fYBeginGO);
            _fYQuanEndGO = _getQuan(_fYEndGO);
        }

        private void 放大选取框功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
