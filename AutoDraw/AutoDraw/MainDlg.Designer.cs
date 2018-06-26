namespace AutoDraw
{
    partial class MainDlg
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
            this.but_edit_steel = new System.Windows.Forms.Button();
            this.but_edit_plate = new System.Windows.Forms.Button();
            this.but_info_db = new System.Windows.Forms.Button();
            this.but_db = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.but_project = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_edit_steel
            // 
            this.but_edit_steel.Location = new System.Drawing.Point(40, 65);
            this.but_edit_steel.Name = "but_edit_steel";
            this.but_edit_steel.Size = new System.Drawing.Size(110, 23);
            this.but_edit_steel.TabIndex = 1;
            this.but_edit_steel.Text = "编辑型材";
            this.but_edit_steel.UseVisualStyleBackColor = true;
            this.but_edit_steel.Click += new System.EventHandler(this.but_edit_steel_Click);
            // 
            // but_edit_plate
            // 
            this.but_edit_plate.Location = new System.Drawing.Point(40, 104);
            this.but_edit_plate.Name = "but_edit_plate";
            this.but_edit_plate.Size = new System.Drawing.Size(110, 23);
            this.but_edit_plate.TabIndex = 2;
            this.but_edit_plate.Text = "编辑板材";
            this.but_edit_plate.UseVisualStyleBackColor = true;
            this.but_edit_plate.Click += new System.EventHandler(this.but_edit_plate_Click);
            // 
            // but_info_db
            // 
            this.but_info_db.Location = new System.Drawing.Point(40, 143);
            this.but_info_db.Name = "but_info_db";
            this.but_info_db.Size = new System.Drawing.Size(110, 23);
            this.but_info_db.TabIndex = 3;
            this.but_info_db.Text = "信息库管理";
            this.but_info_db.UseVisualStyleBackColor = true;
            this.but_info_db.Click += new System.EventHandler(this.but_info_db_Click);
            // 
            // but_db
            // 
            this.but_db.Location = new System.Drawing.Point(40, 182);
            this.but_db.Name = "but_db";
            this.but_db.Size = new System.Drawing.Size(110, 23);
            this.but_db.TabIndex = 4;
            this.but_db.Text = "数据库管理";
            this.but_db.UseVisualStyleBackColor = true;
            this.but_db.Click += new System.EventHandler(this.but_db_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(40, 221);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(110, 23);
            this.but_close.TabIndex = 5;
            this.but_close.Text = "关闭";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // but_project
            // 
            this.but_project.Location = new System.Drawing.Point(40, 26);
            this.but_project.Name = "but_project";
            this.but_project.Size = new System.Drawing.Size(110, 23);
            this.but_project.TabIndex = 6;
            this.but_project.Text = "工程信息";
            this.but_project.UseVisualStyleBackColor = true;
            this.but_project.Click += new System.EventHandler(this.but_project_Click);
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 264);
            this.Controls.Add(this.but_project);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_db);
            this.Controls.Add(this.but_info_db);
            this.Controls.Add(this.but_edit_plate);
            this.Controls.Add(this.but_edit_steel);
            this.Name = "MainDlg";
            this.Text = "AutoDraw";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_edit_steel;
        private System.Windows.Forms.Button but_edit_plate;
        private System.Windows.Forms.Button but_info_db;
        private System.Windows.Forms.Button but_db;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Button but_project;
    }
}