﻿namespace BlinkBlink_EyeJoah
{
    partial class Control3_Work
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartPanel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.realtimeTxt = new System.Windows.Forms.TextBox();
            this.nextDayBtn = new System.Windows.Forms.PictureBox();
            this.beforeDayBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nextDayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPanel1
            // 
            this.chartPanel1.AutoScroll = true;
            this.chartPanel1.AutoSize = true;
            this.chartPanel1.Location = new System.Drawing.Point(35, 70);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(664, 309);
            this.chartPanel1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(355, 70);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Average PC usage time per session";
            // 
            // realtimeTxt
            // 
            this.realtimeTxt.BackColor = System.Drawing.Color.White;
            this.realtimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realtimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.realtimeTxt.Location = new System.Drawing.Point(145, 49);
            this.realtimeTxt.Name = "realtimeTxt";
            this.realtimeTxt.ReadOnly = true;
            this.realtimeTxt.Size = new System.Drawing.Size(340, 25);
            this.realtimeTxt.TabIndex = 31;
            this.realtimeTxt.Text = "March 1, 2017 (Wednesday)";
            this.realtimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Image = global::BlinkBlink_EyeJoah.Properties.Resources.rightArrow;
            this.nextDayBtn.Location = new System.Drawing.Point(460, 50);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(30, 20);
            this.nextDayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextDayBtn.TabIndex = 29;
            this.nextDayBtn.TabStop = false;
            this.nextDayBtn.Click += new System.EventHandler(this.nextDayBtn_Click);
            // 
            // beforeDayBtn
            // 
            this.beforeDayBtn.Image = global::BlinkBlink_EyeJoah.Properties.Resources.leftArrow;
            this.beforeDayBtn.Location = new System.Drawing.Point(120, 50);
            this.beforeDayBtn.Name = "beforeDayBtn";
            this.beforeDayBtn.Size = new System.Drawing.Size(30, 20);
            this.beforeDayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beforeDayBtn.TabIndex = 28;
            this.beforeDayBtn.TabStop = false;
            this.beforeDayBtn.Click += new System.EventHandler(this.beforeDayBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BlinkBlink_EyeJoah.Properties.Resources.calendar_dots;
            this.pictureBox3.Location = new System.Drawing.Point(500, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Control3_Work
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.nextDayBtn);
            this.Controls.Add(this.beforeDayBtn);
            this.Controls.Add(this.realtimeTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPanel1);
            this.Name = "Control3_Work";
            this.Size = new System.Drawing.Size(699, 443);
            ((System.ComponentModel.ISupportInitialize)(this.nextDayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel chartPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox beforeDayBtn;
        private System.Windows.Forms.PictureBox nextDayBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox realtimeTxt;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
