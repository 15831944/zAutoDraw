using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace AutoDraw
{
    class Steel
    {
        public string part_name_ = "";//部品号
        public string section_ = "";//截面
        public string mat_ = "";//材质


    } 
    class Plate
    {
        public string part_name_ = "";//部品号
        public string thick_ = "";//厚度
        public string mat_ = "";//材质

    }

    class Database
    {
        static public List<Steel> steels_ = new List<Steel>();
        static public List<Plate> plates_ = new List<Plate>();

        public void add_steel(Steel steel)
        {
            steels_.Add(steel);

        }
        public void add_plate(Plate pl)
        {
            plates_.Add(pl);
        }
        public void show_steels(ListView list)
        {
            for (int i = 0; i < steels_.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();             
                lvi.Text = (i + 1).ToString();
                lvi.SubItems.Add(steels_[i].part_name_);
                lvi.SubItems.Add(steels_[i].section_);
                lvi.SubItems.Add(steels_[i].mat_);
                list.Items.Add(lvi);  
            }
        }
        public void show_plates(ListView list)
        {
            for (int i = 0; i < plates_.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();
                lvi.SubItems.Add(plates_[i].part_name_);
                lvi.SubItems.Add(plates_[i].thick_);
                lvi.SubItems.Add(plates_[i].mat_);
                list.Items.Add(lvi);
            }
        }
    }
}
