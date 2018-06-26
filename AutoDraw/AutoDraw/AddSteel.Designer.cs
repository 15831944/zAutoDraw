namespace AutoDraw
{
    partial class AddSteel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_partname = new System.Windows.Forms.TextBox();
            this.but_partno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_section = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_mat = new System.Windows.Forms.ComboBox();
            this.but_section = new System.Windows.Forms.Button();
            this.but_matrial = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "读取";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "另存为";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "部品号：";
            // 
            // text_partname
            // 
            this.text_partname.Location = new System.Drawing.Point(98, 70);
            this.text_partname.Name = "text_partname";
            this.text_partname.Size = new System.Drawing.Size(161, 21);
            this.text_partname.TabIndex = 5;
            // 
            // but_partno
            // 
            this.but_partno.Location = new System.Drawing.Point(280, 70);
            this.but_partno.Name = "but_partno";
            this.but_partno.Size = new System.Drawing.Size(29, 23);
            this.but_partno.TabIndex = 6;
            this.but_partno.Text = "⊙";
            this.but_partno.UseVisualStyleBackColor = true;
            this.but_partno.Click += new System.EventHandler(this.but_partno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "截面：";
            // 
            // combo_section
            // 
            this.combo_section.FormattingEnabled = true;
            this.combo_section.Items.AddRange(new object[] {
            "H500X200X5X12",
            "L200X150X2X2",
            "T500X200X5X12",
            "U500X200X5"});
            this.combo_section.Location = new System.Drawing.Point(98, 115);
            this.combo_section.Name = "combo_section";
            this.combo_section.Size = new System.Drawing.Size(161, 20);
            this.combo_section.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "材质：";
            // 
            // combo_mat
            // 
            this.combo_mat.FormattingEnabled = true;
            this.combo_mat.Items.AddRange(new object[] {
            "SS400",
            "SS450"});
            this.combo_mat.Location = new System.Drawing.Point(98, 164);
            this.combo_mat.Name = "combo_mat";
            this.combo_mat.Size = new System.Drawing.Size(161, 20);
            this.combo_mat.TabIndex = 7;
            // 
            // but_section
            // 
            this.but_section.Location = new System.Drawing.Point(280, 111);
            this.but_section.Name = "but_section";
            this.but_section.Size = new System.Drawing.Size(29, 23);
            this.but_section.TabIndex = 8;
            this.but_section.Text = "⊙";
            this.but_section.UseVisualStyleBackColor = true;
            this.but_section.Click += new System.EventHandler(this.but_section_Click);
            // 
            // but_matrial
            // 
            this.but_matrial.Location = new System.Drawing.Point(280, 162);
            this.but_matrial.Name = "but_matrial";
            this.but_matrial.Size = new System.Drawing.Size(29, 23);
            this.but_matrial.TabIndex = 9;
            this.but_matrial.Text = "⊙";
            this.but_matrial.UseVisualStyleBackColor = true;
            this.but_matrial.Click += new System.EventHandler(this.but_matrial_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(69, 375);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 10;
            this.but_add.Text = "添加";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(184, 375);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "关闭";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(37, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(81, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 110);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "关联";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "删除";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // AddSteel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_matrial);
            this.Controls.Add(this.but_section);
            this.Controls.Add(this.combo_mat);
            this.Controls.Add(this.combo_section);
            this.Controls.Add(this.but_partno);
            this.Controls.Add(this.text_partname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddSteel";
            this.Text = "Add Steel";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_partname;
        private System.Windows.Forms.Button but_partno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_mat;
        private System.Windows.Forms.Button but_section;
        private System.Windows.Forms.Button but_matrial;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button7;
    }
}