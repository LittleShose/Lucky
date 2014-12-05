namespace 主程序
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgv员工列表 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drop奖品 = new System.Windows.Forms.ComboBox();
            this.btn抽奖 = new System.Windows.Forms.Button();
            this.lib抽奖总数提示 = new System.Windows.Forms.Label();
            this.btn选定抽奖类型 = new System.Windows.Forms.Button();
            this.btn最终确认 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt单次抽取量 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drop抽奖类型 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv员工列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 683);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgv员工列表
            // 
            this.dgv员工列表.AllowUserToAddRows = false;
            this.dgv员工列表.AllowUserToDeleteRows = false;
            this.dgv员工列表.AllowUserToResizeColumns = false;
            this.dgv员工列表.AllowUserToResizeRows = false;
            this.dgv员工列表.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv员工列表.CausesValidation = false;
            this.dgv员工列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv员工列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.工号,
            this.部门});
            this.dgv员工列表.GridColor = System.Drawing.Color.LightSalmon;
            this.dgv员工列表.Location = new System.Drawing.Point(21, 132);
            this.dgv员工列表.Margin = new System.Windows.Forms.Padding(4);
            this.dgv员工列表.MultiSelect = false;
            this.dgv员工列表.Name = "dgv员工列表";
            this.dgv员工列表.ReadOnly = true;
            this.dgv员工列表.RowHeadersVisible = false;
            this.dgv员工列表.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv员工列表.RowTemplate.Height = 23;
            this.dgv员工列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv员工列表.Size = new System.Drawing.Size(601, 544);
            this.dgv员工列表.TabIndex = 0;
            this.dgv员工列表.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Visible = false;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "姓名";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 80;
            // 
            // 工号
            // 
            this.工号.DataPropertyName = "工号";
            this.工号.HeaderText = "工号";
            this.工号.Name = "工号";
            this.工号.ReadOnly = true;
            this.工号.Width = 80;
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "部门";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            this.部门.ReadOnly = true;
            this.部门.Width = 438;
            // 
            // drop奖品
            // 
            this.drop奖品.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop奖品.FormattingEnabled = true;
            this.drop奖品.Location = new System.Drawing.Point(644, 188);
            this.drop奖品.Margin = new System.Windows.Forms.Padding(4);
            this.drop奖品.Name = "drop奖品";
            this.drop奖品.Size = new System.Drawing.Size(258, 24);
            this.drop奖品.TabIndex = 3;
            this.drop奖品.SelectedIndexChanged += new System.EventHandler(this.drop奖品_SelectedIndexChanged);
            // 
            // btn抽奖
            // 
            this.btn抽奖.Location = new System.Drawing.Point(644, 317);
            this.btn抽奖.Margin = new System.Windows.Forms.Padding(4);
            this.btn抽奖.Name = "btn抽奖";
            this.btn抽奖.Size = new System.Drawing.Size(111, 57);
            this.btn抽奖.TabIndex = 4;
            this.btn抽奖.Text = "抽奖开始";
            this.btn抽奖.UseVisualStyleBackColor = true;
            this.btn抽奖.Click += new System.EventHandler(this.btn抽奖_Click);
            // 
            // lib抽奖总数提示
            // 
            this.lib抽奖总数提示.Font = new System.Drawing.Font("宋体", 60F);
            this.lib抽奖总数提示.Location = new System.Drawing.Point(644, 227);
            this.lib抽奖总数提示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lib抽奖总数提示.Name = "lib抽奖总数提示";
            this.lib抽奖总数提示.Size = new System.Drawing.Size(358, 76);
            this.lib抽奖总数提示.TabIndex = 6;
            this.lib抽奖总数提示.Text = "0/240";
            this.lib抽奖总数提示.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn选定抽奖类型
            // 
            this.btn选定抽奖类型.Location = new System.Drawing.Point(910, 156);
            this.btn选定抽奖类型.Margin = new System.Windows.Forms.Padding(4);
            this.btn选定抽奖类型.Name = "btn选定抽奖类型";
            this.btn选定抽奖类型.Size = new System.Drawing.Size(92, 56);
            this.btn选定抽奖类型.TabIndex = 7;
            this.btn选定抽奖类型.Text = "选定";
            this.btn选定抽奖类型.UseVisualStyleBackColor = true;
            this.btn选定抽奖类型.Click += new System.EventHandler(this.btn选定抽奖类型_Click);
            // 
            // btn最终确认
            // 
            this.btn最终确认.Location = new System.Drawing.Point(763, 317);
            this.btn最终确认.Margin = new System.Windows.Forms.Padding(4);
            this.btn最终确认.Name = "btn最终确认";
            this.btn最终确认.Size = new System.Drawing.Size(111, 57);
            this.btn最终确认.TabIndex = 4;
            this.btn最终确认.Text = "最终确认";
            this.btn最终确认.UseVisualStyleBackColor = true;
            this.btn最终确认.Click += new System.EventHandler(this.btn最终确认_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // txt单次抽取量
            // 
            this.txt单次抽取量.Location = new System.Drawing.Point(963, 348);
            this.txt单次抽取量.Margin = new System.Windows.Forms.Padding(4);
            this.txt单次抽取量.Name = "txt单次抽取量";
            this.txt单次抽取量.Size = new System.Drawing.Size(39, 26);
            this.txt单次抽取量.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "单次抽取量";
            // 
            // drop抽奖类型
            // 
            this.drop抽奖类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop抽奖类型.FormattingEnabled = true;
            this.drop抽奖类型.Location = new System.Drawing.Point(644, 156);
            this.drop抽奖类型.Margin = new System.Windows.Forms.Padding(4);
            this.drop抽奖类型.Name = "drop抽奖类型";
            this.drop抽奖类型.Size = new System.Drawing.Size(258, 24);
            this.drop抽奖类型.TabIndex = 3;
            this.drop抽奖类型.SelectedIndexChanged += new System.EventHandler(this.drop抽奖类型_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(644, 382);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::主程序.Properties.Resources.整体背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt单次抽取量);
            this.Controls.Add(this.btn选定抽奖类型);
            this.Controls.Add(this.lib抽奖总数提示);
            this.Controls.Add(this.btn最终确认);
            this.Controls.Add(this.btn抽奖);
            this.Controls.Add(this.drop抽奖类型);
            this.Controls.Add(this.drop奖品);
            this.Controls.Add(this.dgv员工列表);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "一二三等奖";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv员工列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox drop奖品;
        private System.Windows.Forms.Button btn抽奖;
        private System.Windows.Forms.Label lib抽奖总数提示;
        private System.Windows.Forms.Button btn选定抽奖类型;
        private System.Windows.Forms.DataGridView dgv员工列表;
        private System.Windows.Forms.Button btn最终确认;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt单次抽取量;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drop抽奖类型;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
    }
}