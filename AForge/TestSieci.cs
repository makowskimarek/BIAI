using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Neuro;
using FANNCSharp;
#if FANN_FIXED
using FANNCSharp.Fixed;
using DataType = System.Int32;
#elif FANN_DOUBLE
using FANNCSharp.Double;
using DataType = System.Double;
#else
using FANNCSharp.Float;
using DataType = System.Single;
#endif

namespace AForgeApp
{
    static class TestSieci
    {
        public static double testujSiec(Network network, double[][] input, double[][] output)
        {
            if (input == null || output == null)
                return 0;

            double[][] outputTestZSieci = new double[input.Length][];
            try
            {
                for (int index = 0; index < input.Length; index++)
                {
                    outputTestZSieci[index] = network.Compute(input[index]);
                }

            }
            catch (Exception)
            {
                return 0;
            }

            int liczbaPoprawnych = 0;
            for (int index = 0; index < input.Length; index++)
            {
                double wynikZSieci = Math.Round(outputTestZSieci[index][0], 0);
                if (wynikZSieci == output[index][0])
                    liczbaPoprawnych++;
            }

            return (double)((double)liczbaPoprawnych / (double)input.Length) * 100;

        }

        public static int testujSiecOkreslone(Network network, double[][] input, double[][] output, int enumerOfTestCheckt)
        {
            if (input == null || output == null)
                return 0;
            Random rnd = new Random();

            double[][] outputTestZSieci = new double[enumerOfTestCheckt][];
            double[][] inputTestCheck = new double[enumerOfTestCheckt][];
            double[][] outputTestCheck = new double[enumerOfTestCheckt][];

            for(int i=0;i< enumerOfTestCheckt; i++)
            {
                int index = rnd.Next(0,input.Length);
                inputTestCheck[i] = input[index];
                outputTestCheck[i] = output[index];
            }
            try
            {
                for (int index = 0; index < enumerOfTestCheckt; index++)
                {
                    outputTestZSieci[index] = network.Compute(inputTestCheck[index]);
                }

            }
            catch (Exception)
            {
                return 0;
            }

            int liczbaPoprawnych = 0;
            for (int index = 0; index < enumerOfTestCheckt; index++)
            {
                double wynikZSieci = Math.Round(outputTestZSieci[index][0], 0);
                if (wynikZSieci == outputTestCheck[index][0])
                    liczbaPoprawnych++;
                else
                    liczbaPoprawnych = 0;
            }

            return liczbaPoprawnych;

        }

        public static double testujSiecFann(NeuralNet net, double[][] input, double[][] output)
        {
            if (input == null || output == null)
                return 0;

            float[][] outputTestZSieci = new float[input.Length][];
            float[][] inputFloat = Konwerter.doubleArrayToFloat(input);
            float[][] outputFloat = Konwerter.doubleArrayToFloat(output);
            try
            {
                for (int index = 0; index < input.Length; index++)
                {
                    outputTestZSieci[index] = net.Run(inputFloat[index]);
                }

            }
            catch (Exception)
            {
                return 0;
            }

            int liczbaPoprawnych = 0;
            for (int index = 0; index < input.Length; index++)
            {
                double wynikZSieci = Math.Round(outputTestZSieci[index][0], 0);
                if (wynikZSieci == outputFloat[index][0])
                    liczbaPoprawnych++;
            }

            return (double)((double)liczbaPoprawnych / (double)input.Length) * 100;

        }

    }
}
