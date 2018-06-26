using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoDraw
{
    public partial class AddPlate : Form
    {
        public AddPlate()
        {
            InitializeComponent();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
            MainDlg dlg = new MainDlg();
            dlg.Show();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Plate plate = new Plate();
            plate.part_name_ = text_part.Text;
            plate.thick_ = combo_thick.Text;
            plate.mat_ = comboBox3.Text;
            db.add_plate(plate);
            Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("Add plate OK.");
        }

      
    }
}