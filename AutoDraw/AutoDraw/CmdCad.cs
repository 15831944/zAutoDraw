using System;
using System.Collections.Generic;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;


namespace AutoDraw
{
    class CmdCad
    {
        public string get_txt_by_select(string cmd_str)
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            PromptEntityResult sel_res = ed.GetEntity(cmd_str);
            if (sel_res.Status == PromptStatus.OK)
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    DBText txt = trans.GetObject(sel_res.ObjectId, OpenMode.ForRead) as DBText;
                    if (txt != null)
                    {
                        trans.Commit();
                        return txt.TextString;
                    }
                    else
                    {
                        return "";
                    }
                }

            }
            else
            {
                return "";
            }

        }
    }
}
