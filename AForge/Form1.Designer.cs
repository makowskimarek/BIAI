namespace AForgeApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zakladki = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelLearningRate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericEpoch = new System.Windows.Forms.NumericUpDown();
            this.numericPoprawneOszacowania = new System.Windows.Forms.NumericUpDown();
            this.checkPoprawneOszacowania = new System.Windows.Forms.CheckBox();
            this.numericFirstLayer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWynikZSieci = new System.Windows.Forms.Label();
            this.labelWynki = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCzasNauki = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelStatusUczenie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonNauka = new System.Windows.Forms.Button();
            this.comboAlgorytm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonNaukaFann = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboAlgorytmRaport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRaportStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRaportAfroge = new System.Windows.Forms.Button();
            this.labelRekordy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOtworz = new System.Windows.Forms.Button();
            this.labelSciezka = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericLiczbaTestowych = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTestyLiczba = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNaukaLiczba = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZapiszDane = new System.Windows.Forms.Button();
            this.checkAge = new System.Windows.Forms.CheckBox();
            this.checkWorkclass = new System.Windows.Forms.CheckBox();
            this.checkfnlwgt = new System.Windows.Forms.CheckBox();
            this.checkEducation = new System.Windows.Forms.CheckBox();
            this.checkEducationNum = new System.Windows.Forms.CheckBox();
            this.checkMaritialStatus = new System.Windows.Forms.CheckBox();
            this.checkOccupation = new System.Windows.Forms.CheckBox();
            this.checkRelationship = new System.Windows.Forms.CheckBox();
            this.checkRace = new System.Windows.Forms.CheckBox();
            this.checkSex = new System.Windows.Forms.CheckBox();
            this.checkCapitalGain = new System.Windows.Forms.CheckBox();
            this.checkCapitalLoss = new System.Windows.Forms.CheckBox();
            this.checkNational = new System.Windows.Forms.CheckBox();
            this.checkHoursPerWeek = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelPoprawneOszacowaniaWynik = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboAlgorytmFann = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStatusFann = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboRaportAlgorytmFann = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonRaportFann = new System.Windows.Forms.Button();
            this.zakladki.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPoprawneOszacowania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstLayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLiczbaTestowych)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // zakladki
            // 
            this.zakladki.Controls.Add(this.tabPage1);
            this.zakladki.Controls.Add(this.tabPage2);
            this.zakladki.Controls.Add(this.tabPage3);
            this.zakladki.Location = new System.Drawing.Point(-1, 0);
            this.zakladki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zakladki.Name = "zakladki";
            this.zakladki.SelectedIndex = 0;
            this.zakladki.Size = new System.Drawing.Size(466, 365);
            this.zakladki.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPoprawneOszacowaniaWynik);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.labelLearningRate);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.buttonTest);
            this.tabPage1.Controls.Add(this.labelCzasNauki);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.labelStatusUczenie);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.buttonNauka);
            this.tabPage1.Controls.Add(this.comboAlgorytm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(458, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AForge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelLearningRate
            // 
            this.labelLearningRate.AutoSize = true;
            this.labelLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLearningRate.Location = new System.Drawing.Point(82, 243);
            this.labelLearningRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLearningRate.Name = "labelLearningRate";
            this.labelLearningRate.Size = new System.Drawing.Size(15, 20);
            this.labelLearningRate.TabIndex = 24;
            this.labelLearningRate.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(12, 243);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Error : ";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(181, 57);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(167, 48);
            this.buttonTest.TabIndex = 22;
            this.buttonTest.Text = "Rozpocznij test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.numericEpoch);
            this.groupBox5.Controls.Add(this.numericPoprawneOszacowania);
            this.groupBox5.Controls.Add(this.checkPoprawneOszacowania);
            this.groupBox5.Location = new System.Drawing.Point(7, 79);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(333, 153);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Warunek zatrzymania nauki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Maksymalny czas nauki (epoch) :";
            // 
            // numericEpoch
            // 
            this.numericEpoch.Location = new System.Drawing.Point(12, 50);
            this.numericEpoch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericEpoch.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEpoch.Name = "numericEpoch";
            this.numericEpoch.Size = new System.Drawing.Size(108, 22);
            this.numericEpoch.TabIndex = 15;
            this.numericEpoch.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericPoprawneOszacowania
            // 
            this.numericPoprawneOszacowania.Location = new System.Drawing.Point(12, 111);
            this.numericPoprawneOszacowania.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericPoprawneOszacowania.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPoprawneOszacowania.Name = "numericPoprawneOszacowania";
            this.numericPoprawneOszacowania.Size = new System.Drawing.Size(68, 22);
            this.numericPoprawneOszacowania.TabIndex = 23;
            this.numericPoprawneOszacowania.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // checkPoprawneOszacowania
            // 
            this.checkPoprawneOszacowania.AutoSize = true;
            this.checkPoprawneOszacowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkPoprawneOszacowania.Location = new System.Drawing.Point(12, 82);
            this.checkPoprawneOszacowania.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkPoprawneOszacowania.Name = "checkPoprawneOszacowania";
            this.checkPoprawneOszacowania.Size = new System.Drawing.Size(293, 21);
            this.checkPoprawneOszacowania.TabIndex = 22;
            this.checkPoprawneOszacowania.Text = "Liczba poprawnych oszacowań pod rząd :";
            this.checkPoprawneOszacowania.UseVisualStyleBackColor = true;
            // 
            // numericFirstLayer
            // 
            this.numericFirstLayer.Location = new System.Drawing.Point(15, 47);
            this.numericFirstLayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericFirstLayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFirstLayer.Name = "numericFirstLayer";
            this.numericFirstLayer.Size = new System.Drawing.Size(68, 22);
            this.numericFirstLayer.TabIndex = 20;
            this.numericFirstLayer.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWynikZSieci);
            this.groupBox1.Controls.Add(this.labelWynki);
            this.groupBox1.Location = new System.Drawing.Point(7, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(333, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // labelWynikZSieci
            // 
            this.labelWynikZSieci.AutoSize = true;
            this.labelWynikZSieci.Location = new System.Drawing.Point(219, 38);
            this.labelWynikZSieci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynikZSieci.Name = "labelWynikZSieci";
            this.labelWynikZSieci.Size = new System.Drawing.Size(13, 17);
            this.labelWynikZSieci.TabIndex = 11;
            this.labelWynikZSieci.Text = "-";
            // 
            // labelWynki
            // 
            this.labelWynki.AutoSize = true;
            this.labelWynki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynki.Location = new System.Drawing.Point(8, 36);
            this.labelWynki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynki.Name = "labelWynki";
            this.labelWynki.Size = new System.Drawing.Size(189, 20);
            this.labelWynki.TabIndex = 4;
            this.labelWynki.Text = "Poprawna klasyfikacja : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Liczba neuronow w pierwszej warstwie :";
            // 
            // labelCzasNauki
            // 
            this.labelCzasNauki.AutoSize = true;
            this.labelCzasNauki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCzasNauki.Location = new System.Drawing.Point(167, 273);
            this.labelCzasNauki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCzasNauki.Name = "labelCzasNauki";
            this.labelCzasNauki.Size = new System.Drawing.Size(15, 20);
            this.labelCzasNauki.TabIndex = 13;
            this.labelCzasNauki.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(11, 273);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Czas nauki (epok): ";
            // 
            // labelStatusUczenie
            // 
            this.labelStatusUczenie.AutoSize = true;
            this.labelStatusUczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusUczenie.Location = new System.Drawing.Point(91, 293);
            this.labelStatusUczenie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusUczenie.Name = "labelStatusUczenie";
            this.labelStatusUczenie.Size = new System.Drawing.Size(15, 20);
            this.labelStatusUczenie.TabIndex = 11;
            this.labelStatusUczenie.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(11, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Status : ";
            // 
            // buttonNauka
            // 
            this.buttonNauka.Location = new System.Drawing.Point(7, 57);
            this.buttonNauka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNauka.Name = "buttonNauka";
            this.buttonNauka.Size = new System.Drawing.Size(167, 48);
            this.buttonNauka.TabIndex = 7;
            this.buttonNauka.Text = "Rozpocznij nauke";
            this.buttonNauka.UseVisualStyleBackColor = true;
            this.buttonNauka.Click += new System.EventHandler(this.buttonNauka_Click);
            // 
            // comboAlgorytm
            // 
            this.comboAlgorytm.FormattingEnabled = true;
            this.comboAlgorytm.Items.AddRange(new object[] {
            "BackPropagationLearning",
            "EvolutionaryLearning",
            "ResilientBackpropagationLearning"});
            this.comboAlgorytm.Location = new System.Drawing.Point(171, 20);
            this.comboAlgorytm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAlgorytm.Name = "comboAlgorytm";
            this.comboAlgorytm.Size = new System.Drawing.Size(216, 24);
            this.comboAlgorytm.TabIndex = 6;
            this.comboAlgorytm.Text = "BackPropagationLearning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Algorytm uczenia :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelStatusFann);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.comboAlgorytmFann);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.buttonNaukaFann);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(458, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fann";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonNaukaFann
            // 
            this.buttonNaukaFann.Location = new System.Drawing.Point(9, 56);
            this.buttonNaukaFann.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNaukaFann.Name = "buttonNaukaFann";
            this.buttonNaukaFann.Size = new System.Drawing.Size(167, 48);
            this.buttonNaukaFann.TabIndex = 8;
            this.buttonNaukaFann.Text = "Rozpocznij nauke";
            this.buttonNaukaFann.UseVisualStyleBackColor = true;
            this.buttonNaukaFann.Click += new System.EventHandler(this.buttonNaukaFann_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonRaportFann);
            this.tabPage3.Controls.Add(this.comboRaportAlgorytmFann);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.comboAlgorytmRaport);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.labelRaportStatus);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonRaportAfroge);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(458, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raport";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboAlgorytmRaport
            // 
            this.comboAlgorytmRaport.FormattingEnabled = true;
            this.comboAlgorytmRaport.Items.AddRange(new object[] {
            "BackPropagationLearning",
            "EvolutionaryLearning",
            "ResilientBackpropagationLearning"});
            this.comboAlgorytmRaport.Location = new System.Drawing.Point(15, 103);
            this.comboAlgorytmRaport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAlgorytmRaport.Name = "comboAlgorytmRaport";
            this.comboAlgorytmRaport.Size = new System.Drawing.Size(216, 24);
            this.comboAlgorytmRaport.TabIndex = 15;
            this.comboAlgorytmRaport.Text = "BackPropagationLearning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Algorytm uczenia AForge:";
            // 
            // labelRaportStatus
            // 
            this.labelRaportStatus.AutoSize = true;
            this.labelRaportStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRaportStatus.Location = new System.Drawing.Point(11, 298);
            this.labelRaportStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaportStatus.Name = "labelRaportStatus";
            this.labelRaportStatus.Size = new System.Drawing.Size(15, 20);
            this.labelRaportStatus.TabIndex = 13;
            this.labelRaportStatus.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(11, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status : ";
            // 
            // buttonRaportAfroge
            // 
            this.buttonRaportAfroge.Location = new System.Drawing.Point(15, 20);
            this.buttonRaportAfroge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRaportAfroge.Name = "buttonRaportAfroge";
            this.buttonRaportAfroge.Size = new System.Drawing.Size(249, 50);
            this.buttonRaportAfroge.TabIndex = 0;
            this.buttonRaportAfroge.Text = "Generuj raport AForge";
            this.buttonRaportAfroge.UseVisualStyleBackColor = true;
            this.buttonRaportAfroge.Click += new System.EventHandler(this.buttonRaportAfroge_Click);
            // 
            // labelRekordy
            // 
            this.labelRekordy.AutoSize = true;
            this.labelRekordy.Location = new System.Drawing.Point(272, 87);
            this.labelRekordy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRekordy.Name = "labelRekordy";
            this.labelRekordy.Size = new System.Drawing.Size(13, 17);
            this.labelRekordy.TabIndex = 4;
            this.labelRekordy.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba odczytanych rekordów :";
            // 
            // buttonOtworz
            // 
            this.buttonOtworz.Location = new System.Drawing.Point(15, 27);
            this.buttonOtworz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOtworz.Name = "buttonOtworz";
            this.buttonOtworz.Size = new System.Drawing.Size(167, 48);
            this.buttonOtworz.TabIndex = 2;
            this.buttonOtworz.Text = "Otworz plik";
            this.buttonOtworz.UseVisualStyleBackColor = true;
            this.buttonOtworz.Click += new System.EventHandler(this.buttonOtworz_Click);
            // 
            // labelSciezka
            // 
            this.labelSciezka.AutoSize = true;
            this.labelSciezka.Location = new System.Drawing.Point(11, 20);
            this.labelSciezka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSciezka.Name = "labelSciezka";
            this.labelSciezka.Size = new System.Drawing.Size(13, 17);
            this.labelSciezka.TabIndex = 1;
            this.labelSciezka.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(8, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Procent danych do testow :";
            // 
            // numericLiczbaTestowych
            // 
            this.numericLiczbaTestowych.Location = new System.Drawing.Point(243, 140);
            this.numericLiczbaTestowych.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericLiczbaTestowych.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericLiczbaTestowych.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLiczbaTestowych.Name = "numericLiczbaTestowych";
            this.numericLiczbaTestowych.Size = new System.Drawing.Size(68, 22);
            this.numericLiczbaTestowych.TabIndex = 21;
            this.numericLiczbaTestowych.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(11, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Liczba rekordow do :";
            // 
            // labelTestyLiczba
            // 
            this.labelTestyLiczba.AutoSize = true;
            this.labelTestyLiczba.Location = new System.Drawing.Point(85, 134);
            this.labelTestyLiczba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestyLiczba.Name = "labelTestyLiczba";
            this.labelTestyLiczba.Size = new System.Drawing.Size(13, 17);
            this.labelTestyLiczba.TabIndex = 23;
            this.labelTestyLiczba.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNaukaLiczba);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonZapiszDane);
            this.groupBox2.Controls.Add(this.labelTestyLiczba);
            this.groupBox2.Controls.Add(this.labelRekordy);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonOtworz);
            this.groupBox2.Location = new System.Drawing.Point(3, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(372, 181);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wczytywanie danych";
            // 
            // labelNaukaLiczba
            // 
            this.labelNaukaLiczba.AutoSize = true;
            this.labelNaukaLiczba.Location = new System.Drawing.Point(85, 154);
            this.labelNaukaLiczba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaukaLiczba.Name = "labelNaukaLiczba";
            this.labelNaukaLiczba.Size = new System.Drawing.Size(13, 17);
            this.labelNaukaLiczba.TabIndex = 27;
            this.labelNaukaLiczba.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(11, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "nauki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "testow";
            // 
            // buttonZapiszDane
            // 
            this.buttonZapiszDane.Location = new System.Drawing.Point(189, 27);
            this.buttonZapiszDane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZapiszDane.Name = "buttonZapiszDane";
            this.buttonZapiszDane.Size = new System.Drawing.Size(167, 48);
            this.buttonZapiszDane.TabIndex = 24;
            this.buttonZapiszDane.Text = "Zapisz przygotowane dane";
            this.buttonZapiszDane.UseVisualStyleBackColor = true;
            this.buttonZapiszDane.Click += new System.EventHandler(this.buttonZapiszDane_Click);
            // 
            // checkAge
            // 
            this.checkAge.AutoSize = true;
            this.checkAge.Checked = true;
            this.checkAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAge.Location = new System.Drawing.Point(8, 26);
            this.checkAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAge.Name = "checkAge";
            this.checkAge.Size = new System.Drawing.Size(54, 21);
            this.checkAge.TabIndex = 25;
            this.checkAge.Text = "age";
            this.checkAge.UseVisualStyleBackColor = true;
            // 
            // checkWorkclass
            // 
            this.checkWorkclass.AutoSize = true;
            this.checkWorkclass.Checked = true;
            this.checkWorkclass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWorkclass.Location = new System.Drawing.Point(143, 23);
            this.checkWorkclass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkWorkclass.Name = "checkWorkclass";
            this.checkWorkclass.Size = new System.Drawing.Size(91, 21);
            this.checkWorkclass.TabIndex = 26;
            this.checkWorkclass.Text = "workclass";
            this.checkWorkclass.UseVisualStyleBackColor = true;
            // 
            // checkfnlwgt
            // 
            this.checkfnlwgt.AutoSize = true;
            this.checkfnlwgt.Checked = true;
            this.checkfnlwgt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkfnlwgt.Location = new System.Drawing.Point(248, 23);
            this.checkfnlwgt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkfnlwgt.Name = "checkfnlwgt";
            this.checkfnlwgt.Size = new System.Drawing.Size(66, 21);
            this.checkfnlwgt.TabIndex = 27;
            this.checkfnlwgt.Text = "fnlwgt";
            this.checkfnlwgt.UseVisualStyleBackColor = true;
            // 
            // checkEducation
            // 
            this.checkEducation.AutoSize = true;
            this.checkEducation.Checked = true;
            this.checkEducation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEducation.Location = new System.Drawing.Point(328, 23);
            this.checkEducation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEducation.Name = "checkEducation";
            this.checkEducation.Size = new System.Drawing.Size(92, 21);
            this.checkEducation.TabIndex = 28;
            this.checkEducation.Text = "education";
            this.checkEducation.UseVisualStyleBackColor = true;
            // 
            // checkEducationNum
            // 
            this.checkEducationNum.AutoSize = true;
            this.checkEducationNum.Checked = true;
            this.checkEducationNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEducationNum.Location = new System.Drawing.Point(8, 54);
            this.checkEducationNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEducationNum.Name = "checkEducationNum";
            this.checkEducationNum.Size = new System.Drawing.Size(121, 21);
            this.checkEducationNum.TabIndex = 29;
            this.checkEducationNum.Text = "educationNum";
            this.checkEducationNum.UseVisualStyleBackColor = true;
            // 
            // checkMaritialStatus
            // 
            this.checkMaritialStatus.AutoSize = true;
            this.checkMaritialStatus.Checked = true;
            this.checkMaritialStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaritialStatus.Location = new System.Drawing.Point(7, 112);
            this.checkMaritialStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMaritialStatus.Name = "checkMaritialStatus";
            this.checkMaritialStatus.Size = new System.Drawing.Size(115, 21);
            this.checkMaritialStatus.TabIndex = 30;
            this.checkMaritialStatus.Text = "maritialStatus";
            this.checkMaritialStatus.UseVisualStyleBackColor = true;
            // 
            // checkOccupation
            // 
            this.checkOccupation.AutoSize = true;
            this.checkOccupation.Checked = true;
            this.checkOccupation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOccupation.Location = new System.Drawing.Point(328, 54);
            this.checkOccupation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkOccupation.Name = "checkOccupation";
            this.checkOccupation.Size = new System.Drawing.Size(99, 21);
            this.checkOccupation.TabIndex = 31;
            this.checkOccupation.Text = "occupation";
            this.checkOccupation.UseVisualStyleBackColor = true;
            // 
            // checkRelationship
            // 
            this.checkRelationship.AutoSize = true;
            this.checkRelationship.Checked = true;
            this.checkRelationship.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRelationship.Location = new System.Drawing.Point(143, 82);
            this.checkRelationship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkRelationship.Name = "checkRelationship";
            this.checkRelationship.Size = new System.Drawing.Size(103, 21);
            this.checkRelationship.TabIndex = 32;
            this.checkRelationship.Text = "relationship";
            this.checkRelationship.UseVisualStyleBackColor = true;
            // 
            // checkRace
            // 
            this.checkRace.AutoSize = true;
            this.checkRace.Checked = true;
            this.checkRace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRace.Location = new System.Drawing.Point(248, 54);
            this.checkRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkRace.Name = "checkRace";
            this.checkRace.Size = new System.Drawing.Size(58, 21);
            this.checkRace.TabIndex = 33;
            this.checkRace.Text = "race";
            this.checkRace.UseVisualStyleBackColor = true;
            // 
            // checkSex
            // 
            this.checkSex.AutoSize = true;
            this.checkSex.Checked = true;
            this.checkSex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSex.Location = new System.Drawing.Point(248, 82);
            this.checkSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSex.Name = "checkSex";
            this.checkSex.Size = new System.Drawing.Size(51, 21);
            this.checkSex.TabIndex = 34;
            this.checkSex.Text = "sex";
            this.checkSex.UseVisualStyleBackColor = true;
            // 
            // checkCapitalGain
            // 
            this.checkCapitalGain.AutoSize = true;
            this.checkCapitalGain.Checked = true;
            this.checkCapitalGain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCapitalGain.Location = new System.Drawing.Point(327, 82);
            this.checkCapitalGain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCapitalGain.Name = "checkCapitalGain";
            this.checkCapitalGain.Size = new System.Drawing.Size(102, 21);
            this.checkCapitalGain.TabIndex = 35;
            this.checkCapitalGain.Text = "capital gain";
            this.checkCapitalGain.UseVisualStyleBackColor = true;
            // 
            // checkCapitalLoss
            // 
            this.checkCapitalLoss.AutoSize = true;
            this.checkCapitalLoss.Checked = true;
            this.checkCapitalLoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCapitalLoss.Location = new System.Drawing.Point(143, 111);
            this.checkCapitalLoss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCapitalLoss.Name = "checkCapitalLoss";
            this.checkCapitalLoss.Size = new System.Drawing.Size(100, 21);
            this.checkCapitalLoss.TabIndex = 36;
            this.checkCapitalLoss.Text = "capital loss";
            this.checkCapitalLoss.UseVisualStyleBackColor = true;
            // 
            // checkNational
            // 
            this.checkNational.AutoSize = true;
            this.checkNational.Checked = true;
            this.checkNational.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNational.Location = new System.Drawing.Point(143, 52);
            this.checkNational.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkNational.Name = "checkNational";
            this.checkNational.Size = new System.Drawing.Size(80, 21);
            this.checkNational.TabIndex = 37;
            this.checkNational.Text = "national";
            this.checkNational.UseVisualStyleBackColor = true;
            // 
            // checkHoursPerWeek
            // 
            this.checkHoursPerWeek.AutoSize = true;
            this.checkHoursPerWeek.Checked = true;
            this.checkHoursPerWeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHoursPerWeek.Location = new System.Drawing.Point(7, 82);
            this.checkHoursPerWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkHoursPerWeek.Name = "checkHoursPerWeek";
            this.checkHoursPerWeek.Size = new System.Drawing.Size(127, 21);
            this.checkHoursPerWeek.TabIndex = 38;
            this.checkHoursPerWeek.Text = "hours per week";
            this.checkHoursPerWeek.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkAge);
            this.groupBox3.Controls.Add(this.checkHoursPerWeek);
            this.groupBox3.Controls.Add(this.checkWorkclass);
            this.groupBox3.Controls.Add(this.checkfnlwgt);
            this.groupBox3.Controls.Add(this.checkCapitalLoss);
            this.groupBox3.Controls.Add(this.checkRelationship);
            this.groupBox3.Controls.Add(this.checkCapitalGain);
            this.groupBox3.Controls.Add(this.checkSex);
            this.groupBox3.Controls.Add(this.numericLiczbaTestowych);
            this.groupBox3.Controls.Add(this.checkNational);
            this.groupBox3.Controls.Add(this.checkEducation);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.checkRace);
            this.groupBox3.Controls.Add(this.checkEducationNum);
            this.groupBox3.Controls.Add(this.checkMaritialStatus);
            this.groupBox3.Controls.Add(this.checkOccupation);
            this.groupBox3.Location = new System.Drawing.Point(383, 373);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(439, 181);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane uwzglednione podczas importu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSciezka);
            this.groupBox4.Location = new System.Drawing.Point(3, 561);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(819, 52);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plik z danymi wejsciowymi";
            // 
            // labelPoprawneOszacowaniaWynik
            // 
            this.labelPoprawneOszacowaniaWynik.AutoSize = true;
            this.labelPoprawneOszacowaniaWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoprawneOszacowaniaWynik.Location = new System.Drawing.Point(331, 115);
            this.labelPoprawneOszacowaniaWynik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoprawneOszacowaniaWynik.Name = "labelPoprawneOszacowaniaWynik";
            this.labelPoprawneOszacowaniaWynik.Size = new System.Drawing.Size(15, 20);
            this.labelPoprawneOszacowaniaWynik.TabIndex = 26;
            this.labelPoprawneOszacowaniaWynik.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(11, 213);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(321, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "liczba poprawnych oszacowań pod rzad : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.numericFirstLayer);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Location = new System.Drawing.Point(468, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 340);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ustawienia algorytmów";
            // 
            // comboAlgorytmFann
            // 
            this.comboAlgorytmFann.FormattingEnabled = true;
            this.comboAlgorytmFann.Items.AddRange(new object[] {
            "BATCH",
            "INCREMENTAL",
            "QUICKPROP",
            "RPROP"});
            this.comboAlgorytmFann.Location = new System.Drawing.Point(173, 24);
            this.comboAlgorytmFann.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlgorytmFann.Name = "comboAlgorytmFann";
            this.comboAlgorytmFann.Size = new System.Drawing.Size(216, 24);
            this.comboAlgorytmFann.TabIndex = 10;
            this.comboAlgorytmFann.Text = "BATCH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Algorytm uczenia :";
            // 
            // labelStatusFann
            // 
            this.labelStatusFann.AutoSize = true;
            this.labelStatusFann.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusFann.Location = new System.Drawing.Point(90, 290);
            this.labelStatusFann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusFann.Name = "labelStatusFann";
            this.labelStatusFann.Size = new System.Drawing.Size(15, 20);
            this.labelStatusFann.TabIndex = 26;
            this.labelStatusFann.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(10, 290);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Status : ";
            // 
            // comboRaportAlgorytmFann
            // 
            this.comboRaportAlgorytmFann.FormattingEnabled = true;
            this.comboRaportAlgorytmFann.Items.AddRange(new object[] {
            "BATCH",
            "INCREMENTAL",
            "QUICKPROP",
            "RPROP"});
            this.comboRaportAlgorytmFann.Location = new System.Drawing.Point(15, 218);
            this.comboRaportAlgorytmFann.Margin = new System.Windows.Forms.Padding(4);
            this.comboRaportAlgorytmFann.Name = "comboRaportAlgorytmFann";
            this.comboRaportAlgorytmFann.Size = new System.Drawing.Size(216, 24);
            this.comboRaportAlgorytmFann.TabIndex = 17;
            this.comboRaportAlgorytmFann.Text = "BATCH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(11, 193);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Algorytm uczenia Fann:";
            // 
            // buttonRaportFann
            // 
            this.buttonRaportFann.Location = new System.Drawing.Point(15, 135);
            this.buttonRaportFann.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRaportFann.Name = "buttonRaportFann";
            this.buttonRaportFann.Size = new System.Drawing.Size(249, 51);
            this.buttonRaportFann.TabIndex = 18;
            this.buttonRaportFann.Text = "Generuj raport Fann";
            this.buttonRaportFann.UseVisualStyleBackColor = true;
            this.buttonRaportFann.Click += new System.EventHandler(this.buttonRaportFann_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 616);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.zakladki);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BIAI";
            this.zakladki.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPoprawneOszacowania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstLayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLiczbaTestowych)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl zakladki;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelRekordy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOtworz;
        private System.Windows.Forms.Label labelSciezka;
        private System.Windows.Forms.Label labelStatusUczenie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNauka;
        private System.Windows.Forms.ComboBox comboAlgorytm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWynki;
        private System.Windows.Forms.Label labelCzasNauki;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericEpoch;
        private System.Windows.Forms.NumericUpDown numericFirstLayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWynikZSieci;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericLiczbaTestowych;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTestyLiczba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkAge;
        private System.Windows.Forms.CheckBox checkWorkclass;
        private System.Windows.Forms.CheckBox checkfnlwgt;
        private System.Windows.Forms.CheckBox checkEducation;
        private System.Windows.Forms.CheckBox checkEducationNum;
        private System.Windows.Forms.CheckBox checkMaritialStatus;
        private System.Windows.Forms.CheckBox checkOccupation;
        private System.Windows.Forms.CheckBox checkRelationship;
        private System.Windows.Forms.CheckBox checkRace;
        private System.Windows.Forms.CheckBox checkSex;
        private System.Windows.Forms.CheckBox checkCapitalGain;
        private System.Windows.Forms.CheckBox checkCapitalLoss;
        private System.Windows.Forms.CheckBox checkNational;
        private System.Windows.Forms.CheckBox checkHoursPerWeek;
        private System.Windows.Forms.Button buttonZapiszDane;
        private System.Windows.Forms.NumericUpDown numericPoprawneOszacowania;
        private System.Windows.Forms.CheckBox checkPoprawneOszacowania;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelNaukaLiczba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonRaportAfroge;
        private System.Windows.Forms.Label labelRaportStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAlgorytmRaport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLearningRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonNaukaFann;
        private System.Windows.Forms.Label labelPoprawneOszacowaniaWynik;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelStatusFann;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboAlgorytmFann;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRaportFann;
        private System.Windows.Forms.ComboBox comboRaportAlgorytmFann;
        private System.Windows.Forms.Label label16;
    }
}

