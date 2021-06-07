namespace OpenCvtest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgupload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.OrignalPic = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.MatchingPic = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.ther = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrignalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // imgupload
            // 
            this.imgupload.Location = new System.Drawing.Point(12, 12);
            this.imgupload.Name = "imgupload";
            this.imgupload.Size = new System.Drawing.Size(104, 22);
            this.imgupload.TabIndex = 0;
            this.imgupload.Text = "이미지 업로드";
            this.imgupload.UseVisualStyleBackColor = true;
            this.imgupload.Click += new System.EventHandler(this.imgupload_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "잘라낸 이미지";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 22);
            this.button3.TabIndex = 2;
            this.button3.Text = "매칭하기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxIpl1.TabIndex = 3;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // OrignalPic
            // 
            this.OrignalPic.Location = new System.Drawing.Point(141, 12);
            this.OrignalPic.Name = "OrignalPic";
            this.OrignalPic.Size = new System.Drawing.Size(713, 507);
            this.OrignalPic.TabIndex = 4;
            this.OrignalPic.TabStop = false;
            // 
            // MatchingPic
            // 
            this.MatchingPic.Location = new System.Drawing.Point(880, 40);
            this.MatchingPic.Name = "MatchingPic";
            this.MatchingPic.Size = new System.Drawing.Size(228, 149);
            this.MatchingPic.TabIndex = 5;
            this.MatchingPic.TabStop = false;
            // 
            // ther
            // 
            this.ther.Location = new System.Drawing.Point(894, 247);
            this.ther.Name = "ther";
            this.ther.Size = new System.Drawing.Size(100, 21);
            this.ther.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 551);
            this.Controls.Add(this.ther);
            this.Controls.Add(this.MatchingPic);
            this.Controls.Add(this.OrignalPic);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imgupload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrignalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imgupload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private OpenCvSharp.UserInterface.PictureBoxIpl OrignalPic;
        private OpenCvSharp.UserInterface.PictureBoxIpl MatchingPic;
        private System.Windows.Forms.TextBox ther;
    }
}

