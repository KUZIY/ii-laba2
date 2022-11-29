using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_Lab2
{
    public partial class LWForm : Form
    {
        int _method = 5;
        int _sense = 30;
        Image<Bgr, byte> scene = null;
        Image<Bgr, byte> ObjToFind = null;
        Image<Bgr, byte> Result = null;
        Stopwatch timer = new Stopwatch();
        Mat mat;
        VideoCapture cv = new VideoCapture();
        bool locker = false;
        public LWForm()
        {
            InitializeComponent();
        }
        private void buttonVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoImageFile.Checked)
                {
                    try
                    {
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        locker = false;
                        this.Refresh();
                        GC.Collect();
                        return;
                    }
                    ImageBoxResult.Image = Processing.ProcessMatching(scene, ObjToFind, _method, _sense / 100.0).Resize(ImageBoxResult.Width, ImageBoxResult.Height, Emgu.CV.CvEnum.Inter.Cubic);
                }
                if (rdoWebcam.Checked)
                {
                    if (locker == true)
                    {
                        locker = false;
                        GC.Collect();
                        return;
                    }
                    VideoCapture cv = new VideoCapture(0);
                    Task task1 = new Task(() =>
                    {
                        locker = true;
                        Stopwatch internal_timer = new Stopwatch();
                        while (locker)
                        {
                            try
                            {
                                internal_timer.Restart();
                                timer.Restart();
                                mat = cv.QueryFrame();
                                Invoke(new Action(() =>
                                {
                                    GC.Collect();
                                }));
                                Invoke(new Action(() =>
                                {
                                    try
                                    {
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        locker = false;
                                        this.Refresh();
                                        GC.Collect();
                                        return;
                                    }
                                    ImageBoxResult.Image = Processing.ProcessMatching(mat.ToImage<Bgr, byte>(), ObjToFind, _method, _sense/ 100.0).Resize(ImageBoxResult.Width, ImageBoxResult.Height, Emgu.CV.CvEnum.Inter.Linear);

                                }));
                                timer.Stop();
                                Invoke(new Action(() =>
                                {
                                    this.Refresh();
                                }));
                                internal_timer.Stop();
                                if (internal_timer.ElapsedMilliseconds < 16) Thread.Sleep((int)(16 - internal_timer.ElapsedMilliseconds));

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                locker = false;
                                this.Refresh();
                                GC.Collect();
                                return;
                            }
                        }
                    });
                    task1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnImageScene_Click(object sender, EventArgs e)
        {
            if (ofdImageScene.ShowDialog() == DialogResult.OK)
            {
                scene = new Image<Bgr, byte>(ofdImageScene.FileName);
                txtImageScene.Text = ofdImageScene.FileName;
            }
        }

        private void btnImageToFind_Click(object sender, EventArgs e)
        {
            if (ofdImageToFind.ShowDialog() == DialogResult.OK)
            {
                ObjToFind = new Image<Bgr, byte>(ofdImageToFind.FileName);
                txtImageToFind.Text = ofdImageToFind.FileName;
            }
        }

        private void rdoImageFile_CheckedChanged(object sender, EventArgs e)
        {
            locker = false;
            txtImageScene.Visible = !txtImageScene.Visible;
            label2.Visible = !label2.Visible;
            btnImageScene.Visible = !btnImageScene.Visible;
        }

        Point LastPoint;

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.DarkRed;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(192, 47, 17);
        }
    }
}