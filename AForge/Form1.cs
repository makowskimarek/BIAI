using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Neuro;
using AForge.Neuro.Learning;
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
    public partial class Form1 : Form
    {
        private int liczbaRekordow;
        double[][] input;
        double[][] output;
        double[][] inputTest;
        double[][] outputTest;
        Network network;

        int liczbaWejsc;
        int liczbaWyjsc;
        List<String> errorRaportList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            //outputTestZSieci = new List<double[]>();
            network = null;
        }

        private void buttonOtworz_Click(object sender, EventArgs e)
        {
            liczbaRekordow = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt; |All files(*.*)|*.*;";
            openFileDialog.Title = "Wybierz plik z danymi do nauki";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                labelSciezka.Text = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);

                importujDane(lines);

                if (input == null || output == null)
                    labelStatusUczenie.Text = "Blad podczas otwierania pliku";
                else
                {
                    labelRekordy.Text = liczbaRekordow.ToString() + "/" + lines.Length.ToString();
                    labelStatusUczenie.Text = "Plik został otworzony";
                }

            }
        }

        private void buttonNauka_Click(object sender, EventArgs e)
        {
            if (input == null || output == null || input.Length == 0 || output.Length == 0)
            {
                labelStatusUczenie.Text = "Brak danych do nauki";
                return;
            }

            labelStatusUczenie.Text = "Sieć neuronowa uczy się...";
            labelStatusUczenie.Update();

            uczSiec(comboAlgorytm.Text, input, output);

            labelStatusUczenie.Text = "Sieć wygenerowana poprawnie";

            double wynik = TestSieci.testujSiec(network, inputTest, outputTest);
            labelWynikZSieci.Text = wynik.ToString("F") + " %";
        }

        public void uczSiec(string algorytm, double[][] linput, double[][] loutput)
        {
            errorRaportList.Clear();
            int poprawneOszacowania = 0;
            if (checkPoprawneOszacowania.Checked)
            {
                if (inputTest == null || outputTest == null ||
                    inputTest.Length < numericPoprawneOszacowania.Value || outputTest.Length < numericPoprawneOszacowania.Value)
                    return;
                poprawneOszacowania = (int)numericPoprawneOszacowania.Value;
            }

            if (algorytm.Equals("BackPropagationLearning"))
            {
                network = new ActivationNetwork(new SigmoidFunction(2), liczbaWejsc, (int)numericFirstLayer.Value, liczbaWyjsc);
                BackPropagationLearning teacher = new BackPropagationLearning((ActivationNetwork)network);
                int epoch = 0;
                int wynikValid = 0;
                while (true)
                {
                    double error = teacher.RunEpoch(linput, loutput);
                    error = error / linput.Length;
                    errorRaportList.Add(error.ToString());
                    if (epoch == numericEpoch.Value)
                        break;

                        wynikValid = TestSieci.testujSiecOkreslone(network, inputTest, outputTest, poprawneOszacowania);
                        if (wynikValid == 100)
                        {
                            epoch++;
                            aktualizujCzasiGradient(epoch, error, wynikValid);
                            break;
                        }
 
                    epoch++;
                    aktualizujCzasiGradient(epoch, error, wynikValid);
                }
            }else if (algorytm.Equals("EvolutionaryLearning"))
            {
                network = new ActivationNetwork(new BipolarSigmoidFunction(2), liczbaWejsc, (int)numericFirstLayer.Value, liczbaWyjsc);
                EvolutionaryLearning teacher = new EvolutionaryLearning((ActivationNetwork)network, 100);
                int epoch = 0;
                int wynikValid = 0;
                while (true)
                {
                    double error = teacher.RunEpoch(linput, loutput);
                    error = error / linput.Length;
                    errorRaportList.Add(error.ToString());
                    if (epoch == numericEpoch.Value)
                        break;
                    wynikValid = TestSieci.testujSiecOkreslone(network, inputTest, outputTest, poprawneOszacowania);
                    if (wynikValid == 100)
                    {
                        epoch++;
                        aktualizujCzasiGradient(epoch, error, wynikValid);
                        break;
                    }
                    epoch++;
                    aktualizujCzasiGradient(epoch, error, wynikValid);
                }
            }
            else if (algorytm.Equals("ResilientBackpropagationLearning"))
            {
                network = new ActivationNetwork(new SigmoidFunction(2), liczbaWejsc, (int)numericFirstLayer.Value, liczbaWyjsc);
                ResilientBackpropagationLearning teacher = new ResilientBackpropagationLearning((ActivationNetwork)network);
                int epoch = 0;
                int wynikValid = 0;
                while (true)
                {
                    double error = teacher.RunEpoch(linput, loutput);
                    error = error / linput.Length;
                    errorRaportList.Add(error.ToString());
                    if (epoch == numericEpoch.Value)
                        break;
                    wynikValid = TestSieci.testujSiecOkreslone(network, inputTest, outputTest, poprawneOszacowania);
                    if (wynikValid == 100)
                    {
                        epoch++;
                        aktualizujCzasiGradient(epoch, error, wynikValid);
                        break;
                    }

                    epoch++;
                    aktualizujCzasiGradient(epoch, error, wynikValid);
                }
            }
        }

        private void aktualizujCzasiGradient(int epoch, double error, double wynikZRzedu)
        {
            labelCzasNauki.Text = epoch.ToString();
            labelCzasNauki.Update();
            labelLearningRate.Text = error.ToString();
            labelLearningRate.Update();
            labelPoprawneOszacowaniaWynik.Text = wynikZRzedu.ToString();
            labelLearningRate.Update();
        }

        private void importujDane(string[] lines)
        {
            List<double[]> tabelaWejsciowa = new List<double[]>();
            List<double[]> tabelaWyjsciowa = new List<double[]>();
            odczytZWierszy(lines, tabelaWejsciowa, tabelaWyjsciowa);
            if (tabelaWejsciowa.Count == 0 || tabelaWyjsciowa.Count == 0)
                return;
            
            tabelaWejsciowa = Konwerter.normalize(tabelaWejsciowa.ToArray());

            int liczbaDanychTestowych = (int)(liczbaRekordow * (numericLiczbaTestowych.Value / 100));
            input = new double[liczbaRekordow - liczbaDanychTestowych][];
            output = new double[liczbaRekordow - liczbaDanychTestowych][];
            inputTest = new double[liczbaDanychTestowych][];
            outputTest = new double[liczbaDanychTestowych][];

            int index = 0;
            for (index = 0; index < liczbaRekordow - liczbaDanychTestowych; index++)
            {
                input[index] = tabelaWejsciowa[index];
                output[index] = tabelaWyjsciowa[index];
            }

            int indexTablicyTestowej = 0;
            for (; index < liczbaRekordow; index++)
            {
                inputTest[indexTablicyTestowej] = tabelaWejsciowa[index];
                outputTest[indexTablicyTestowej] = tabelaWyjsciowa[index];
                indexTablicyTestowej++;
            }

            labelTestyLiczba.Text = liczbaDanychTestowych.ToString();
            labelNaukaLiczba.Text = (liczbaRekordow - liczbaDanychTestowych).ToString();
        }

        private void odczytZWierszy(string[] lines, List<double[]> tabelaWejsciowa, List<double[]> tabelaWyjsciowa)
        {
            liczbaWejsc = liczbaWierszyOdczyt();
            liczbaWyjsc = 1;
            numericFirstLayer.Maximum = liczbaWejsc;

            int buforWyniku = -1;
            foreach (String line in lines)
            {
                string[] row = line.Split(',');
                if (row.Length != 15) continue;

                double[] daneWejsciowe = new double[liczbaWejsc];
                double[] daneWyjsciowe = new double[liczbaWyjsc];

                int licznik = 0;
                if (checkAge.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[0]);
                    licznik++;
                }

                if (checkWorkclass.Checked)
                {
                    buforWyniku = Konwerter.workclassToint(row[1].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkfnlwgt.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[2]);
                    licznik++;
                }

                if (checkEducation.Checked)
                {
                    buforWyniku = Konwerter.educationToint(row[3].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkEducationNum.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[4]);
                    licznik++;
                }

                if (checkMaritialStatus.Checked)
                {
                    buforWyniku = Konwerter.maritalStatusToint(row[5].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkOccupation.Checked)
                {
                    buforWyniku = Konwerter.occupationToint(row[6].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkRelationship.Checked)
                {
                    buforWyniku = Konwerter.relationshipToint(row[7].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkRace.Checked)
                {
                    buforWyniku = Konwerter.raceToint(row[8].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkSex.Checked)
                {
                    buforWyniku = Konwerter.sexToint(row[9].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                if (checkCapitalGain.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[10].Trim());
                    licznik++;
                }

                if (checkCapitalLoss.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[11].Trim());
                    licznik++;
                }

                if (checkHoursPerWeek.Checked)
                {
                    daneWejsciowe[licznik] = Int32.Parse(row[12]);
                    licznik++;
                }

                if (checkNational.Checked)
                {
                    buforWyniku = Konwerter.nativeCountryToint(row[13].Trim());
                    if (buforWyniku == -1) continue;
                    daneWejsciowe[licznik] = buforWyniku;
                    licznik++;
                }

                /*buforWyniku = konwerter.resultToint(row[14].Trim());
                if (buforWyniku == -1) continue;
                daneWejsciowe[14] = buforWyniku;*/

                buforWyniku = Konwerter.resultToint(row[14].Trim());
                if (buforWyniku == -1) continue;
                daneWyjsciowe[0] = buforWyniku;

                tabelaWejsciowa.Add(daneWejsciowe);
                tabelaWyjsciowa.Add(daneWyjsciowe);

                liczbaRekordow++;
            }
        }

        private int liczbaWierszyOdczyt()
        {
            int result = 0;
            if (checkAge.Checked)
                result++;
            if (checkWorkclass.Checked)
                result++;
            if (checkfnlwgt.Checked)
                result++;
            if (checkEducation.Checked)
                result++;
            if (checkEducationNum.Checked)
                result++;
            if (checkMaritialStatus.Checked)
                result++;
            if (checkOccupation.Checked)
                result++;
            if (checkRelationship.Checked)
                result++;
            if (checkRace.Checked)
                result++;
            if (checkSex.Checked)
                result++;
            if (checkCapitalGain.Checked)
                result++;
            if (checkCapitalLoss.Checked)
                result++;
            if (checkHoursPerWeek.Checked)
                result++;
            if (checkNational.Checked)
                result++;
            return result;
        }

        private void buttonZapiszDane_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt;";
            saveFileDialog1.Title = "Zapisz przygotowane dane do pliku";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                double[][] inputt = input;
                double[][] outputt = output;
                double[][] inputTestt = inputTest;
                double[][] outputTestt = outputTest;
                Zapisywacz.zapiszDaneDoPliku(saveFileDialog1.FileName,
                    inputt,
                    inputTestt,
                    outputt,
                    outputTestt);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if(network == null)
            {
                labelStatusUczenie.Text = "Nie wygenerowno sieci";
                return;
            }
            if (inputTest == null || outputTest == null)
            {
                labelStatusUczenie.Text = "Brak danych";
                return;
            }

            double wynik = TestSieci.testujSiec(network, inputTest, outputTest);
            labelWynikZSieci.Text = wynik.ToString("F") + " %";
        }

        

        private void przygotujDaneDoTestow(double[][] inputCaly, double[][] outputCaly, double[][] inputDoRaportu, double[][] outputDoRaportu, int ilePrzekopiowac) {
            inputDoRaportu = new double[ilePrzekopiowac][];
            outputDoRaportu = new double[ilePrzekopiowac][];

            for(int i = 0; i< ilePrzekopiowac; i++)
            {
                inputDoRaportu[i] = inputCaly[i];
                outputDoRaportu[i] = outputCaly[i];
            }
        }

        private void status(string status)
        {
            labelRaportStatus.Text = status;
            labelRaportStatus.Update();
            
        }

        private double uczSiecFann(double[][] linput, double[][] loutput)
        {
            //tworzenie pliku testowego 
            TrainingData data = new TrainingData();
            data.SetTrainData(Konwerter.doubleArrayToFloat(linput), Konwerter.doubleArrayToFloat(loutput));

            uint num_input = (uint)liczbaWejsc;
            uint num_output = (uint)liczbaWyjsc;
            uint num_layers = 3;
            uint num_neurons_hidden = (uint)numericFirstLayer.Value;
            float desired_error = 0;
            uint max_epochs = (uint)numericEpoch.Value;
            uint epochs_between_reports = 1;

            using (NeuralNet net = new NeuralNet(NetworkType.LAYER, num_layers, num_input, num_neurons_hidden, num_output))
            {
                net.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC;
                net.ActivationFunctionOutput = ActivationFunction.SIGMOID_SYMMETRIC;

                net.TrainStopFunction = StopFunction.STOPFUNC_BIT;
                net.BitFailLimit = 0.01F;
                
                if (comboAlgorytmFann.Text.Equals("BATCH"))
                    net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_BATCH;
                else if(comboAlgorytmFann.Text.Equals("INCREMENTAL"))
                    net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_INCREMENTAL;
                else if (comboAlgorytmFann.Text.Equals("QUICKPROP"))
                    net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_QUICKPROP;
                else if (comboAlgorytmFann.Text.Equals("RPROP"))
                    net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_RPROP;

                net.InitWeights(data);

                

                net.TrainOnData(data, max_epochs, epochs_between_reports, desired_error);
                

                return TestSieci.testujSiecFann(net, inputTest, outputTest);
            }
        }

        private void buttonNaukaFann_Click(object sender, EventArgs e)
        {
            labelStatusFann.Text = "Start training network.";
            labelStatusFann.Update();

            double wynik = uczSiecFann(input, output);

            labelStatusFann.Text = "Finish training network.";
            labelStatusFann.Update();

            labelWynikZSieci.Text = wynik.ToString("F");
        }

        private void buttonRaportAfroge_Click(object sender, EventArgs e)
        {
            int maxEpoch = 200;
            int[] tableEpoch = { 20, 50, 100, 200, 500, 1000 };
            
            checkPoprawneOszacowania.Checked = false;
            comboAlgorytm.Text = comboAlgorytmRaport.Text;
            List<string> raport = new List<string>();
            double wynik1 = 0;
            status("Rozpoczecie");
            raport.Add("Liczba danych do nauki - " + labelNaukaLiczba.Text);
            raport.Add("Liczba danych do testow - " + labelTestyLiczba.Text);


            raport.Add("Algorytm : " + comboAlgorytm.Text);
            raport.Add("Test : Liczba neuronów w pierwszej warstwie");
            raport.Add("Czas nauki - " + maxEpoch.ToString() + " epok");
            raport.Add("Wyniki : ");
            raport.Add("liczba neuronow;error;wynik");
            numericEpoch.Value = maxEpoch;

            for (int i = 1; i < liczbaWejsc + 1; i++)
            {
                numericFirstLayer.Value = i;
                uczSiec(comboAlgorytm.Text, input, output);
                wynik1 = TestSieci.testujSiec(network, inputTest, outputTest);
                raport.Add(i.ToString() + ";" + labelLearningRate.Text + ";" + wynik1.ToString("F"));
                status(comboAlgorytm.Text + ": pierwsza warstwa : " + i.ToString() + " / " + liczbaWejsc.ToString());
            }

            raport.Add("Algorytm : " + comboAlgorytm.Text);
            raport.Add("Test : Czas nauki liczony w epokach");
            raport.Add("Liczba neuronow w pierwszej warstwie - 4");
            raport.Add("Wyniki : ");
            raport.Add("czas;error;wynik");
            numericFirstLayer.Value = 4;
            for (int i = 0; i < tableEpoch.Length; i++)
            {
                numericEpoch.Value = tableEpoch[i];
                uczSiec(comboAlgorytm.Text, input, output);
                wynik1 = TestSieci.testujSiec(network, inputTest, outputTest);
                raport.Add(tableEpoch[i].ToString() + ";" + labelLearningRate.Text + ";" + wynik1.ToString("F"));
                status(comboAlgorytm.Text + ": czas : " + tableEpoch[i].ToString() + " / " + maxEpoch * 5);
            }

            raport.Add("Algorytm : " + comboAlgorytm.Text);
            raport.Add("Test : Czas nauki liczony w epokach2");
            raport.Add("Liczba neuronow w pierwszej warstwie - 4");
            raport.Add("Wyniki : ");
            raport.Add("czas;error;wynik");
            numericFirstLayer.Value = 4;
            numericEpoch.Value = 200;
            
            uczSiec(comboAlgorytm.Text, input, output);
            int ii = 0;
            raport.Add("epoch;error");
            foreach (String str in errorRaportList)
            {
                ii++;
                raport.Add(ii + ";" + str);
            }
            


            System.IO.File.WriteAllLines(comboAlgorytm.Text + "Raport.txt", raport.ToArray());
            status("Raport wygenerowano");
        }

        private void buttonRaportFann_Click(object sender, EventArgs e)
        {
            int maxEpoch = 200;
            int[] tableEpoch = { 20, 50, 100, 200, 500, 1000 };

            checkPoprawneOszacowania.Checked = false;
            comboAlgorytmFann.Text = comboRaportAlgorytmFann.Text;
            List<string> raport = new List<string>();
            double wynik1 = 0;
            status("Rozpoczecie");
            raport.Add("Liczba danych do nauki - " + labelNaukaLiczba.Text);
            raport.Add("Liczba danych do testow - " + labelTestyLiczba.Text);


            raport.Add("Algorytm : " + comboAlgorytmFann.Text);
            raport.Add("Test : Liczba neuronów w pierwszej warstwie");
            raport.Add("Czas nauki - " + maxEpoch.ToString() + " epok");
            raport.Add("Wyniki : ");
            raport.Add("liczba neuronow;wynik");
            numericEpoch.Value = maxEpoch;

            for (int i = 1; i < liczbaWejsc + 1; i++)
            {
                numericFirstLayer.Value = i;
                wynik1 = uczSiecFann(input, output);
                raport.Add(i.ToString() + ";" + wynik1.ToString("F"));
                status(comboAlgorytm.Text + ": pierwsza warstwa : " + i.ToString() + " / " + liczbaWejsc.ToString());
            }

            raport.Add("Algorytm : " + comboAlgorytmFann.Text);
            raport.Add("Test : Czas nauki liczony w epokach");
            raport.Add("Liczba neuronow w pierwszej warstwie - 4");
            raport.Add("Wyniki : ");
            raport.Add("czas;wynik");
            numericFirstLayer.Value = 4;
            for (int i = 0; i < tableEpoch.Length; i++)
            {
                numericEpoch.Value = tableEpoch[i];
                wynik1 = uczSiecFann(input, output);
                raport.Add(tableEpoch[i].ToString() + ";" + wynik1.ToString("F"));
                status(comboAlgorytm.Text + ": czas : " + tableEpoch[i].ToString() + " / " + maxEpoch * 5);
            }

            System.IO.File.WriteAllLines(comboAlgorytmFann.Text + "Raport.txt", raport.ToArray());
            status("Raport wygenerowano");
        }
    }
}
        
    
