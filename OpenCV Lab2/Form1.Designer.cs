using System.Windows.Forms;

namespace OpenCV_Lab2
{
    partial class LWForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoImageFile = new System.Windows.Forms.RadioButton();
            this.rdoWebcam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageScene = new System.Windows.Forms.TextBox();
            this.btnImageScene = new System.Windows.Forms.Button();
            this.btnImageToFind = new System.Windows.Forms.Button();
            this.txtImageToFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.ofdImageScene = new System.Windows.Forms.OpenFileDialog();
            this.ofdImageToFind = new System.Windows.Forms.OpenFileDialog();
            this.ImageBoxResult = new Emgu.CV.UI.ImageBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxResult)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник изображения";
            // 
            // rdoImageFile
            // 
            this.rdoImageFile.AutoSize = true;
            this.rdoImageFile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoImageFile.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoImageFile.Location = new System.Drawing.Point(12, 572);
            this.rdoImageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoImageFile.Name = "rdoImageFile";
            this.rdoImageFile.Size = new System.Drawing.Size(164, 20);
            this.rdoImageFile.TabIndex = 1;
            this.rdoImageFile.TabStop = true;
            this.rdoImageFile.Text = "Загрузить изображение";
            this.rdoImageFile.UseVisualStyleBackColor = true;
            this.rdoImageFile.CheckedChanged += new System.EventHandler(this.rdoImageFile_CheckedChanged);
            // 
            // rdoWebcam
            // 
            this.rdoWebcam.AutoSize = true;
            this.rdoWebcam.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoWebcam.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoWebcam.Location = new System.Drawing.Point(12, 548);
            this.rdoWebcam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoWebcam.Name = "rdoWebcam";
            this.rdoWebcam.Size = new System.Drawing.Size(157, 20);
            this.rdoWebcam.TabIndex = 2;
            this.rdoWebcam.TabStop = true;
            this.rdoWebcam.Text = "Включить веб-камеру";
            this.rdoWebcam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(455, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изображение сцены";
            this.label2.Visible = false;
            // 
            // txtImageScene
            // 
            this.txtImageScene.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImageScene.Location = new System.Drawing.Point(455, 566);
            this.txtImageScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageScene.Name = "txtImageScene";
            this.txtImageScene.PlaceholderText = "Адрес ";
            this.txtImageScene.ReadOnly = true;
            this.txtImageScene.Size = new System.Drawing.Size(151, 24);
            this.txtImageScene.TabIndex = 5;
            this.txtImageScene.Visible = false;
            // 
            // btnImageScene
            // 
            this.btnImageScene.Location = new System.Drawing.Point(612, 567);
            this.btnImageScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageScene.Name = "btnImageScene";
            this.btnImageScene.Size = new System.Drawing.Size(37, 22);
            this.btnImageScene.TabIndex = 6;
            this.btnImageScene.Text = "...";
            this.btnImageScene.UseVisualStyleBackColor = true;
            this.btnImageScene.Visible = false;
            this.btnImageScene.Click += new System.EventHandler(this.btnImageScene_Click);
            // 
            // btnImageToFind
            // 
            this.btnImageToFind.Location = new System.Drawing.Point(383, 566);
            this.btnImageToFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageToFind.Name = "btnImageToFind";
            this.btnImageToFind.Size = new System.Drawing.Size(37, 22);
            this.btnImageToFind.TabIndex = 9;
            this.btnImageToFind.Text = "...";
            this.btnImageToFind.UseVisualStyleBackColor = true;
            this.btnImageToFind.Click += new System.EventHandler(this.btnImageToFind_Click);
            // 
            // txtImageToFind
            // 
            this.txtImageToFind.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImageToFind.Location = new System.Drawing.Point(226, 566);
            this.txtImageToFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageToFind.Name = "txtImageToFind";
            this.txtImageToFind.PlaceholderText = "Адрес ";
            this.txtImageToFind.ReadOnly = true;
            this.txtImageToFind.Size = new System.Drawing.Size(151, 24);
            this.txtImageToFind.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(226, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изображение объекта";
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVideo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVideo.Location = new System.Drawing.Point(655, 531);
            this.buttonVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(154, 61);
            this.buttonVideo.TabIndex = 12;
            this.buttonVideo.Text = "Поиск";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // ofdImageScene
            // 
            this.ofdImageScene.FileName = "openFileDialog1";
            // 
            // ofdImageToFind
            // 
            this.ofdImageToFind.FileName = "openFileDialog2";
            // 
            // ImageBoxResult
            // 
            this.ImageBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBoxResult.Location = new System.Drawing.Point(12, 45);
            this.ImageBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageBoxResult.Name = "ImageBoxResult";
            this.ImageBoxResult.Size = new System.Drawing.Size(797, 482);
            this.ImageBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBoxResult.TabIndex = 2;
            this.ImageBoxResult.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(821, 40);
            this.MainPanel.TabIndex = 13;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Поиск объекта на фото или видео";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.ExitButton.Location = new System.Drawing.Point(793, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 30);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // LWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ImageBoxResult);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.btnImageToFind);
            this.Controls.Add(this.txtImageToFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImageScene);
            this.Controls.Add(this.txtImageScene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoWebcam);
            this.Controls.Add(this.rdoImageFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LWForm";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxResult)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdoImageFile;
        private RadioButton rdoWebcam;
        private Label label2;
        private TextBox txtImageScene;
        private Button btnImageScene;
        private Button btnImageToFind;
        private TextBox txtImageToFind;
        private Label label3;
        private Button buttonVideo;
        private OpenFileDialog ofdImageScene;
        private OpenFileDialog ofdImageToFind;
        private Emgu.CV.UI.ImageBox ImageBoxResult;
        private Panel MainPanel;
        private Label ExitButton;
        private Label label4;
    }
}