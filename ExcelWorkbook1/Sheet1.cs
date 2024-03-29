﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace ExcelWorkbook1
{
    public partial class Sheet1
    {
        Microsoft.Office.Tools.Excel.NamedRange nr;

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            nr = this.Controls.AddNamedRange(this.Range["A2"], "NamedRange1");
            nr.Value2 = "This text was added by using code";
            this.BeforeDoubleClick +=
                new Excel.DocEvents_BeforeDoubleClickEventHandler(
                DoubleClick);
        }


        void DoubleClick(Excel.Range Target, ref bool Cancel)
        {
            nr.Value2 = "Double click2";
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion
    }
}
