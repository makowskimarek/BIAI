using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForgeApp
{
    
      static class Konwerter
    {
        public static float[][] doubleArrayToFloat(double[][] array)
        {
            float[][] result = new float[array.Length][];
            for(int i = 0; i< result.Length; i++)
            {
                result[i] = new float[array[0].Length];
                for(int j = 0;j< result[0].Length; j++)
                {
                    result[i][j] = (float)array[i][j];
                }
            }
            return result;
        }

        public static string doubleArrayToString(double[] array)
        {
            string result = "";
            for(int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }

        public static int workclassToint(string workclass)
        {

            //Private, Self-emp-not-inc, Self-emp-inc, Federal-gov, Local-gov, State-gov, Without-pay, Never-worked
            if (workclass.Equals("Never-worked"))
                return 0;
           else if (workclass==("Private"))
                return 1;
            else if (workclass.Equals("Self-emp-inc"))
                return 2;
            else if (workclass.Equals("Self-emp-not-inc"))
                return 3;
            else if (workclass.Equals("Federal-gov"))
                return 4;
            else if (workclass.Equals("Local-gov"))
                return 5;
            else if (workclass.Equals("State-gov"))
                return 6;
            else if (workclass.Equals("Without-pay"))
                return 7;

            return -1;

        }

        public static int educationToint(String workclass)
        {
            //Bachelors, Some-college, 11th, HS-grad, Prof-school, Assoc-acdm, Assoc-voc, 9th, 7th-8th, 12th, Masters, 1st-4th, 10th, Doctorate, 5th-6th, Preschool.
            if (workclass.Equals("Preschool"))
                return 0;
            else if (workclass.Equals("Bachelors"))
                return 1;
            else if (workclass.Equals("Some-college"))
                return 2;
            else if (workclass.Equals("11th"))
                return 3;
            else if (workclass.Equals("HS-grad"))
                return 4;
            else if (workclass.Equals("Prof-school"))
                return 5;
            else if (workclass.Equals("Assoc-acdm"))
                return 6;
            else if (workclass.Equals("Assoc-voc"))
                return 7;
            else if (workclass.Equals("9th"))
                return 8;
            else if (workclass.Equals("7th-8th"))
                return 9;
            else if (workclass.Equals("12th"))
                return 10;
            else if (workclass.Equals("Masters"))
                return 11;
            else if (workclass.Equals("1st-4th"))
                return 12;
            else if (workclass.Equals("10th"))
                return 13;
            else if (workclass.Equals("Doctorate"))
                return 14;
            else if (workclass.Equals("5th-6th"))
                return 15;

            return -1;

        }

        public static int maritalStatusToint(String workclass)
        {
            //Married-civ-spouse, Divorced, Never-married, Separated, Widowed, Married-spouse-absent, Married-AF-spouse.
            if (workclass.Equals("Married-AF-spouse"))
                return 0;
            else if (workclass.Equals("Married-civ-spouse"))
                return 1;
            else if (workclass==("Divorced"))
                return 2;
            else if (workclass.Equals("Never-married"))
                return 3;
            else if (workclass.Equals("Separated"))
                return 4;
            else if (workclass.Equals("Widowed"))
                return 5;
            else if (workclass.Equals("Married-spouse-absent"))
                return 6;
            

            return -1;

        }

        public static int occupationToint(String workclass)
        {
            //Tech-support, Craft-repair, Other-service, Sales, Exec-managerial, Prof-specialty, Handlers-cleaners, Machine-op-inspct, Adm-clerical, 
            //Farming-fishing, Transport-moving, Priv-house-serv, Protective-serv, Armed-Forces.
            if (workclass.Equals("Armed-Forces"))
                return 0;
            else if (workclass.Equals("Tech-support"))
                return 1;
            else if (workclass.Equals("Craft-repair"))
                return 2;
            else if (workclass.Equals("Other-service"))
                return 3;
            else if (workclass.Equals("Sales"))
                return 4;
            else if (workclass.Equals("Exec-managerial"))
                return 5;
            else if (workclass.Equals("Prof-specialty"))
                return 6;
            else if (workclass.Equals("Handlers-cleaners"))
                return 7;
            else if (workclass.Equals("Machine-op-inspct"))
                return 8;
            else if (workclass.Equals("Adm-clerical"))
                return 9;
            else if (workclass.Equals("Farming-fishing"))
                return 10;
            else if (workclass.Equals("Transport-moving"))
                return 11;
            else if (workclass.Equals("Priv-house-serv"))
                return 12;
            else if (workclass.Equals("Protective-serv"))
                return 13;
            

            return -1;

        }

        public static int relationshipToint(String workclass)
        {
            //Wife, Own-child, Husband, Not-in-family, Other-relative, Unmarried
            if (workclass.Equals("Unmarried"))
                return 0;
            else if (workclass.Equals("Wife"))
                return 1;
            else if (workclass.Equals("Own-child"))
                return 2;
            else if (workclass.Equals("Husband"))
                return 3;
            else if (workclass.Equals("Not-in-family"))
                return 4;
            else if (workclass.Equals("Other-relative"))
                return 5;
            

            return -1;

        }

        public static int raceToint(String workclass)
        {
            //White, Asian-Pac-Islander, Amer-Indian-Eskimo, Other, Black

            if (workclass.Equals("White"))
                return 1;
            else if (workclass.Equals("Asian-Pac-Islander"))
                return 2;
            else if (workclass.Equals("Amer-Indian-Eskimo"))
                return 3;
            else if (workclass.Equals("Other"))
                return 4;
            else if (workclass.Equals("Black"))
                return 0;

            return -1;

        }

        public static int sexToint(String workclass)
        {
            //Female, Male
            if (workclass.Equals("Female"))
                return 1;
            else if (workclass.Equals("Male"))
                return 0;

            return -1;

        }

        public static int nativeCountryToint(String workclass)
        {
            //United-States, Cambodia, England, Puerto-Rico, Canada, Germany, Outlying-US(Guam-USVI-etc), 
            //India, Japan, Greece, South, China, Cuba, Iran, Honduras, Philippines, Italy, Poland, Jamaica, Vietnam,
            //Mexico, Portugal, Ireland, France, Dominican-Republic, Laos, Ecuador, Taiwan, Haiti, Columbia, Hungary, 
            //Guatemala, Nicaragua, Scotland, Thailand, Yugoslavia, El-Salvador, Trinadad&Tobago, Peru, Hong, Holand-Netherlands.
            if (workclass.Equals("United-States"))
                return 1;
            else if (workclass.Equals("Cambodia"))
                return 2;
            else if (workclass.Equals("England"))
                return 3;
            else if (workclass.Equals("Puerto-Rico"))
                return 4;
            else if (workclass.Equals("Canada"))
                return 5;
            else if (workclass.Equals("Germany"))
                return 6;
            else if (workclass.Equals("Outlying-US(Guam-USVI-etc)"))
                return 7;
            else if (workclass.Equals("India"))
                return 8;
            else if (workclass.Equals("Japan"))
                return 9;
            else if (workclass.Equals("Greece"))
                return 10;
            else if (workclass.Equals("South"))
                return 11;
            else if (workclass.Equals("China"))
                return 12;
            else if (workclass.Equals("Cuba"))
                return 13;
            else if (workclass.Equals("Iran"))
                return 14;
            else if (workclass.Equals("Honduras"))
                return 15;
            else if (workclass.Equals("Philippines"))
                return 16;
            else if (workclass.Equals("Italy"))
                return 17;
            else if (workclass.Equals("Poland"))
                return 18;
            else if (workclass.Equals("Jamaica"))
                return 19;
            else if (workclass.Equals("Vietnam"))
                return 20;
            else if (workclass.Equals("Mexico"))
                return 21;
            else if (workclass.Equals("Portugal"))
                return 22;
            else if (workclass.Equals("Ireland"))
                return 23;
            else if (workclass.Equals("France"))
                return 24;
            else if (workclass.Equals("Dominican-Republic"))
                return 25;
            else if (workclass.Equals("Laos"))
                return 26;
            else if (workclass.Equals("Ecuador"))
                return 27;
            else if (workclass.Equals("Taiwan"))
                return 28;
            else if (workclass.Equals("Haiti"))
                return 29;
            else if (workclass.Equals("Columbia"))
                return 30;
            else if (workclass.Equals("Hungary"))
                return 31;
            else if (workclass.Equals("Guatemala"))
                return 32;
            else if (workclass.Equals("Nicaragua"))
                return 33;
            else if (workclass.Equals("Scotland"))
                return 34;
            else if (workclass.Equals("Thailand"))
                return 35;
            else if (workclass.Equals("Yugoslavia"))
                return 36;
            else if (workclass.Equals("El-Salvador"))
                return 37;
            else if (workclass.Equals("Trinadad&Tobago"))
                return 38;
            else if (workclass.Equals("Peru"))
                return 39;
            else if (workclass.Equals("Hong"))
                return 41;
            else if (workclass.Equals("Holand-Netherlands"))
                return 0;

            return -1;

        }

        public static int resultToint(String workclass)
        {
            //Female, Male
            if (workclass.Equals(">50K"))
                return 1;
            else if (workclass.Equals("<=50K"))
                return 0;

            return -1;

        }

        public static List<double[]> normalize(double[][] data)
        {
            List<double[]> result = new List<double[]>();
            for (int i = 0; i < data.Length; i++)
                result.Add( new double[data[0].Length]);

            double max = 0;
            for (int kolumna = 0; kolumna < data[0].Length; kolumna++)
            {
                max = 0;
                for (int input = 0; input < data.Length; input++)
                {
                    if (max < data[input][kolumna]) max = data[input][kolumna];
                }

                if (max > 0)
                {
                    for (int input = 0; input < data.Length; input++)
                    {
                        result[input][kolumna] = (double)((double)data[input][kolumna] / (double)max);
                    }
                }
            }

            return result;
        }
    }

    
}
