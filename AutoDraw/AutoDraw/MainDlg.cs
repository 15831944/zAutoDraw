using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoDraw
{
    public partial class MainDlg : Form
    {
        public MainDlg()
        {
            InitializeComponent();
        }

     
        private void but_edit_steel_Click(object sender, EventArgs e)
        {
            AddSteel dlg = new AddSteel();
            dlg.Show();
            this.Close();
        }

        private void but_edit_plate_Click(object sender, EventArgs e)
        {
            AddPlate dlg = new AddPlate();
            dlg.Show();
            this.Close();
        }

        private void but_info_db_Click(object sender, EventArgs e)
        {
            InfoMgr dlg = new InfoMgr();
            dlg.ShowDialog();
        }

        private void but_db_Click(object sender, EventArgs e)
        {
            DBMgr dlg = new DBMgr();
            dlg.ShowDialog();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_project_Click(object sender, EventArgs e)
        {
            ProjectDlg dlg = new ProjectDlg();
            dlg.ShowDialog();


        }
    }
}