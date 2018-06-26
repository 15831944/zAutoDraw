namespace AutoDraw
{
    partial class DBMgr
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tree_report = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_show_steel = new System.Windows.Forms.Button();
            this.but_show_plate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.list_show = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree_report
            // 
            this.tree_report.Location = new System.Drawing.Point(11, 23);
            this.tree_report.Name = "tree_report";
            this.tree_report.Size = new System.Drawing.Size(175, 464);
            this.tree_report.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tree_report);
            this.groupBox1.Location = new System.Drawing.Point(11, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 493);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已生成报表管理";
            // 
            // but_show_steel
            // 
            this.but_show_steel.Location = new System.Drawing.Point(240, 27);
            this.but_show_steel.Name = "but_show_steel";
            this.but_show_steel.Size = new System.Drawing.Size(63, 23);
            this.but_show_steel.TabIndex = 2;
            this.but_show_steel.Text = "型材";
            this.but_show_steel.UseVisualStyleBackColor = true;
            this.but_show_steel.Click += new System.EventHandler(this.but_show_steel_Click);
            // 
            // but_show_plate
            // 
            this.but_show_plate.Location = new System.Drawing.Point(333, 27);
            this.but_show_plate.Name = "but_show_plate";
            this.but_show_plate.Size = new System.Drawing.Size(57, 23);
            this.but_show_plate.TabIndex = 3;
            this.but_show_plate.Text = "板材";
            this.but_show_plate.UseVisualStyleBackColor = true;
            this.but_show_plate.Click += new System.EventHandler(this.but_show_plate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "查找";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 21);
            this.textBox1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(468, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "生成报表";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "报表类型";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Steel_Cut_Templet.dxf",
            "Plate_Cut_Templet.dxf",
            "Sum_Steel.dxf",
            "Sum_Plate.dxf"});
            this.comboBox1.Location = new System.Drawing.Point(292, 482);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Steel_Cut_Templet.dxf";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "关闭";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // list_show
            // 
            this.list_show.GridLines = true;
            this.list_show.Location = new System.Drawing.Point(233, 67);
            this.list_show.Name = "list_show";
            this.list_show.Size = new System.Drawing.Size(413, 409);
            this.list_show.TabIndex = 11;
            this.list_show.UseCompatibleStateImageBehavior = false;
            this.list_show.View = System.Windows.Forms.View.Details;
            // 
            // DBMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 528);
            this.Controls.Add(this.list_show);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.but_show_plate);
            this.Controls.Add(this.but_show_steel);
            this.Controls.Add(this.groupBox1);
            this.Name = "DBMgr";
            this.Text = "DBMgr";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_report;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_show_steel;
        private System.Windows.Forms.Button but_show_plate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView list_show;
    }
}