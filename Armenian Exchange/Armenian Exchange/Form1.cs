using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Armenian_Exchange
{
    public partial class Form1 : Form
    {
        private IAMD am;
        private IUSD us;
        private IEUR eu;
        private IRUB ru;
        private Fanctions classlibraryfanction = new Fanctions();

        public Form1()
        {
            InitializeComponent();
            labelUsdBuy.Text = Course.CourseList[0].ToString();
            labelUsdSell.Text = Course.CourseList[1].ToString();
            labelRubBuy.Text = Course.CourseList[2].ToString();
            labelRubSell.Text = Course.CourseList[3].ToString();
            labelEurBuy.Text = Course.CourseList[4].ToString();
            labelEurSell.Text = Course.CourseList[5].ToString();
            textBoxNewBuy.Text = labelUsdBuy.Text;
            textBoxNewSell.Text = labelUsdSell.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBoxSetValue.Text != "" && textBoxSetValue.Text != "0,")
            {
                switch (comboBoxCurrency.SelectedIndex)
                {
                    case 0:
                        labelCurrencySign.Text = "֏";
                        ru = new AMD();
                        textBoxGetResult1.Text = ru.ToRub(double.Parse(textBoxSetValue.Text)).ToString() + " ₽";
                        us = new AMD();
                        textBoxGetResult2.Text = us.ToUsd(double.Parse(textBoxSetValue.Text)).ToString() + " $";
                        eu = new AMD();
                        textBoxGetResult3.Text = eu.ToEur(double.Parse(textBoxSetValue.Text)).ToString() + " €";
                        break;
                    case 1:
                        labelCurrencySign.Text = "$";
                        am = new USD();
                        textBoxGetResult1.Text = am.ToAmd(double.Parse(textBoxSetValue.Text)).ToString() + " ֏";
                        eu = new USD();
                        textBoxGetResult2.Text = eu.ToEur(double.Parse(textBoxSetValue.Text)).ToString() + " €";
                        ru = new USD();
                        textBoxGetResult3.Text = ru.ToRub(double.Parse(textBoxSetValue.Text)).ToString() + " ₽";
                        break;
                    case 2:
                        labelCurrencySign.Text = "₽";
                        am = new RUB();
                        textBoxGetResult1.Text = am.ToAmd(double.Parse(textBoxSetValue.Text)).ToString() + " ֏";
                        eu = new RUB();
                        textBoxGetResult2.Text = eu.ToEur(double.Parse(textBoxSetValue.Text)).ToString() + " €";
                        us = new RUB();
                        textBoxGetResult3.Text = us.ToUsd(double.Parse(textBoxSetValue.Text)).ToString() + " $";
                        break;
                    case 3:
                        labelCurrencySign.Text = "€";
                        am = new EUR();
                        textBoxGetResult1.Text = am.ToAmd(double.Parse(textBoxSetValue.Text)).ToString() + " ֏";
                        ru = new EUR();
                        textBoxGetResult2.Text = ru.ToRub(double.Parse(textBoxSetValue.Text)).ToString() + " ₽";
                        us = new EUR();
                        textBoxGetResult3.Text = us.ToUsd(double.Parse(textBoxSetValue.Text)).ToString() + " $";
                        break;
                }
            }
            else
            {
                textBoxGetResult1.Text = "0";
                textBoxGetResult2.Text = "0";
                textBoxGetResult3.Text = "0";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            InitializerStringEmpty();

            if (radioButtonUSD.Checked)
            {
                new USD(double.Parse(textBoxNewBuy.Text), double.Parse(textBoxNewSell.Text));
                labelUsdBuy.Text = Course.CourseList[0].ToString();
                labelUsdSell.Text = Course.CourseList[1].ToString();
            }
            else
            if (radioButtonEUR.Checked)
            {
                new EUR(double.Parse(textBoxNewBuy.Text), double.Parse(textBoxNewSell.Text));
                labelEurBuy.Text = Course.CourseList[4].ToString();
                labelEurSell.Text = Course.CourseList[5].ToString();
            }
            else
            if (radioButtonRUB.Checked)
            {
                new RUB(double.Parse(textBoxNewBuy.Text), double.Parse(textBoxNewSell.Text));
                labelRubBuy.Text = Course.CourseList[2].ToString();
                labelRubSell.Text = Course.CourseList[3].ToString();
            }
        }

        private void radioButtonUSD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelRubBuy.Text;
            textBoxNewSell.Text = labelRubSell.Text;
            textBoxNewBuy.MaxLength = 5;
            textBoxNewSell.MaxLength = 5;
        }

        private void radioButtonEUR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelUsdBuy.Text;
            textBoxNewSell.Text = labelUsdSell.Text;
            textBoxNewBuy.MaxLength = 6;
            textBoxNewSell.MaxLength = 6;
        }

        private void radioButtonRUB_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelEurBuy.Text;
            textBoxNewSell.Text = labelEurSell.Text;
            textBoxNewBuy.MaxLength = 6;
            textBoxNewSell.MaxLength = 6;
        }
        private void InitializerStringEmpty()
        {
            if (textBoxNewBuy.Text == "")
            {
                textBoxNewBuy.Text = "0";
            }
            if (textBoxNewSell.Text == "")
            {
                textBoxNewSell.Text = "0";
            }
            if (textBoxSetValue.Text == "")
            {
                textBoxSetValue.Text = "0";
            }
        }

        private void InitializerStringEmpty_MouseClick(object sender, MouseEventArgs e)
        {
            InitializerStringEmpty();
        }

        private void textBoxNewBuy_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNewSell.Text == "")
            {
                textBoxNewSell.Text = "0";
            }
            if (textBoxNewBuy.Text == "0")
            {
                textBoxNewBuy.Text = "";
            }
            if (textBoxSetValue.Text == "")
            {
                textBoxSetValue.Text = "0";
            }
        }

        private void textBoxNewSell_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNewSell.Text == "0")
            {
                textBoxNewSell.Text = "";
            }
            if (textBoxNewBuy.Text == "")
            {
                textBoxNewBuy.Text = "0";
            }
            if (textBoxSetValue.Text == "")
            {
                textBoxSetValue.Text = "0";
            }
        }

        private void textBoxSetValue_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNewBuy.Text == "")
            {
                textBoxNewBuy.Text = "0";
            }
            if (textBoxNewSell.Text == "")
            {
                textBoxNewSell.Text = "0";
            }
            if (textBoxSetValue.Text == "0")
            {
                textBoxSetValue.Text = "";
            }
        }

        private void textBoxGetResult_1_2_3_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxGetResult_1_2_3_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxGetResult_1_2_3_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxSetValue_NewBuySell_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBoxSetValue_NewBuySell_ComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBoxNewSell_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxSetValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBoxNewBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            //if (chr == 46)
            //{
            //    chr = (char)44;
            //}
            if (textBoxNewBuy.Text == "" && chr != 8 && chr == 44)
            {
                textBoxNewBuy.Text = "0";
                textBoxNewBuy.SelectionStart = 2;
            }
            else
            if (chr == 44 && textBoxNewBuy.Text != "")
            {
                if (chr == 44 && textBoxNewBuy.SelectionStart == 5)
                {
                    e.Handled = true;
                }
                else
                if (classlibraryfanction.SearchComma(textBoxNewBuy.Text))
                { }
                else
                {
                    e.Handled = true;
                }
            }
            else
            if (!Char.IsDigit(chr) && chr != 8 || (textBoxNewBuy.Text.Length == 5 && chr == 44) || textBoxNewBuy.Text == "" && chr != 48)
            {
                e.Handled = true;
            }
            else
            if (textBoxNewBuy.Text.Length != 1 && textBoxNewBuy.SelectionStart == 1 && textBoxNewBuy.Text[1] == 44 && chr == 8)
            {
                e.Handled = true;
            }
            else
            if (textBoxNewBuy.Text.Length == 5 && chr != 8 && textBoxNewBuy.Text[4] == 44 && textBoxNewBuy.SelectionStart < 5)
            {
                e.Handled = true;
            }
        }

       
    }
}
