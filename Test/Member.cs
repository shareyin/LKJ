using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class faceoutput
    {
        public static string g_sName = "";//人脸识别的姓名
        public static string g_sID = "";//人脸识别的ID编号  
        public static int g_iUsingType = 1;//录入模式为1，登陆模式为2
    }
    public class Ctrltype
    {
        public static bool IsfromZC = false;
        public static bool IsfromQJ = false;
        public static bool IsfromDC = false;
        
    }
    public class DrawingTitle
    {
        public static string g_sStartTitle = "正常监控";
    }

    public class FormOnMost
    {
        public static string g_sFormfocusmost = "0";
    }
}
