using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoDraw
{
    public partial class DBMgr : Form
    {
       
        public DBMgr()
        {
            InitializeComponent();
            init_tree();
           
        }

        public void init_tree()
        {
            TreeNode t = new TreeNode("生成报表");//作为根节点。
            tree_report.Nodes.Add(t);
            TreeNode t1 = new TreeNode("C-1.dxf");
            t.Nodes.Add(t1);
            TreeNode t2 = new TreeNode("B-1.dxf");
            t.Nodes.Add(t2);
            TreeNode t3 = new TreeNode("PL8.dxf");
            t.Nodes.Add(t3);
        }
        private ColumnHeader create_col(string text, int width)
        {
            ColumnHeader ch = new ColumnHeader();
            ch.Text = text;
            ch.Width = width;
            return ch;
        }
        public void init_list_steel_head()
        {
            list_show.Columns.Add(create_col("ID", 30));
            list_show.Columns.Add(create_col("Part Name", 120));
            list_show.Columns.Add(create_col("Section", 90));
            list_show.Columns.Add(create_col("Material", 80));
        }
        public void init_list_plate_head()
        {
            list_show.Columns.Add(create_col("ID", 30));
            list_show.Columns.Add(create_col("Part Name", 120));
            list_show.Columns.Add(create_col("Thick", 90));
            list_show.Columns.Add(create_col("Material", 80));
        }
        private void but_show_steel_Click(object sender, EventArgs e)
        {
            list_show.Clear();
            init_list_steel_head();
            Database db = new Database();
            db.show_steels(list_show);
           
        }

        private void but_show_plate_Click(object sender, EventArgs e)
        {
            list_show.Clear();
            init_list_plate_head();
            Database db = new Database();
            db.show_plates(list_show);

        }

    }
}