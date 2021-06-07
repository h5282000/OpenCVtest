using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
namespace OpenCvtest
{
    public partial class Form1 : Form
    {
        string Filepath = "";
        string Matchingpath = "";
        string Matchingfilename;
        Mat Result = new Mat();
        Mat Orignalimg = new Mat();
        Mat Matchingimg = new Mat();
        Mat Resizeimg = new Mat();


        public Form1()
        {
            InitializeComponent();
        }
        public void OrignalFileOpen()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "png";

            openFile.Filter = "Graphics interchange Format (*.png)|*.png|(*.jpg)|*.jpg|All files(*.*)|*.*";

            openFile.ShowDialog();

            if (openFile.FileName.Length > 0)
            {
                Image image1 = Image.FromFile(openFile.FileName);
                Filepath = openFile.FileName;
                Orignalimg = Cv2.ImRead(Filepath, ImreadModes.Grayscale);


                Cv2.GaussianBlur(Orignalimg, Orignalimg, new OpenCvSharp.Size(5, 5), 0); // 가우시안 블러 적용
//              Cv2.BilateralFilter(Orignalimg, Orignalimg, 9, 3, 3, BorderTypes.Default); //리사이즈 시  쌍방필터 적용
//              Cv2.MedianBlur(Orignalimg, Orignalimg, 15); // 리사이즈 시 메디안 블러 적용
//              Cv2.BoxFilter(Orignalimg, Orignalimg, MatType.CV_8UC1, new OpenCvSharp.Size(3, 3), new OpenCvSharp.Point(0, 0), true, BorderTypes.Default); //리사이즈 시 박스 필터 적용
//              Cv2.Blur(Orignalimg, Orignalimg, new OpenCvSharp.Size(3, 3)); // 리사이즈 시 단순 블러


                OrignalPic.SizeMode = PictureBoxSizeMode.StretchImage;
                OrignalPic.Image = image1;
            }
            else
                return;
        }
        public void TemplateFileOpen()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "png";

            openFile.Filter = "Graphics interchange Format (*.png)|*.png|(*.jpg)|*.jpg|All files(*.*)|*.*";

            openFile.ShowDialog();

            if (openFile.FileName.Length > 0)
            {
                Image image1 = Image.FromFile(openFile.FileName);
                Filepath = openFile.FileName;
                Matchingimg = Cv2.ImRead(Filepath, ImreadModes.Grayscale);
                MatchingPic.SizeMode = PictureBoxSizeMode.StretchImage;
                MatchingPic.Image = image1;
            }
            else
                return;
        }

        public void Matching()
        {
            var threshold = 0.8; // 유사도 설정


            Cv2.Resize(Matchingimg, Resizeimg, new OpenCvSharp.Size(Convert.ToDouble(Orignalimg.Width) * (Convert.ToDouble(100)/ Convert.ToDouble(125)), Convert.ToDouble(Orignalimg.Height) * (Convert.ToDouble(100)/ Convert.ToDouble(125)))); // 리사이즈 테스트 0.8배율
            Cv2.GaussianBlur(Resizeimg, Resizeimg, new OpenCvSharp.Size(5, 5), 0); // 리사이즈 시 가우시안 블러 적용
//          Cv2.BilateralFilter(Resizeimg, Resizeimg, 9, 3, 3, BorderTypes.Default); //리사이즈 시  쌍방필터 적용
//          Cv2.MedianBlur(Resizeimg, Resizeimg, 15); // 리사이즈 시 메디안 블러 적용
//          Cv2.BoxFilter(Resizeimg, Resizeimg, MatType.CV_8UC1, new OpenCvSharp.Size(3, 3), new OpenCvSharp.Point(0, 0), true, BorderTypes.Default); //리사이즈 시 박스 필터 적용
//          Cv2.Blur(Resizeimg, Resizeimg, new OpenCvSharp.Size(3, 3)); // 리사이즈 시 단순 블러
            Cv2.MatchTemplate(Orignalimg, Resizeimg, Result, TemplateMatchModes.CCoeffNormed); // 리사이즈 시 탬플릿 매칭


//            Cv2.MatchTemplate(Orignalimg, Matchingimg, Result, TemplateMatchModes.CCoeffNormed); // 기본 탬플릿 매칭


            double minval, maxval;
            OpenCvSharp.Point minloc, maxloc;

            Cv2.MinMaxLoc(Result, out minval, out maxval, out minloc, out maxloc);
            ther.Text = maxval.ToString();
            if (maxval >= threshold)
            {
                Rect rect = new Rect(maxloc.X, maxloc.Y, Resizeimg.Width, Resizeimg.Height); // 리사이즈 시 사각형 생성

//              Rect rect = new Rect(maxloc.X, maxloc.Y, Matchingimg.Width, Matchingimg.Height);

                Cv2.Rectangle(Orignalimg, rect, Scalar.Red, 1);
                Cv2.Rectangle(Result, rect, new OpenCvSharp.Scalar(0, 0, 255), 1);
                OrignalPic.ImageIpl = Orignalimg;
            }
            MatchingPic.ImageIpl = Resizeimg; // 리사이즈 시 해당 이미지 변경
//          MatchingPic.ImageIpl = Matchingimg;

        }

        private void imgupload_Click(object sender, EventArgs e) // 원본 이미지
        {
            OrignalFileOpen();
        }

        private void button2_Click(object sender, EventArgs e) // 잘라낸 이미지
        {
            TemplateFileOpen();
        }

        private void button3_Click(object sender, EventArgs e) // 매칭
        {
            Matching();
        }
    }
}
