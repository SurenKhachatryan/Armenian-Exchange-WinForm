namespace Armenian_Exchange
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSetValue = new System.Windows.Forms.TextBox();
            this.textBoxGetResult1 = new System.Windows.Forms.TextBox();
            this.textBoxGetResult2 = new System.Windows.Forms.TextBox();
            this.textBoxGetResult3 = new System.Windows.Forms.TextBox();
            this.textBoxNewBuy = new System.Windows.Forms.TextBox();
            this.textBoxNewSell = new System.Windows.Forms.TextBox();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCourseNow = new System.Windows.Forms.Label();
            this.labelNewCourse = new System.Windows.Forms.Label();
            this.labelUsd = new System.Windows.Forms.Label();
            this.labelEur = new System.Windows.Forms.Label();
            this.labelRub = new System.Windows.Forms.Label();
            this.labelUsdBuy = new System.Windows.Forms.Label();
            this.labelEurBuy = new System.Windows.Forms.Label();
            this.labelRubBuy = new System.Windows.Forms.Label();
            this.labelUsdSell = new System.Windows.Forms.Label();
            this.labelEurSell = new System.Windows.Forms.Label();
            this.labelRubSell = new System.Windows.Forms.Label();
            this.labelSellCourseNow = new System.Windows.Forms.Label();
            this.labelBuyCourseNow = new System.Windows.Forms.Label();
            this.labelBuyNewCourse = new System.Windows.Forms.Label();
            this.labelSellNewCourse = new System.Windows.Forms.Label();
            this.labelEqually = new System.Windows.Forms.Label();
            this.labelCurrencySign = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.radioButtonUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonRUB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxSetValue
            // 
            this.textBoxSetValue.Location = new System.Drawing.Point(4, 115);
            this.textBoxSetValue.MaxLength = 12;
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(82, 20);
            this.textBoxSetValue.TabIndex = 0;
            this.textBoxSetValue.Text = "0";
            this.textBoxSetValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSetValue_MouseClick);
            this.textBoxSetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyDown);
            this.textBoxSetValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSetValue_KeyPress);
            this.textBoxSetValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyUp);
            // 
            // textBoxGetResult1
            // 
            this.textBoxGetResult1.Location = new System.Drawing.Point(107, 115);
            this.textBoxGetResult1.Name = "textBoxGetResult1";
            this.textBoxGetResult1.Size = new System.Drawing.Size(148, 20);
            this.textBoxGetResult1.TabIndex = 1;
            this.textBoxGetResult1.Text = "0";
            this.textBoxGetResult1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            this.textBoxGetResult1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyDown);
            this.textBoxGetResult1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetResult_1_2_3_ComboBox_KeyPress);
            this.textBoxGetResult1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyUp);
            // 
            // textBoxGetResult2
            // 
            this.textBoxGetResult2.Location = new System.Drawing.Point(107, 137);
            this.textBoxGetResult2.Name = "textBoxGetResult2";
            this.textBoxGetResult2.Size = new System.Drawing.Size(148, 20);
            this.textBoxGetResult2.TabIndex = 2;
            this.textBoxGetResult2.Text = "0";
            this.textBoxGetResult2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            this.textBoxGetResult2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyDown);
            this.textBoxGetResult2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetResult_1_2_3_ComboBox_KeyPress);
            this.textBoxGetResult2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyUp);
            // 
            // textBoxGetResult3
            // 
            this.textBoxGetResult3.Location = new System.Drawing.Point(107, 159);
            this.textBoxGetResult3.Name = "textBoxGetResult3";
            this.textBoxGetResult3.Size = new System.Drawing.Size(148, 20);
            this.textBoxGetResult3.TabIndex = 3;
            this.textBoxGetResult3.Text = "0";
            this.textBoxGetResult3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            this.textBoxGetResult3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyDown);
            this.textBoxGetResult3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetResult_1_2_3_ComboBox_KeyPress);
            this.textBoxGetResult3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGetResult_1_2_3_KeyUp);
            // 
            // textBoxNewBuy
            // 
            this.textBoxNewBuy.Location = new System.Drawing.Point(115, 90);
            this.textBoxNewBuy.MaxLength = 6;
            this.textBoxNewBuy.Name = "textBoxNewBuy";
            this.textBoxNewBuy.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewBuy.TabIndex = 4;
            this.textBoxNewBuy.Text = "0";
            this.textBoxNewBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNewBuy_MouseClick);
            this.textBoxNewBuy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyDown);
            this.textBoxNewBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewBuy_KeyPress);
            this.textBoxNewBuy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyUp);
            // 
            // textBoxNewSell
            // 
            this.textBoxNewSell.Location = new System.Drawing.Point(164, 90);
            this.textBoxNewSell.MaxLength = 6;
            this.textBoxNewSell.Name = "textBoxNewSell";
            this.textBoxNewSell.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewSell.TabIndex = 5;
            this.textBoxNewSell.Text = "0";
            this.textBoxNewSell.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNewSell_MouseClick);
            this.textBoxNewSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyDown);
            this.textBoxNewSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewSell_KeyPress);
            this.textBoxNewSell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyUp);
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "AMD To RUB, USD, EUR",
            "USD To AMD, EUR, RUB",
            "RUB To AMD, EUR, USD",
            "EUR To AMD, RUB, USD"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(107, 13);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCurrency.TabIndex = 6;
            this.comboBoxCurrency.Text = "AMD To RUB, USD, EUR";
            this.comboBoxCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyDown);
            this.comboBoxCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetResult_1_2_3_ComboBox_KeyPress);
            this.comboBoxCurrency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSetValue_NewBuySell_ComboBox_KeyUp);
            this.comboBoxCurrency.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(213, 89);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(44, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            this.buttonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelCourseNow
            // 
            this.labelCourseNow.AutoSize = true;
            this.labelCourseNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCourseNow.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCourseNow.Location = new System.Drawing.Point(20, 13);
            this.labelCourseNow.Name = "labelCourseNow";
            this.labelCourseNow.Size = new System.Drawing.Size(75, 13);
            this.labelCourseNow.TabIndex = 8;
            this.labelCourseNow.Text = "Course Now";
            this.labelCourseNow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelNewCourse
            // 
            this.labelNewCourse.AutoSize = true;
            this.labelNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelNewCourse.ForeColor = System.Drawing.Color.Maroon;
            this.labelNewCourse.Location = new System.Drawing.Point(111, 36);
            this.labelNewCourse.Name = "labelNewCourse";
            this.labelNewCourse.Size = new System.Drawing.Size(75, 13);
            this.labelNewCourse.TabIndex = 9;
            this.labelNewCourse.Text = "New Course";
            this.labelNewCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelUsd
            // 
            this.labelUsd.AutoSize = true;
            this.labelUsd.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold);
            this.labelUsd.Location = new System.Drawing.Point(2, 53);
            this.labelUsd.Name = "labelUsd";
            this.labelUsd.Size = new System.Drawing.Size(33, 15);
            this.labelUsd.TabIndex = 10;
            this.labelUsd.Text = "USD";
            this.labelUsd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelEur
            // 
            this.labelEur.AutoSize = true;
            this.labelEur.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold);
            this.labelEur.Location = new System.Drawing.Point(2, 73);
            this.labelEur.Name = "labelEur";
            this.labelEur.Size = new System.Drawing.Size(33, 15);
            this.labelEur.TabIndex = 11;
            this.labelEur.Text = "EUR";
            this.labelEur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelRub
            // 
            this.labelRub.AutoSize = true;
            this.labelRub.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold);
            this.labelRub.Location = new System.Drawing.Point(1, 93);
            this.labelRub.Name = "labelRub";
            this.labelRub.Size = new System.Drawing.Size(34, 15);
            this.labelRub.TabIndex = 12;
            this.labelRub.Text = "RUB";
            this.labelRub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelUsdBuy
            // 
            this.labelUsdBuy.AutoSize = true;
            this.labelUsdBuy.Location = new System.Drawing.Point(35, 54);
            this.labelUsdBuy.Name = "labelUsdBuy";
            this.labelUsdBuy.Size = new System.Drawing.Size(35, 13);
            this.labelUsdBuy.TabIndex = 13;
            this.labelUsdBuy.Text = "label6";
            this.labelUsdBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelEurBuy
            // 
            this.labelEurBuy.AutoSize = true;
            this.labelEurBuy.Location = new System.Drawing.Point(35, 74);
            this.labelEurBuy.Name = "labelEurBuy";
            this.labelEurBuy.Size = new System.Drawing.Size(35, 13);
            this.labelEurBuy.TabIndex = 14;
            this.labelEurBuy.Text = "label7";
            this.labelEurBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelRubBuy
            // 
            this.labelRubBuy.AutoSize = true;
            this.labelRubBuy.Location = new System.Drawing.Point(35, 94);
            this.labelRubBuy.Name = "labelRubBuy";
            this.labelRubBuy.Size = new System.Drawing.Size(35, 13);
            this.labelRubBuy.TabIndex = 15;
            this.labelRubBuy.Text = "label8";
            this.labelRubBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelUsdSell
            // 
            this.labelUsdSell.AutoSize = true;
            this.labelUsdSell.Location = new System.Drawing.Point(74, 54);
            this.labelUsdSell.Name = "labelUsdSell";
            this.labelUsdSell.Size = new System.Drawing.Size(35, 13);
            this.labelUsdSell.TabIndex = 16;
            this.labelUsdSell.Text = "label9";
            this.labelUsdSell.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelEurSell
            // 
            this.labelEurSell.AutoSize = true;
            this.labelEurSell.Location = new System.Drawing.Point(74, 74);
            this.labelEurSell.Name = "labelEurSell";
            this.labelEurSell.Size = new System.Drawing.Size(41, 13);
            this.labelEurSell.TabIndex = 17;
            this.labelEurSell.Text = "label10";
            this.labelEurSell.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelRubSell
            // 
            this.labelRubSell.AutoSize = true;
            this.labelRubSell.Location = new System.Drawing.Point(74, 94);
            this.labelRubSell.Name = "labelRubSell";
            this.labelRubSell.Size = new System.Drawing.Size(41, 13);
            this.labelRubSell.TabIndex = 18;
            this.labelRubSell.Text = "label11";
            this.labelRubSell.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelSellCourseNow
            // 
            this.labelSellCourseNow.AutoSize = true;
            this.labelSellCourseNow.Location = new System.Drawing.Point(74, 32);
            this.labelSellCourseNow.Name = "labelSellCourseNow";
            this.labelSellCourseNow.Size = new System.Drawing.Size(33, 13);
            this.labelSellCourseNow.TabIndex = 19;
            this.labelSellCourseNow.Text = "SELL";
            this.labelSellCourseNow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelBuyCourseNow
            // 
            this.labelBuyCourseNow.AutoSize = true;
            this.labelBuyCourseNow.Location = new System.Drawing.Point(36, 32);
            this.labelBuyCourseNow.Name = "labelBuyCourseNow";
            this.labelBuyCourseNow.Size = new System.Drawing.Size(29, 13);
            this.labelBuyCourseNow.TabIndex = 20;
            this.labelBuyCourseNow.Text = "BUY";
            this.labelBuyCourseNow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelBuyNewCourse
            // 
            this.labelBuyNewCourse.AutoSize = true;
            this.labelBuyNewCourse.Location = new System.Drawing.Point(112, 73);
            this.labelBuyNewCourse.Name = "labelBuyNewCourse";
            this.labelBuyNewCourse.Size = new System.Drawing.Size(29, 13);
            this.labelBuyNewCourse.TabIndex = 21;
            this.labelBuyNewCourse.Text = "BUY";
            this.labelBuyNewCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelSellNewCourse
            // 
            this.labelSellNewCourse.AutoSize = true;
            this.labelSellNewCourse.Location = new System.Drawing.Point(163, 73);
            this.labelSellNewCourse.Name = "labelSellNewCourse";
            this.labelSellNewCourse.Size = new System.Drawing.Size(33, 13);
            this.labelSellNewCourse.TabIndex = 22;
            this.labelSellNewCourse.Text = "SELL";
            this.labelSellNewCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelEqually
            // 
            this.labelEqually.AutoSize = true;
            this.labelEqually.Location = new System.Drawing.Point(94, 118);
            this.labelEqually.Name = "labelEqually";
            this.labelEqually.Size = new System.Drawing.Size(13, 13);
            this.labelEqually.TabIndex = 23;
            this.labelEqually.Text = "=";
            this.labelEqually.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelCurrencySign
            // 
            this.labelCurrencySign.AutoSize = true;
            this.labelCurrencySign.Location = new System.Drawing.Point(86, 118);
            this.labelCurrencySign.Name = "labelCurrencySign";
            this.labelCurrencySign.Size = new System.Drawing.Size(0, 13);
            this.labelCurrencySign.TabIndex = 24;
            this.labelCurrencySign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(4, 162);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 25;
            this.labelVersion.Text = "Version :1.0";
            this.labelVersion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // radioButtonUSD
            // 
            this.radioButtonUSD.AutoSize = true;
            this.radioButtonUSD.Checked = true;
            this.radioButtonUSD.Location = new System.Drawing.Point(115, 52);
            this.radioButtonUSD.Name = "radioButtonUSD";
            this.radioButtonUSD.Size = new System.Drawing.Size(48, 17);
            this.radioButtonUSD.TabIndex = 26;
            this.radioButtonUSD.TabStop = true;
            this.radioButtonUSD.Text = "USD";
            this.radioButtonUSD.UseVisualStyleBackColor = true;
            this.radioButtonUSD.CheckedChanged += new System.EventHandler(this.radioButtonUSD_CheckedChanged);
            this.radioButtonUSD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // radioButtonEUR
            // 
            this.radioButtonEUR.AutoSize = true;
            this.radioButtonEUR.Location = new System.Drawing.Point(160, 52);
            this.radioButtonEUR.Name = "radioButtonEUR";
            this.radioButtonEUR.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEUR.TabIndex = 27;
            this.radioButtonEUR.Text = "EUR";
            this.radioButtonEUR.UseVisualStyleBackColor = true;
            this.radioButtonEUR.CheckedChanged += new System.EventHandler(this.radioButtonEUR_CheckedChanged);
            this.radioButtonEUR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // radioButtonRUB
            // 
            this.radioButtonRUB.AutoSize = true;
            this.radioButtonRUB.Location = new System.Drawing.Point(207, 52);
            this.radioButtonRUB.Name = "radioButtonRUB";
            this.radioButtonRUB.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRUB.TabIndex = 28;
            this.radioButtonRUB.Text = "RUB";
            this.radioButtonRUB.UseVisualStyleBackColor = true;
            this.radioButtonRUB.CheckedChanged += new System.EventHandler(this.radioButtonRUB_CheckedChanged);
            this.radioButtonRUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 185);
            this.Controls.Add(this.radioButtonRUB);
            this.Controls.Add(this.radioButtonEUR);
            this.Controls.Add(this.radioButtonUSD);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCurrencySign);
            this.Controls.Add(this.labelEqually);
            this.Controls.Add(this.labelSellNewCourse);
            this.Controls.Add(this.labelBuyNewCourse);
            this.Controls.Add(this.labelBuyCourseNow);
            this.Controls.Add(this.labelSellCourseNow);
            this.Controls.Add(this.labelRubSell);
            this.Controls.Add(this.labelEurSell);
            this.Controls.Add(this.labelUsdSell);
            this.Controls.Add(this.labelRubBuy);
            this.Controls.Add(this.labelEurBuy);
            this.Controls.Add(this.labelUsdBuy);
            this.Controls.Add(this.labelRub);
            this.Controls.Add(this.labelEur);
            this.Controls.Add(this.labelUsd);
            this.Controls.Add(this.labelNewCourse);
            this.Controls.Add(this.labelCourseNow);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.textBoxNewSell);
            this.Controls.Add(this.textBoxNewBuy);
            this.Controls.Add(this.textBoxGetResult3);
            this.Controls.Add(this.textBoxGetResult2);
            this.Controls.Add(this.textBoxGetResult1);
            this.Controls.Add(this.textBoxSetValue);
            this.MaximumSize = new System.Drawing.Size(276, 224);
            this.MinimumSize = new System.Drawing.Size(276, 224);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitializerStringEmpty_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxSetValue;
        private System.Windows.Forms.TextBox textBoxGetResult1;
        private System.Windows.Forms.TextBox textBoxGetResult2;
        private System.Windows.Forms.TextBox textBoxGetResult3;
        private System.Windows.Forms.TextBox textBoxNewBuy;
        private System.Windows.Forms.TextBox textBoxNewSell;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCourseNow;
        private System.Windows.Forms.Label labelNewCourse;
        private System.Windows.Forms.Label labelUsd;
        private System.Windows.Forms.Label labelEur;
        private System.Windows.Forms.Label labelRub;
        private System.Windows.Forms.Label labelUsdBuy;
        private System.Windows.Forms.Label labelEurBuy;
        private System.Windows.Forms.Label labelRubBuy;
        private System.Windows.Forms.Label labelUsdSell;
        private System.Windows.Forms.Label labelEurSell;
        private System.Windows.Forms.Label labelRubSell;
        private System.Windows.Forms.Label labelSellCourseNow;
        private System.Windows.Forms.Label labelBuyCourseNow;
        private System.Windows.Forms.Label labelBuyNewCourse;
        private System.Windows.Forms.Label labelSellNewCourse;
        private System.Windows.Forms.Label labelEqually;
        private System.Windows.Forms.Label labelCurrencySign;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.RadioButton radioButtonUSD;
        private System.Windows.Forms.RadioButton radioButtonEUR;
        private System.Windows.Forms.RadioButton radioButtonRUB;
    }
}

