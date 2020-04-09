namespace RunCat
{
    partial class MainView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucRunCat1 = new RunCat.UcRunCat();
            this.SuspendLayout();
            // 
            // ucRunCat1
            // 
            this.ucRunCat1.BackColor = System.Drawing.Color.Black;
            this.ucRunCat1.Location = new System.Drawing.Point(4, 11);
            this.ucRunCat1.Name = "ucRunCat1";
            this.ucRunCat1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucRunCat1.Size = new System.Drawing.Size(33, 18);
            this.ucRunCat1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ucRunCat1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(40, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private UcRunCat ucRunCat1;
    }
}
