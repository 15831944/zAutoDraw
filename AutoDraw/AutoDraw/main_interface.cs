using System;
using System.Collections.Generic;
using System.Text;


using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;


[assembly: CommandClass(typeof(AutoDraw.main_interface))]
//[assembly: ExtensionApplication(typeof(AutoDraw.main_interface))]
namespace AutoDraw
{
    public class main_interface //: IExtensionApplication 
    {
        [CommandMethod("auto")]
        public void auto()
        {
            MainDlg main_dlg = new MainDlg();
            main_dlg.Show();
        }
    }
}
