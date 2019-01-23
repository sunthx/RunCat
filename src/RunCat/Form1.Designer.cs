namespace RunCat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucRunCat1 = new RunCat.UcRunCat();
            this.ucRunCat2 = new RunCat.UcRunCat();
            this.ucRunCat3 = new RunCat.UcRunCat();
            this.SuspendLayout();
            // 
            // ucRunCat1
            // 
            this.ucRunCat1.BackColor = System.Drawing.Color.Black;
            this.ucRunCat1.Location = new System.Drawing.Point(12, 12);
            this.ucRunCat1.Name = "ucRunCat1";
            this.ucRunCat1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucRunCat1.Size = new System.Drawing.Size(33, 18);
            this.ucRunCat1.TabIndex = 0;
            // 
            // ucRunCat2
            // 
            this.ucRunCat2.BackColor = System.Drawing.Color.Black;
            this.ucRunCat2.Location = new System.Drawing.Point(72, 12);
            this.ucRunCat2.Name = "ucRunCat2";
            this.ucRunCat2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucRunCat2.Size = new System.Drawing.Size(33, 18);
            this.ucRunCat2.TabIndex = 1;
            // 
            // ucRunCat3
            // 
            this.ucRunCat3.BackColor = System.Drawing.Color.Black;
            this.ucRunCat3.Location = new System.Drawing.Point(134, 12);
            this.ucRunCat3.Name = "ucRunCat3";
            this.ucRunCat3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucRunCat3.Size = new System.Drawing.Size(33, 18);
            this.ucRunCat3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(184, 45);
            this.Controls.Add(this.ucRunCat3);
            this.Controls.Add(this.ucRunCat2);
            this.Controls.Add(this.ucRunCat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Brown;
            this.ResumeLayout(false);

        }

        #endregion

        private UcRunCat ucRunCat1;
        private UcRunCat ucRunCat2;
        private UcRunCat ucRunCat3;
    }
}

