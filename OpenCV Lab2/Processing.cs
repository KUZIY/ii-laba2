using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace OpenCV_Lab2
{
    public static class Processing
    {
        public static Image<Bgr, byte> ProcessMatching(Image<Bgr, byte> imgScene, Image<Bgr, byte> ObjToFind, int method,double sens) 
        {
            Image<Bgr, byte> result = imgScene.Copy();
            Mat imgout = new Mat();
            CvInvoke.MatchTemplate(imgScene, ObjToFind, imgout, (Emgu.CV.CvEnum.TemplateMatchingType)method);
            double minVal = 0.0;
            double maxVal = 0.0;
            Point minLoc = new Point();
            Point maxLoc = new Point();
            CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            if (maxVal > sens)
            {
                Rectangle r = new Rectangle(maxLoc, ObjToFind.Size);
                CvInvoke.Rectangle(result, r, new MCvScalar(0, 0, 255), 3);
            }
            else CvInvoke.PutText(result, "Not Found", new Point(result.Width / 2 - result.Width / 4, result.Height / 2), FontFace.HersheySimplex, 2.8 , new MCvScalar(0,0,255),10);
            return result;
        }
    }
}
