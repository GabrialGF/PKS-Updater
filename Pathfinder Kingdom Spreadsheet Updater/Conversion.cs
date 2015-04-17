using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection; 

namespace Pathfinder_Kingdom_Spreadsheet_Updater
{
    static class Conversion
    {
        
        //Establishing Variables for the conversion process
        private static Excel.Application oXLApp;
        private static Excel.Workbook oXLWB;
        private static Excel.Worksheet oXLWS;
        //private static Excel.Range oRange;
        //private static Excel.Application dXLApp;
        private static Excel.Workbook dXLWB;
        private static Excel.Worksheet dXLWS;
        //private static Excel.Range dRange;

        public static void Initialize(String oFile, String dFile) //The method called by the form that actually runs the conversion and calls all other methods.
        {
            String XLTemp = @"C:\Users\Robert\Dropbox\RedAppricot-FYEO\Robert Misc\URule_Kingdom_Sheet.xlsx";
            /* *****************************************************
            Block of code to use later to load approriate template workbook
            Designed to always load proper file from the right folder
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Archive\";
            string filter = "*.zip";
            string[] files = Directory.GetFiles(folder, filter);
             * **************************************************/
            

            //Opening new workbooks preparing for the conversion
            oXLApp = new Excel.Application();
            oXLApp.Visible = true;
            oXLWB = oXLApp.Workbooks.Open(oFile);
            oXLWS = (Excel.Worksheet)oXLWB.Sheets[1];

            //dXLApp = new Excel.Application();
            //dXLApp.Visible = true;
            dXLWB = oXLApp.Workbooks.Open(XLTemp);
            dXLWS = (Excel.Worksheet)dXLWB.Sheets[1];
            string version = Version_Test();

            if (version == "5.3f")
            {
                RuleCopy53();
                OverallCpy53();
            }
        }
      
        public static string Version_Test() //Does a test to see if original sheet is 5.3 or 5.4
        {
            return "5.3f";
        }

        public static void RuleCopy53(){
            Excel.Range from = oXLWS.Range["B3:B53"];
            Excel.Range to = dXLWS.Range["B5:B55"];
            from.Copy(to);

            from = oXLWS.Range["C3:I53"];
            to = dXLWS.Range["H5:N55"];
            from.Copy(to);

            from = oXLWS.Range["J3:V53"];
            to = dXLWS.Range["P5:AB55"];
            from.Copy(to);
        }
        public static void OverallCpy53()
        {
            oXLWS = (Excel.Worksheet)oXLWB.Sheets[2];
            dXLWS = (Excel.Worksheet)dXLWB.Sheets[2];

            Excel.Range from = oXLWS.Range["D2:L2"];
            Excel.Range to = dXLWS.Range["D2:L2"];
            from.Copy(to);

        }
    }
}
