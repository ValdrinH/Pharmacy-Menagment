using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Menagment.Classes
{
    public class VarClass
    {
        public static int num = 0;
        public static bool Report = false; //Per te shikuar se cili Report eshte klikuar
        public static bool Description = false; //Per te shikuar se cili Report eshte klikuar
        public static bool ChartGen = false; //Per te shikuar se cili Report eshte klikuar



        public static DialogResult HelpFormResult(string tit, UserControl userControl)
         {
            HelpFormDialog helpForm = new HelpFormDialog();
            helpForm.user = userControl;
            helpForm._Tit = tit;
            return helpForm.ShowDialog();
         }
        public static void ShowMsgBox(string msg,string tit, int icone)
        {
            AlertBox alertBox = new AlertBox(tit, msg, icone);
            alertBox.BringToFront();
            alertBox.ShowDialog();
        }
    }
    public struct DetailsSupplierStruct
    {
        public static string SName;
    }
    public struct DetailsMedicineStruct
    {
        public static int _Id;
        public static string MdcName;
        public static string MdcGenericName;
        public static string MdcBatch;
        public static int MdcQty;
        public static DateTime MdcExp;
        public static double MdcRate;
        public static string Supplier;
    }
}
