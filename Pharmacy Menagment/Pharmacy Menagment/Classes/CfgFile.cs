using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.Classes
{
    public static class CfgFile
    {
        static string emriFile = "Konfigurime.cfg";
        static string direktoriaAktuale = Directory.GetCurrentDirectory();
        static string pathKomplet = Path.Combine(direktoriaAktuale, emriFile);

        public static void CreateCfg(string CfgEmri,string vlera)
        {
            using (StreamWriter file = new StreamWriter(pathKomplet))
            {
                file.WriteLine("Konfigurime:");
                file.WriteLine(CfgEmri +" = "+vlera);
            }
        }
        public static void AddnewLine(string CfgEmri, string vlera)
        {
            string[] linjat = File.ReadAllLines(pathKomplet);
            List<string> linjatReja = new List<string>(linjat);
            linjatReja.Add(CfgEmri +" = "+vlera);
            File.WriteAllLines(pathKomplet, linjatReja);
        }

        public static string ReadCfg(string CfgEmri)
        {
            string vlera = "";
            if (File.Exists(pathKomplet))
            {
                string[] rreshtat = File.ReadAllLines(emriFile);
                foreach (string rreshti in rreshtat)
                {
                    if (rreshti.StartsWith(CfgEmri))
                    {
                        string[] vlera1Array = rreshti.Split('=');
                        vlera= vlera1Array[1].Trim();
                        // Ekzekutoni vlerën e Vlera1 sipas nevojës suaj
                    }
                }
            }
            return vlera;
        }

        public static bool CheckLinesIndCfg(string CfgEmri)
        {
            if (File.Exists(pathKomplet))
            {
                string[] linjat = File.ReadAllLines(pathKomplet);

                // Modifikoni vlerën e caktuar (p.sh., vlera1)
                for (int i = 0; i < linjat.Length; i++)
                {
                    if (linjat[i].StartsWith(CfgEmri))
                    {
                        return true;
                        break;
                    }
                }
               
            }
            return false;
        }
        public static bool IfFileExcist()=>(File.Exists(pathKomplet));
        public static void ReadCfg(string CfgEmri,string newValue)
        {
            if (File.Exists(pathKomplet))
            {
                string[] linjat = File.ReadAllLines(pathKomplet);

                // Modifikoni vlerën e caktuar (p.sh., vlera1)
                for (int i = 0; i < linjat.Length; i++)
                {
                    if (linjat[i].StartsWith(CfgEmri))
                    {
                        linjat[i] = CfgEmri + " = " + newValue;
                        break;
                    }
                }
                // Shkruani përsëri përmbajtjen në file
                File.WriteAllLines(pathKomplet, linjat);
            }
        }
        public static void IncreaseNumber(string CfgEmri)
        {
            if (File.Exists(pathKomplet))
            {
                string[] linjat = File.ReadAllLines(pathKomplet);

                // Modifikoni vlerën e caktuar (p.sh., vlera1)
                for (int i = 0; i < linjat.Length; i++)
                {
                    if (linjat[i].StartsWith(CfgEmri))
                    {
                        string[] vlera1Array = linjat[i].Split('=');
                        int vlera1 =Convert.ToInt32( vlera1Array[1].Trim());
                        linjat[i] = CfgEmri + " = " + ++vlera1;
                        break;
                    }
                }
                // Shkruani përsëri përmbajtjen në file
                File.WriteAllLines(pathKomplet, linjat);
            }
        }
        public static int ReturntValue(string CfgEmri)
        {
            try
            {
                if (File.Exists(pathKomplet))
                {
                    string[] linjat = File.ReadAllLines(pathKomplet);

                    // Modifikoni vlerën e caktuar (p.sh., vlera1)
                    for (int i = 0; i < linjat.Length; i++)
                    {
                        if (linjat[i].StartsWith(CfgEmri))
                        {
                            string[] vlera1Array = linjat[i].Split('=');
                            int vlera1 = Convert.ToInt32(vlera1Array[1].Trim());
                            return vlera1;
                            break;
                        }
                    }

                }

            }
            catch 
            {
            }
           
            return 0;
        }
    }
}
