﻿namespace BlinkBlink_EyeJoah.Constatnt
{
    partial class ConstantChanges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1024, 818);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // ConstantChanges
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 818);
            this.Controls.Add(this.cartesianChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConstantChanges";
            this.Text = "ConstantChanges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}