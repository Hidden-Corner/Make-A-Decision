namespace MainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.yesno = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.Label();
            this.multiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesno
            // 
            this.yesno.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.yesno.AutoSize = true;
            this.yesno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesno.Location = new System.Drawing.Point(12, 79);
            this.yesno.Name = "yesno";
            this.yesno.Size = new System.Drawing.Size(250, 37);
            this.yesno.TabIndex = 0;
            this.yesno.Text = "Yes-No";
            this.yesno.UseVisualStyleBackColor = true;
            this.yesno.Click += new System.EventHandler(this.YesNo);
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainText.Location = new System.Drawing.Point(34, 27);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(216, 28);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "Fast Decision Maker";
            this.mainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiple
            // 
            this.multiple.AutoSize = true;
            this.multiple.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiple.Location = new System.Drawing.Point(12, 123);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(250, 31);
            this.multiple.TabIndex = 2;
            this.multiple.Text = "Multiple Choices";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.GetMultipleAnswer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.yesno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make A Decision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button yesno;
        private Label mainText;
        private Button multiple;
    }
}