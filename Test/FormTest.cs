using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;
using facedetectfun;
using Test.FunForm;
using System.Data.OleDb;
//using Microsoft.Office.Core;
//using PowerPoint = Microsoft.Office.Interop.PowerPoint;
//using Graph = Microsoft.Office.Interop.Graph;
using System.Runtime.InteropServices;

namespace Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            f_saveReadFirst(false);
            f_reStyle();
        }
        //faceoutput fcoutput = new faceoutput();

        private Color[] m_colors;
        private float m_fstyle;
        private int[] m_istyle;
        /// <summary>
        /// 获取初始的波形显示控件的样式或设置为初始样式
        /// </summary>
        /// <param name="isRead">获取ture | 设置false</param>
        private void f_saveReadFirst(bool isRead)
        {
            if (!isRead)
            {
                m_colors = new Color[18];
                m_istyle = new int[2];
                m_istyle[0] = zGraphTest.m_titleSize;
                m_fstyle = zGraphTest.m_titlePosition;
                m_colors[0] = zGraphTest.m_titleColor;
                m_colors[1] = zGraphTest.m_titleBorderColor;
                m_colors[2] = zGraphTest.m_backColorL;
                m_colors[3] = zGraphTest.m_backColorH;
                m_colors[4] = zGraphTest.m_coordinateLineColor;
                m_colors[5] = zGraphTest.m_coordinateStringColor;
                m_colors[6] = zGraphTest.m_coordinateStringTitleColor;
                m_istyle[1] = zGraphTest.m_iLineShowColorAlpha;
                m_colors[7] = zGraphTest.m_iLineShowColor;
                m_colors[8] = zGraphTest.m_GraphBackColor;
                m_colors[9] = zGraphTest.m_ControlItemBackColor;
                m_colors[10] = zGraphTest.m_ControlButtonBackColor;
                m_colors[11] = zGraphTest.m_ControlButtonForeColorL;
                m_colors[12] = zGraphTest.m_ControlButtonForeColorH;
                m_colors[13] = zGraphTest.m_DirectionBackColor;
                m_colors[14] = zGraphTest.m_DirectionForeColor;
                m_colors[15] = zGraphTest.m_BigXYBackColor;
                m_colors[16] = zGraphTest.m_ShowNumBackColor;
                m_colors[17] = zGraphTest.m_ShowNumForeClor;
            }
            else
            {
                //样式
                //textBox标题字体大小.Text = m_istyle[0].ToString();
                zGraphTest.m_titleSize = m_istyle[0];
                //textBox标题位置.Text = m_fstyle.ToString();
                zGraphTest.m_titlePosition = m_fstyle;
                //zGraphTest.m_titleColor = button标题颜色.BackColor = m_colors[0];
                //zGraphTest.m_titleBorderColor = button标题描边颜色.BackColor = m_colors[1];
                //zGraphTest.m_backColorL = button背景色渐进起始颜色.BackColor = m_colors[2];
                //zGraphTest.m_backColorH = button背景色渐进终止颜色.BackColor = m_colors[3];
                //zGraphTest.m_coordinateLineColor = button坐标线颜色.BackColor = m_colors[4];
                //zGraphTest.m_coordinateStringColor = button坐标值颜色.BackColor = m_colors[5];
                //zGraphTest.m_coordinateStringTitleColor = button坐标标题颜色.BackColor = m_colors[6];
                //textBox网络线的透明度.Text = m_istyle[1].ToString();
                zGraphTest.m_iLineShowColorAlpha = m_istyle[1];
                //zGraphTest.m_iLineShowColor = button网络线的颜色.BackColor = m_colors[7];
                //zGraphTest.m_GraphBackColor = button波形显示区域背景色.BackColor = m_colors[8];
                //zGraphTest.m_ControlItemBackColor = button工具栏背景色.BackColor = m_colors[9];
                //zGraphTest.m_ControlButtonBackColor = button工具栏按钮背景色.BackColor = m_colors[10];
                //zGraphTest.m_ControlButtonForeColorL = button工具栏按钮前景选中颜色.BackColor = m_colors[11];
                //zGraphTest.m_ControlButtonForeColorH = button工具栏按钮前景未选中颜色.BackColor = m_colors[12];
                //zGraphTest.m_DirectionBackColor = button标签说明框背景颜色.BackColor = m_colors[13];
                //zGraphTest.m_DirectionForeColor = button标签说明框文字颜色.BackColor = m_colors[14];
                //zGraphTest.m_BigXYBackColor = button坐标显示框背景颜色.BackColor = m_colors[15];
                //zGraphTest.m_ShowNumBackColor = button坐标显示框字体颜色.BackColor = m_colors[16];
                //zGraphTest.m_ShowNumForeClor = button坐标显示框字体颜色.BackColor = m_colors[17];

            }
        }
        /// <summary>
        /// 获取波形显示控件基本属性和样式，并更新到该程序界面
        /// </summary>
        private void f_reStyle()
        {
            
        }

       





        #region **测试数据**
        public List<float> x1 = new List<float>();
        public List<float> y1 = new List<float>();
        public List<float> x2 = new List<float>();
        public List<float> y2 = new List<float>();
        public List<float> x3 = new List<float>();
        public List<float> y3 = new List<float>();
        public List<float> x4 = new List<float>();
        public List<float> y4 = new List<float>();
        public List<float> xd = new List<float>();
        public List<float> yd = new List<float>();
        #endregion

        private void button数据显示模拟1_Click(object sender, EventArgs e)
        {
            ///-300~num画四条数据
            button数据显示模拟1.Enabled = false;
            this.Focus();
            //int num;
            //textBox附加参数.Text = "";
            //if (int.TryParse(textBox数值.Text.ToString(), out num))
            //{
            //    if (num < -10000 || num > 10000)
            //    {
            //        num = 1580;
            //        textBox数值.Text = num.ToString();
            //    }
            //}
            //else
            //{
            //    num = 1580;
            //    textBox数值.Text = num.ToString();
            //}
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            x3.Clear();
            y3.Clear();
            x4.Clear();
            y4.Clear();
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix( x1,  y1, Color.Red, 2);
            zGraphTest.f_AddPix( x2,  y2, Color.Blue, 4);
            zGraphTest.f_AddPix( x3,  y3, Color.FromArgb(0, 128, 192), 2);
            zGraphTest.f_AddPix( x4,  y4, Color.Yellow, 4);
            zGraphTest.f_Refresh();
            button数据显示模拟1.Enabled = true;
        }

        private void button数据显示模拟2_Click(object sender, EventArgs e)
        {
            ///画三条数据[点|线|矩形条]
            button数据显示模拟2.Enabled = false;
            this.Focus();
            //textBox数值.Text = "";
            //textBox附加参数.Text = "";
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            x3.Clear();
            y3.Clear();
            for (int i = 0; i < 1200; i += 1)
            {
                x2.Add(i);
                y2.Add(83);
                //x2.Add(i);
                //y2.Add(i/2f);
                //x3.Add(i);
                //y3.Add(i *3/2f);
            }
            DataSet JiaoLu4;
            string s_Gongli = string.Format("{0}\\{1}", Application.StartupPath, "公里标.xls");
            JiaoLu4 = GetExcelData(s_Gongli, "4");
            string a = JiaoLu4.Tables[0].Rows[2][5].ToString();
            for (int k = 0; k < JiaoLu4.Tables[0].Rows.Count; k++)
            {
                if (JiaoLu4.Tables[0].Rows[k][2].ToString() == "" || JiaoLu4.Tables[0].Rows[k][2].ToString() == "无")
                {

                }
                else
                {
                    float xx = (float)(Convert.ToDouble(JiaoLu4.Tables[0].Rows[k][2].ToString()));
                    if (xx < 10)
                    { }
                    else
                    {
                        for (int i = 0; i < 80; i++)
                        {
                            x3.Add(xx);
                            y3.Add(i);
                            //x4.Add(0);
                            //y4.Add(83);
                            //zGraphTest.f_Refresh();
                        }
                    }

                }



            }
            //zGraphTest.f_ClearAllPix();
            //zGraphTest.f_reXY();
            zGraphTest.f_LoadOnePix(x2, y2, Color.Red, 2);
            //zGraphTest.f_AddPix(x2, y2, Color.Yellow, 5, LineJoin.Round, LineCap.Flat, Pengpai.UI.ZGraph.DrawStyle.dot);
            zGraphTest.f_AddPix(x3, y3, Color.FromArgb(0, 128, 192), 3, LineJoin.MiterClipped, LineCap.NoAnchor, Pengpai.UI.ZGraph.DrawStyle.bar);
            zGraphTest.f_Refresh();
            button数据显示模拟2.Enabled = true;
        }

        private void button数据显示模拟3_Click(object sender, EventArgs e)
        {
            ///模拟串口采样显示[周期k]
            button数据显示模拟3.Enabled = false;
            this.Focus();
            //zGraphTest.f_ClearAllPix();
            //zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            zGraphTest.f_LoadOnePix(x1, y1, Color.Red, 2);
            zGraphTest.f_AddPix(x2, y2, Color.Blue, 3);
            zGraphTest.f_AddPix(x3, y3, Color.FromArgb(0, 128, 192), 2);
            zGraphTest.f_AddPix(x4, y4, Color.Yellow, 3);

            f_timerDrawStart(); //开始TIMER
            //更新按钮显示，表示为正在采样
            button数据显示模拟3.Text += " 正在采样";
            button数据显示模拟3.TextAlign = ContentAlignment.MiddleLeft;
        }

        private float timerDrawI = 0;
        private void timerDraw_Tick(object sender, EventArgs e)
        {
            ///TIME增加数据
            x1.Add(timerDrawI);
            y1.Add(timerDrawI % 100);
            x2.Add(timerDrawI);
            y2.Add((float)Math.Sin(timerDrawI / 10f) * 200);
            x3.Add(timerDrawI);
            y3.Add(50);
            x4.Add(timerDrawI);
            y4.Add((float)Math.Sin(timerDrawI / 10) * 200);
            timerDrawI+=0.1f;
            zGraphTest.f_Refresh();
            //更新按钮显示，表示为正在采样
            button数据显示模拟3.Text += ".";
            if (button数据显示模拟3.Text.Length > 22)
            {
                button数据显示模拟3.Text = "模拟串口采样[周期k] 正在采样.";
            }
            
        }

        private void f_timerDrawStart()
        {
            timerDrawI = 0;
            timerDraw.Start();
            //textBox附加参数.ReadOnly = true;
            //textBox数值.ReadOnly = true;
            button数据显示模拟1.Enabled = false;
            button数据显示模拟2.Enabled = false;
            button数据显示模拟3.Enabled = false;
            button数据显示模拟5.Enabled = false;
            button数据显示模拟6.Enabled = false;
            button数据显示模拟7.Enabled = false;
        }

        private void f_timerDrawStop()
        {
            timerDraw.Stop();
            //textBox附加参数.ReadOnly = false;
            //textBox数值.ReadOnly = false;
            button数据显示模拟1.Enabled = true;
            button数据显示模拟2.Enabled = true;
            button数据显示模拟3.Enabled = true;
            button数据显示模拟5.Enabled = true;
            button数据显示模拟6.Enabled = true;
            button数据显示模拟7.Enabled = true;
            button数据显示模拟3.Text = "模拟串口采样[周期k]";
            button数据显示模拟3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button数据显示模拟4_Click(object sender, EventArgs e)
        {
            ///关闭TIMER
            button数据显示模拟4.Enabled = false;
            this.Focus();
            f_timerDrawStop();
            button数据显示模拟4.Enabled = true;
        }

        int listMaxCount = 100;//当列表里边的数据量大于listMaxCount时，填充文件，清空列表
        string filePath = null;
        private void button数据显示模拟5_Click(object sender, EventArgs e)
        {
            ///随机点的显示[周期k]
            button数据显示模拟5.Enabled = false;
            this.Focus();
            //pictureBox1.BackgroundImage = Image.FromFile(@"G:\CSproject\201706019M(vs2010版，去人脸识别)\Test\Signal\red.ico");
            //textBox数值.Text = "";
            //if (!int.TryParse(textBox附加参数.Text.ToString(), out listMaxCount))
            //{
            //    listMaxCount = 100;
            //}
            //textBox附加参数.Text = listMaxCount.ToString();

            f_timerRandomStart(); //开始TIMER
            //更新按钮显示，表示为正在采样
            button数据显示模拟5.Text += " 正在采样";
            button数据显示模拟5.TextAlign = ContentAlignment.MiddleLeft;

            ListCount = 0;

            // 把文件的路径指向程序的根目录下，可以根据自己的喜好修改牡蛎
            filePath = Process.GetCurrentProcess().MainModule.FileName;    
            int L = filePath.LastIndexOf('\\');
            filePath = filePath.Substring(0, L);
            filePath += "\\" + DateTime.Now.ToString(@"HH_mm_ss") + ".ini";

            //在指定的目录下创建一个文件
            FileStream fs = new FileStream(filePath, FileMode.CreateNew);
            fs.Close();

            xbar = 0;
            //x1.Clear();
            //y1.Clear();
            //zGraphTest.f_ClearAllPix();
            //zGraphTest.f_reXY();
            //设置初始化模式“按默认坐标范围平移”
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            //加载文件和链表
            zGraphTest.f_LoadOnePix(filePath, x1, y1, Color.Green,2);
        }

        Random rand = new Random();
        float xbar = 0;
        int ListCount=0;
        private void timerRandom_Tick(object sender, EventArgs e)
        {
            ListCount++;
            xbar += 0.001f;
            x1.Add(xbar);
            y1.Add((float)(70)); //只支持整数的文件储存，所以加载的数不能太小
            zGraphTest.f_Refresh();
            textBoxO.Text = "车速：" +((float)(100*rand.NextDouble())).ToString()+ " 公里：" + xbar.ToString();
            //if (ListCount >= listMaxCount)
            //{
            //    ListCount = 0;
            //    FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //    BinaryWriter bw = new BinaryWriter(fs);
            //    bw.BaseStream.Seek(0, SeekOrigin.Begin); // 数据流指针移到最后      
            //    for (int i = 0; i < x1.Count; i++)
            //    {
            //        int wx = (int)x1[i];         // 读取list数据储存到文件里边，注意是整数
            //        int wy = (int)y1[i];
            //        bw.Write(wx);
            //        bw.Write(wy);
            //    }
            //    bw.Close();                     // 关闭文件流                 
            //    fs.Close();

            //    x1.Clear();                     // 清空链表
            //    y1.Clear();
                
            //}

            //更新按钮显示，表示为正在采样
            button数据显示模拟5.Text += ".";
            if (button数据显示模拟5.Text.Length > 22)
            {
                button数据显示模拟5.Text = "采集并储存。正在采样.";
            }
        }

        private void button数据显示模拟6_Click(object sender, EventArgs e)
        {
            button数据显示模拟6.Enabled = false;
            this.Focus();
            f_timerRandomStop();
            button数据显示模拟6.Enabled = true;

            ListCount = 0;
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.BaseStream.Seek(0, SeekOrigin.End); // 数据流指针移到最后    
            if (x1.Count > 0)
            {                 
                for (int i = 0; i < x1.Count; i++)
                {
                    int wx = (int)x1[i];         // 读取list数据储存到文件里边  
                    int wy = (int)y1[i];
                    bw.Write(wx);
                    bw.Write(wy);
                }                              
                x1.Clear();
                y1.Clear();
            }
            long fileLen = fs.Length; 
            bw.Close();                     // 关闭文件流                 
            fs.Close();
            if (fileLen == 0)
            {                                         /* 文件里边数据偏少，则删除文件 */
                File.Delete(filePath);
            }
        }

        private void f_timerRandomStart()
        {
            timerRandom.Start();
            //textBox附加参数.ReadOnly = true;
            //textBox数值.ReadOnly = true;
            button数据显示模拟1.Enabled = false;
            button数据显示模拟2.Enabled = false;
            button数据显示模拟3.Enabled = false;
            button数据显示模拟4.Enabled = false;
            button数据显示模拟5.Enabled = false;
            button数据显示模拟7.Enabled = false;
        }

        private void f_timerRandomStop()
        {
            timerRandom.Stop();
            //textBox附加参数.ReadOnly = false;
            //textBox数值.ReadOnly = false;
            button数据显示模拟1.Enabled = true;
            button数据显示模拟2.Enabled = true;
            button数据显示模拟3.Enabled = true;
            button数据显示模拟4.Enabled = true;
            button数据显示模拟5.Enabled = true;
            button数据显示模拟7.Enabled = true;
            button数据显示模拟5.Text = "随机点的显示[周期k]";
            button数据显示模拟5.TextAlign = ContentAlignment.MiddleCenter;
        }

       

        private void button数据显示模拟7_Click(object sender, EventArgs e)
        {
            timerDraw.Stop();
            zGraphTest.f_ClearAllPix();
        }

        private void zGraphTest_DragEnter(object sender, DragEventArgs e)
        {
            zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.AutoMode);
            //把文件的路径添加进去
            zGraphTest.f_AddPix(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString(), Color.Red, 2);
            zGraphTest.Refresh();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.Now;
            string m_date = dt.Year.ToString("D4") + "-" + dt.Month.ToString("D2") + "-" + dt.Day.ToString("D2");
            string m_time = dt.Hour.ToString("D2") + ":" + dt.Minute.ToString("D2") + ":" + dt.Second.ToString("D2");
            labelDate.Text = m_date;
            labelTime.Text = m_time;
        }
        public TextBox GetName
        {
            set { tb_Name.Text = value.ToString(); }
            get { return tb_Name; }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            timerTime.Enabled = true;
            readconfig();
        }
        //数据库部分
        public string sql_dbname = "";
        public string sql_ip = "";
        public string sql_username = "";
        public string sql_password = "";
        //读取配置文件，数据库配置等信息存放在配置文件上
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private void readconfig()
        {
            StringBuilder temp = new StringBuilder();

            GetPrivateProfileString("SQLServer", "sql_dbname", "异常", temp, 255, AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.ini");
            sql_dbname = temp.ToString();
            GetPrivateProfileString("SQLServer", "sql_ip", "异常", temp, 255, AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.ini");
            sql_ip = temp.ToString();
            GetPrivateProfileString("SQLServer", "sql_username", "异常", temp, 255, AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.ini");
            sql_username = temp.ToString();
            GetPrivateProfileString("SQLServer", "sql_password", "异常", temp, 255, AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.ini");
            sql_password = temp.ToString();
        }
        //人脸识别
        private void btn_faceRec_Click(object sender, EventArgs e)
        {
            faceoutput.g_iUsingType = 1;
            faceDetect faceForm = new faceDetect();
            faceForm.formtest = this;
            faceForm.Show();
        }

        private void btnFaceLoad_Click(object sender, EventArgs e)
        {
            faceoutput.g_iUsingType = 2;
            faceDetect faceForm = new faceDetect();
            faceForm.formtest = this;
            faceForm.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        Formmsxz fmsxz;
        private void pb正常_Click(object sender, EventArgs e)
        {
            fmsxz = new Formmsxz();//模式选择
            FormOnMost.g_sFormfocusmost = "zc";
            fmsxz.formtest = this;
            fmsxz.StartPosition = FormStartPosition.CenterScreen;
            fmsxz.Show(this);

        }
        Formcx fcx;
        Formsbzj fsbzj = new Formsbzj();//设备自检
        
        
        
        private void pb查询_Click(object sender, EventArgs e)
        {
            fcx = new Formcx();//单击查询
            if (FormOnMost.g_sFormfocusmost=="0")
            {
                FormOnMost.g_sFormfocusmost = "cx";
                //fcx.formtest = this;
                fcx.StartPosition = FormStartPosition.CenterScreen;
                fcx.Show(this);
                
            }
            else
            {
                CheckTheForm();
                SendKeys.Send("{.}");
            }
            
        }

        private void pb确认_Click(object sender, EventArgs e)
        {
            // fcx.btnSBZJ_Click(null, null);
            CheckTheForm();
            SendKeys.Send("{Enter}");
            
        }

        private void pb向前_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{1}");
            }
            
        }
        //子窗体聚焦
        public void CheckTheForm()
        {
            switch (FormOnMost.g_sFormfocusmost)
            {
                case "cx":
                    fcx.Focus();
                    break;
                case "cx4":
                    fcx.fsbzkcx.Focus();
                    break;
                case "sd":
                    fcssd.Focus();
                    break;
                case "sd1":
                    fcssd.frgjs.Focus();
                    break;
                case "ms":
                    fmsxz.Focus();
                    break;
                case "dc":
                    fmsxz.fdczt.Focus();
                    break;
                case "zy":
                    fmsxz.fqjzy.Focus();
                    break;
                case "zy1":
                    fmsxz.fqjzy.fqjzyjr.Focus();
                    break;
                case "zy2":
                    fmsxz.fqjzy.fqjzyfh.Focus();
                    break;
                case "zy3":
                    fmsxz.fqjzy.fqjzyfp.Focus();
                    break;
                case "zy4":
                    fmsxz.fqjzy.fqjzybz.Focus();
                    break;
                case "fzc":
                    ffzcxcqr.Focus();
                    break;
                case "cx6":
                    fcx.fmsbzj.Focus();
                    break;
                default:
                    break;
            }
        }

        private void pb公里标_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{0}");
            }
        }

        private void pb上_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost == "sd" || FormOnMost.g_sFormfocusmost == "zy1"||FormOnMost.g_sFormfocusmost == "zy2" || FormOnMost.g_sFormfocusmost == "zy3" || FormOnMost.g_sFormfocusmost == "zy4")
            {
                SendKeys.Send("+{TAB}");
            }
            else if(FormOnMost.g_sFormfocusmost=="0")
            {

            }
            else
            {
                //SendKeys.Send("{UP}");
                SendKeys.Send("+{TAB}");
            }
            
            
        }

        private void pb下_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost == "sd" || FormOnMost.g_sFormfocusmost == "zy1" || FormOnMost.g_sFormfocusmost == "zy2" || FormOnMost.g_sFormfocusmost == "zy3" || FormOnMost.g_sFormfocusmost == "zy4")
            {
                SendKeys.Send("{TAB}");
            }
            else if(FormOnMost.g_sFormfocusmost == "0")
            {

            }
            else
            {
                //SendKeys.Send("{DOWN}");
                SendKeys.Send("{TAB}");
            }
            
        }

        private void pb左_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost == "sd")
            {
                //fcssd.LeftRightKey();
            }
            else
            {
                SendKeys.Send("{LEFT}");
            }
            
        }

        private void pb右_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost == "sd")
            {
                //fcssd.LeftRightKey();
            }
            else if(Formcssd.keyDownCount==-1)
            {
                SendKeys.Send("{RIGHT}");
            }
            
        }
        Formcssd fcssd;
        private void pb设定_Click(object sender, EventArgs e)
        {
            fcssd = new Formcssd();//参数设定
            FormOnMost.g_sFormfocusmost = "sd";
            //fcssd.Parent = this;
            fcssd.formtest = this;
            fcssd.StartPosition = FormStartPosition.CenterScreen;
            fcssd.Show(this);
        }

        private void pb查询_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }

        private void pb上_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }

        private void pb下_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }

        private void pb左_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }

        private void pb右_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }

        private void pb确认_MouseDown(object sender, MouseEventArgs e)
        {
            CheckTheForm();
        }
        public TextBox GZ
        {
            set
            {
                tbGZ.BackColor = value.BackColor;
                tbGZ.ForeColor = value.ForeColor;
                tbGZ.Text = value.ToString();
            }
            get { return tbGZ; }
            
        }
        public TextBox JJ
        {
            set
            {
                tbJJ = value;

            }
            get { return tbJJ; }
            
        }
        Formdczt fdczt;
        private void pb调车_Click(object sender, EventArgs e)
        {
            zGraphTest.m_sStartTitle= "调车模式";
            fdczt = new Formdczt();//调车状态
            FormOnMost.g_sFormfocusmost = "dc";
            fdczt.formtest = this;
            fdczt.StartPosition = FormStartPosition.CenterScreen;
            Ctrltype.IsfromDC = true;
            fdczt.Show(this);
            zGraphTest.f_Refresh();
        }
        private void pb模式_Click(object sender, EventArgs e)
        {
            if(FormOnMost.g_sFormfocusmost=="0")
            {
                fmsxz = new Formmsxz();//模式选择
                FormOnMost.g_sFormfocusmost = "ms";
                fmsxz.formtest = this;
                fmsxz.StartPosition = FormStartPosition.CenterScreen;
                fmsxz.Show(this);
            }
            else
            {
                CheckTheForm();
                if (FormOnMost.g_sFormfocusmost != "0")
                {
                    SendKeys.Send("{5}");
                }
            }
            
        }

        private void pb设定_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("补给");
        }
        //非正常行车
        Formfzcxcqr ffzcxcqr;
        private void pb上_DoubleClick(object sender, EventArgs e)
        {
            if (FormOnMost.g_sFormfocusmost == "0")
            {
                ffzcxcqr = new Formfzcxcqr();
                ffzcxcqr.StartPosition = FormStartPosition.CenterScreen;
                ffzcxcqr.Show(this);
            }
        }
        Formqjzy fqjzy;
        private void pb区间_Click(object sender, EventArgs e)
        {
            fqjzy = new Formqjzy();
            fqjzy.StartPosition = FormStartPosition.CenterScreen;
            Ctrltype.IsfromQJ = true;
            fqjzy.Show(this);
        }

        private void pb车位_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{3}");
            }
        }

        private void pb半自闭_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{2}");
            }
        }

        private void pb出站_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{4}");
            }
        }

        private void pb向后_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{6}");
            }
        }

        private void pb开车_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{7}");
            }
        }

        private void pb自动校正_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{8}");
            }
        }

        private void pb定标_Click(object sender, EventArgs e)
        {
            CheckTheForm();
            if (FormOnMost.g_sFormfocusmost != "0")
            {
                SendKeys.Send("{9}");
            }
            else
            {
                xd.Clear();
                yd.Clear();
                zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
                zGraphTest.f_AddPix(xd, yd, Color.FromArgb(0, 128, 192), 1, LineJoin.MiterClipped, LineCap.NoAnchor, Pengpai.UI.ZGraph.DrawStyle.bar);
                xd.Add((float)(6.123));
                yd.Add((float)0);

                zGraphTest.f_Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zGraphTest.f_ClearAllPix();
            //zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            //zGraphTest.f_LoadOnePix(x2, y2, Color.Green, 2);
            //for(int i=0;i<120;i++)
            //{
            //    x2.Add(i);
            //    y2.Add(48);
                
            //}
            zGraphTest.f_AddXiansuPix(x1,y1,Color.Red,2);
            //zGraphTest.f_AddPix(x4, y4, Color.Red, 1, LineJoin.MiterClipped, LineCap.NoAnchor, Pengpai.UI.ZGraph.DrawStyle.bar);
            x1.Add(0);
            y1.Add(83);
            x1.Add(1200);
            y1.Add(83);
            zGraphTest.f_Refresh();


        }
        //绘制基础图形部分.主要是公里标和限速曲线，底层是不变的，开车曲线在此基础上进行绘制。绘制之前需要清空以前的数据
        //输入为交路线路号，格式示例 4 表示4号交线
        public void PaintBaseData(string xianlu)
        {
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            DataSet JiaoLu;
            string s_Gongli = string.Format("{0}\\{1}", Application.StartupPath, "公里标.xls");
            JiaoLu = GetExcelData(s_Gongli, xianlu);
            for (int k = 0; k < JiaoLu.Tables[0].Rows.Count; k++)
            {
                if (JiaoLu.Tables[0].Rows[k][2].ToString() == "" || JiaoLu.Tables[0].Rows[k][2].ToString() == "无")
                {

                }
                else
                {
                    //车站代码
                    int m_iStateCode = Convert.ToInt32(JiaoLu.Tables[0].Rows[k][0].ToString());
                    //车站名称
                    string m_sStateName = JiaoLu.Tables[0].Rows[k][1].ToString();
                    //上行进站公里标
                    float xxin = (float)(Convert.ToDouble(JiaoLu.Tables[0].Rows[k][2].ToString()));
                    //上行出站公里标
                    float xxout = (float)(Convert.ToDouble(JiaoLu.Tables[0].Rows[k][3].ToString()));
                    //下行进站公里标
                    float xfin = (float)(Convert.ToDouble(JiaoLu.Tables[0].Rows[k][4].ToString()));
                    //下行出站公里标
                    float xfout = (float)(Convert.ToDouble(JiaoLu.Tables[0].Rows[k][5].ToString()));
                    if (xxin < 10)
                    { }
                    else
                    {
                        for (int i = 0; i < 80; i++)
                        {
                            //绘制进站公里标
                            x3.Add(xxin);
                            y3.Add(i);
                            //绘制出站公里标
                            x3.Add(xxout);
                            y3.Add(i);
                        }
                    }

                }
            }
            for (int t = 0; t < 2200; t++)
            {
                x4.Add(t);
                y4.Add(83);
            }
            zGraphTest.f_AddPix(x3, y3, Color.FromArgb(0, 128, 192), 1, LineJoin.MiterClipped, LineCap.NoAnchor, Pengpai.UI.ZGraph.DrawStyle.bar);

            zGraphTest.f_AddPix(x4, y4, Color.Red, 2);
            zGraphTest.f_Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //zGraphTest.f_ClearAllPix();
            //zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            //zGraphTest.f_AddXiansuPix(x4, y4, Color.Red, 2);
            

            
            DataSet JiaoLu4;
            string s_Gongli = string.Format("{0}\\{1}", Application.StartupPath, "公里标.xls");
            JiaoLu4 = GetExcelData(s_Gongli, "4");
            //string a = JiaoLu4.Tables[0].Rows[2][5].ToString();
            for (int k = 0; k < JiaoLu4.Tables[0].Rows.Count; k++)
            {
                if (JiaoLu4.Tables[0].Rows[k][2].ToString() == "" || JiaoLu4.Tables[0].Rows[k][2].ToString() == "无" || JiaoLu4.Tables[0].Rows[k][3].ToString() == "" || JiaoLu4.Tables[0].Rows[k][3].ToString() == "无" || JiaoLu4.Tables[0].Rows[k][4].ToString() == "" || JiaoLu4.Tables[0].Rows[k][4].ToString() == "无" || JiaoLu4.Tables[0].Rows[k][5].ToString() == "" || JiaoLu4.Tables[0].Rows[k][5].ToString() == "无")
                {

                }
                else
                {
                    int m_iStateCode = Convert.ToInt32(JiaoLu4.Tables[0].Rows[k][0].ToString());
                    string m_sStateName = JiaoLu4.Tables[0].Rows[k][1].ToString();
                    float xxin = (float)(Convert.ToDouble(JiaoLu4.Tables[0].Rows[k][2].ToString()));
                    float xxout = (float)(Convert.ToDouble(JiaoLu4.Tables[0].Rows[k][3].ToString()));
                    float xfin = (float)(Convert.ToDouble(JiaoLu4.Tables[0].Rows[k][4].ToString()));
                    float xfout = (float)(Convert.ToDouble(JiaoLu4.Tables[0].Rows[k][5].ToString()));
                    //if (xxin < 10)
                    //{ }
                    //else
                    //{
                    //    for (int i = 0; i < 80; i++)
                    //    {
                            x3.Add(xxin);
                            y3.Add(80);
                            //x4.Add(0);
                            //y4.Add(83);
                            //zGraphTest.f_Refresh();
                    //    }
                    //}
                    
                }
                
                
                
            }
            for (int t = 0; t < 2200; t++)
            {
                x4.Add(t);
                y4.Add(83);

            }
            zGraphTest.f_AddPix(x3, y3, Color.FromArgb(0, 128, 192), 1, LineJoin.MiterClipped, LineCap.NoAnchor, Pengpai.UI.ZGraph.DrawStyle.bar);

            zGraphTest.f_AddPix(x4, y4, Color.Red, 2);
            zGraphTest.f_Refresh();
            
            
        }
        public static DataSet ExcelDataHander(string str, string Jiaoxian,string strCom)
        {
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + str + ";" + "Extended Properties=Excel 8.0;";
            //string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
            OleDbConnection myConn = new OleDbConnection(strCon);
            //string strCom = " SELECT * FROM [" + Jiaoxian + "$]";
            myConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "[" + Jiaoxian + "$]");
            myConn.Close();
            return myDataSet;

        }
        public static DataSet GetExcelData(string str, string Jiaoxian)
        {
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + str + ";" + "Extended Properties=Excel 8.0;";
            //string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
            OleDbConnection myConn = new OleDbConnection(strCon);
            string strCom = " SELECT * FROM ["+Jiaoxian+"$]";
            myConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "["+Jiaoxian+"$]");
            myConn.Close();
            return myDataSet; 

        }


        private void button3_Click(object sender, EventArgs e)
        {
            zGraphTest._isMoveModeXY = true;
            zGraphTest._startMouse.X = 0;
            zGraphTest._startMouse.Y = 0;
            zGraphTest.ReChange(zGraphTest._startMouse.X +1, zGraphTest._startMouse.Y - 0);
            zGraphTest._startMouse.X = 1;
            zGraphTest._startMouse.Y = 0;
        }

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("changge");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}