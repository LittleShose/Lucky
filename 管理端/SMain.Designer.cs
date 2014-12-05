namespace 管理端
{
    partial class SMain
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
            this.btn导入 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn导入
            // 
            this.btn导入.Location = new System.Drawing.Point(12, 12);
            this.btn导入.Name = "btn导入";
            this.btn导入.Size = new System.Drawing.Size(75, 53);
            this.btn导入.TabIndex = 0;
            this.btn导入.Text = "导入用户";
            this.btn导入.UseVisualStyleBackColor = true;
            this.btn导入.Click += new System.EventHandler(this.btn导入_Click);
            // 
            // SMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(94, 75);
            this.Controls.Add(this.btn导入);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SMain";
            this.Text = "SMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn导入;
    }
}