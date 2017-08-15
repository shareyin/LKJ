using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Cuda;
using System.Diagnostics;
using Emgu.CV.UI;
using System.IO;
using Test;

namespace facedetectfun
{
    public partial class faceDetect : Form
    {
        //faceoutput fcout = new faceoutput();
        Mat matImg;//摄像头图像
        Capture capture;//摄像头对象
        public FormTest formtest;
        Util.KingFaceDetect kfd;
        public faceDetect()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            kfd = new Util.KingFaceDetect();
            try
            {
                capture = new Capture();
                capture.Start();//摄像头开始工作
                capture.ImageGrabbed += frameProcess;//实时获取图像
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            if (faceoutput.g_iUsingType == 1)
            {
                //button3.Visible = true;
                //button4.Visible = true;
                //获取样本图片.Visible = true;
                fullname.Enabled = true;
                获取样本图片.Text = "完成采集";
            }
            else
            {
                //button3.Visible = false;
                //button4.Visible = false;
                //获取样本图片.Visible = false;
                fullname.Enabled = false;
                获取样本图片.Text = "确认登陆";
            }
        }

        private void frameProcess(object sender, EventArgs arg)
        {
            matImg = new Mat();
            capture.Retrieve(matImg, 0);
            picShow.Image = matImg.Bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            markFaces();//100毫秒检测一次人脸
            if (faceoutput.g_sName != "")
            {
                sampleBox_Click(null, null);
                fullname.Text = faceoutput.g_sName;
                timer1.Enabled = false;

            }
        }
        private void markFaces()
        {
            try
            {
                picShow.Image = kfd.faceRecognize(capture.QueryFrame()).originalImg.Bitmap;
            }
            catch
            {
            }
        }

        private void 获取样本图片_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                MessageBox.Show("请输入样本姓名");
            }
            else if (获取样本图片.Text == "确认登陆")
            {
                MessageBox.Show("登陆成功！");
                formtest.GetName.Text = faceoutput.g_sName.ToString();
                this.Close();
                capture.Stop();
                //Application.Exit();
                //Environment.Exit(0);
                //this.environment.Exit(0);

            }
            else
            {
                string filePath = Application.StartupPath + "/trainedFaces/" + fullname.Text + "_" + System.Guid.NewGuid().ToString() + ".jpg";
                sampleBox.Image.Save(filePath);
                MessageBox.Show("样本保存完毕。");
            }
        }


        int currentFaceFlag = 0;
        Util.KingFaceDetect.faceDetectedObj currentfdo;//点击鼠标时的人脸检测对象
        private void sampleBox_Click(object sender, EventArgs e)
        {
            currentfdo = kfd.GetFaceRectangle(capture.QueryFrame());
            currentFaceFlag = 0;
            getCurrentFaceSample(0);
        }

        private void getCurrentFaceSample(int i)
        {
            try
            {
                fullname.Text = "";
                Image<Gray, byte> result = currentfdo.originalImg.ToImage<Gray, byte>().Copy(currentfdo.facesRectangle[i]).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                result._EqualizeHist();//灰度直方图均衡化
                sampleBox.Image = result.Bitmap;
            }
            catch(Exception)
            {
                timer1.Enabled = false;
                MessageBox.Show("未识别，请检测到后重试");
                timer1.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentFaceFlag == 0)
            {
                MessageBox.Show("已经是第一张");
            }
            else
            {
                currentFaceFlag--;
                
                getCurrentFaceSample(currentFaceFlag);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentFaceFlag == currentfdo.facesRectangle.Count-1)
            {
                MessageBox.Show("已经是最后一张");
            }
            else
            {
                currentFaceFlag++;
                getCurrentFaceSample(currentFaceFlag);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (recognizerType.Text)
            {
                case "EigenFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.EigenFaceRecognizer);
                    break;
                case "FisherFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.FisherFaceRecognizer);
                    break;
                case "LBPHFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.LBPHFaceRecognizer);
                    break;
            }
        }

        private void btnRDetect_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            faceoutput.g_sName = "";//清空
            fullname.Text = "";
            sampleBox.Image = null;
        }
    }
}
