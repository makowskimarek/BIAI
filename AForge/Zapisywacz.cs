using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForgeApp
{
    static class Zapisywacz
    {
        public static void zapiszDaneDoPliku(string nazwaPliku, double[][] inputt, double[][] inputTestt, double[][] outputt, double[][] outputTestt)
        {
            string[] wiersze = new string[inputt.Length + inputTestt.Length];
            int i;
            for (i = 0; i < inputt.Length; i++)
            {
                string wiersz = "";
                for (int j = 0; j < (inputt[0].Length - 2); j++)
                {
                    wiersz += inputt[i][j].ToString() + ";";
                }
                wiersz += inputt[i][inputt[i].Length - 1].ToString();
                wiersz = wiersz.Replace(",", ".");
                wiersz = wiersz.Replace(";", ",");
                wiersze[i] = wiersz;
            }
            String nazwaPliku1 = nazwaPliku.Replace(".txt", "DANE.txt");
            System.IO.File.WriteAllLines(nazwaPliku1, wiersze);

            for (i = 0; i < outputt.Length; i++)
            {
                wiersze[i] = outputt[i][outputt[0].Length - 1].ToString().Replace(",", ".");
            }
            String nazwaPliku2 = nazwaPliku.Replace(".txt", "TEST.txt");
            System.IO.File.WriteAllLines(nazwaPliku2, wiersze);
            int iTest = 0;
            for (; i < inputt.Length + inputTestt.Length; i++)
            {
                string wiersz = "";
                for (int j = 0; j < inputTestt[0].Length; j++)
                {
                    wiersz += inputTestt[iTest][j].ToString() + ";";
                }

                wiersz += outputTestt[iTest][0].ToString();
                wiersze[i] = wiersz;
                iTest++;
            }

            //System.IO.File.WriteAllLines(nazwaPliku, wiersze);

        }
    }
}
