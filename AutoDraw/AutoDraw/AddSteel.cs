using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;





namespace AutoDraw
{
    public partial class AddSteel : Form
    {
       

        public AddSteel()
        {
            InitializeComponent();
        }
        

        private void but_partno_Click(object sender, EventArgs e)
        {
           CmdCad cmd = new CmdCad();
           string str = cmd.get_txt_by_select("\nPlease select Part Name :");
           if (str != "")
           {
               text_partname.Text = str;

           }
           else
           {
               Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
               ed.WriteMessage("\nPlease set Part Name!");
           }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MainDlg dlg = new MainDlg();
            dlg.Show();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Steel steel = new Steel();
            steel.part_name_ = text_partname.Text;
            steel.section_ = combo_section.Text;
            steel.mat_ = combo_mat.Text;
            db.add_steel(steel);
            Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("Add steel OK.");
        }

        private void but_section_Click(object sender, EventArgs e)
        {
            CmdCad cmd = new CmdCad();
            string str = cmd.get_txt_by_select("\nPlease select the section :");
            if (str != "")
            {
                combo_section.Text = str;

            }
            else
            {
                Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
                ed.WriteMessage("\nPlease set Part Name!");
            }

        }

        private void but_matrial_Click(object sender, EventArgs e)
        {
            CmdCad cmd = new CmdCad();
            string str = cmd.get_txt_by_select("\nPlease select the matrial:");
            if (str != "")
            {
                combo_mat.Text = str;

            }
            else
            {
                Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
                ed.WriteMessage("\nPlease set Part Name!");
            }
        }
    }
}