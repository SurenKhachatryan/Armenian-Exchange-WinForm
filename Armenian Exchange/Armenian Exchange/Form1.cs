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
        private string str;
        private byte selectindexstextbox;
        private char chr;
        private Fanctions fa = new Fanctions();

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
            if (fa.SearchDot(textBoxNewBuy.Text) || fa.SearchDot(textBoxNewSell.Text) || fa.SearchDot(textBoxSetValue.Text))
            {
                switch (str)
                {
                    case "1":
                        textBoxNewBuy.Text = fa.DotToCommas(textBoxNewBuy.Text);
                        textBoxNewBuy.SelectionStart = fa.GetIndexCommas(textBoxNewBuy.Text) + 1;
                        break;
                    case "2":
                        textBoxNewSell.Text = fa.DotToCommas(textBoxNewSell.Text);
                        textBoxNewSell.SelectionStart = fa.GetIndexCommas(textBoxNewSell.Text) + 1;
                        break;
                    case "3":
                        textBoxSetValue.Text = fa.DotToCommas(textBoxSetValue.Text);
                        textBoxSetValue.SelectionStart = fa.GetIndexCommas(textBoxSetValue.Text) + 1;
                        break;
                }
            }

            if (textBoxSetValue.Text != "")
            {
                if (chr == 8 && textBoxSetValue.Text[0] == 44)
                {
                    textBoxSetValue.Text = textBoxSetValue.Text.Remove(0, 1);
                }
            }
            if (textBoxNewBuy.Text != "")
            {
                if (chr == 8 && textBoxNewBuy.Text[0] == 44)
                {
                    textBoxNewBuy.Text = textBoxNewBuy.Text.Remove(0, 1);
                }
            }
            if (textBoxNewSell.Text != "")
            {
                if (chr == 8 && textBoxNewSell.Text[0] == 44)
                {
                    textBoxNewSell.Text = textBoxNewSell.Text.Remove(0, 1);
                }
            }


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
            if (textBoxNewBuy.Text[textBoxNewBuy.Text.Length - 1] == 44 || textBoxNewSell.Text[textBoxNewSell.Text.Length - 1] == 44)
            {
                if (radioButtonUSD.Checked)
                {
                    textBoxNewBuy.Text = Course.CourseList[0].ToString();
                    textBoxNewSell.Text = Course.CourseList[1].ToString();
                }
                else
                if (radioButtonEUR.Checked)
                {
                    textBoxNewBuy.Text = Course.CourseList[4].ToString();
                    textBoxNewSell.Text = Course.CourseList[5].ToString();
                }
                else
                if (radioButtonRUB.Checked)
                {
                    textBoxNewBuy.Text = Course.CourseList[2].ToString();
                    textBoxNewSell.Text = Course.CourseList[3].ToString();
                }
            }
        }

        private void radioButtonUSD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelUsdBuy.Text;
            textBoxNewSell.Text = labelUsdSell.Text;
        }

        private void radioButtonEUR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelEurBuy.Text;
            textBoxNewSell.Text = labelEurSell.Text;
        }

        private void radioButtonRUB_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewBuy.Text = labelRubBuy.Text;
            textBoxNewSell.Text = labelRubSell.Text;
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
            str = "2";
            selectindexstextbox = (byte)textBoxNewSell.SelectionStart;
            chr = e.KeyChar;
            if (chr == 46)
            {
                chr = (char)44;
            }
            if (fa.SearchComma(textBoxNewSell.Text) && (textBoxNewSell.Text == "" || textBoxNewSell.Text == "0" || textBoxNewSell.SelectionStart == 0) && chr != 8 && chr == 44)
            {
                if (textBoxNewSell.Text == "0")
                {
                    textBoxNewSell.Text = "0";
                    textBoxNewSell.SelectionStart = 2;
                }
                else
                if (textBoxNewSell.Text.Length != 5)
                {
                    textBoxNewSell.Text = "0" + textBoxNewSell.Text;
                    textBoxNewSell.SelectionStart = 1;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            if (chr == 44 && textBoxNewSell.Text != "")
            {
                if (chr == 44 && textBoxNewSell.SelectionStart == 5)
                {
                    e.Handled = true;
                }
                else
                if (fa.SearchComma(textBoxNewSell.Text))
                { }
                else
                {
                    e.Handled = true;
                }
            }
            else
            if (!Char.IsDigit(chr) && chr != 8 || (textBoxNewSell.Text.Length == 5 && chr == 44))
            {
                e.Handled = true;
            }
            else
            if (textBoxNewSell.Text.Length != 1 && textBoxNewSell.SelectionStart == 1 && textBoxNewSell.Text[1] == 44 && chr == 8)
            {
                textBoxNewSell.Text = textBoxNewSell.Text.Remove(0, 2);
                e.Handled = true;
            }
            else
            if (textBoxNewSell.Text.Length == 5 && chr != 8 && textBoxNewSell.Text[4] == 44 && textBoxNewSell.SelectionStart < 5)
            {
                textBoxNewSell.Text = textBoxNewSell.Text.Remove(4, 1);
                textBoxNewSell.SelectionStart = selectindexstextbox;
            }
        }

        private void textBoxSetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            str = "3";
            selectindexstextbox = (byte)textBoxSetValue.SelectionStart;
            chr = e.KeyChar;
            if (chr == 46)
            {
                chr = (char)44;
            }
            if (fa.SearchComma(textBoxSetValue.Text) && (textBoxSetValue.Text == "" || textBoxSetValue.Text == "0" || textBoxSetValue.SelectionStart == 0)
                  && chr != 8 && chr == 44)
            {
                if (textBoxSetValue.Text == "0")
                {
                    textBoxSetValue.Text = "0";
                    textBoxSetValue.SelectionStart = 2;
                }
                else
                if (textBoxSetValue.Text.Length != 5)
                {
                    textBoxSetValue.Text = "0" + textBoxSetValue.Text;
                    textBoxSetValue.SelectionStart = 1;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
             if (chr == 44 && textBoxSetValue.Text != "")
            {
                if (chr == 44 && textBoxSetValue.SelectionStart == 11)
                {
                    e.Handled = true;
                }
                else
                if (fa.SearchComma(textBoxSetValue.Text))
                { }
                else
                {
                    e.Handled = true;
                }
            }
            else
             if (!Char.IsDigit(chr) && chr != 8 || (textBoxSetValue.Text.Length == 11 && chr == 44))
            {
                e.Handled = true;
            }
            else
             if (textBoxSetValue.Text.Length != 1 && textBoxSetValue.SelectionStart == 1 && textBoxSetValue.Text[1] == 44 && chr == 8)
            {
                textBoxSetValue.Text = textBoxSetValue.Text.Remove(0, 2);
                e.Handled = true;
            }
            else
            if (textBoxSetValue.Text.Length == 11 && chr != 8 && textBoxSetValue.Text[10] == 44 && textBoxSetValue.SelectionStart < 11)
            {
                textBoxSetValue.Text = textBoxSetValue.Text.Remove(10, 1);
                textBoxSetValue.SelectionStart = selectindexstextbox;
            }
        }

        private void textBoxNewBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            str = "1";
            selectindexstextbox = (byte)textBoxNewBuy.SelectionStart;
            chr = e.KeyChar;
            if (chr == 46)
            {
                chr = (char)44;
            }
            if (fa.SearchComma(textBoxNewBuy.Text) && (textBoxNewBuy.Text == "" || textBoxNewBuy.Text == "0" || textBoxNewBuy.SelectionStart == 0)
                && chr != 8 && chr == 44)
            {
                if (textBoxNewBuy.Text == "0")
                {
                    textBoxNewBuy.Text = "0";
                    textBoxNewBuy.SelectionStart = 2;
                }
                else
                if (textBoxNewBuy.Text.Length != 5)
                {
                    textBoxNewBuy.Text = "0" + textBoxNewBuy.Text;
                    textBoxNewBuy.SelectionStart = 1;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            if (chr == 44 && textBoxNewBuy.Text != "")
            {
                if (chr == 44 && textBoxNewBuy.SelectionStart == 5)
                {
                    e.Handled = true;
                }
                else
                if (fa.SearchComma(textBoxNewBuy.Text))
                { }
                else
                {
                    e.Handled = true;
                }
            }
            else
            if (!Char.IsDigit(chr) && chr != 8 || (textBoxNewBuy.Text.Length == 5 && chr == 44))
            {
                e.Handled = true;
            }
            else
            if (textBoxNewBuy.Text.Length != 1 && textBoxNewBuy.SelectionStart == 1 && textBoxNewBuy.Text[1] == 44 && chr == 8)
            {
                textBoxNewBuy.Text = textBoxNewBuy.Text.Remove(0, 2);
                e.Handled = true;
            }
            else
            if (textBoxNewBuy.Text.Length == 5 && chr != 8 && textBoxNewBuy.Text[4] == 44 && textBoxNewBuy.SelectionStart < 5)
            {
                textBoxNewBuy.Text = textBoxNewBuy.Text.Remove(4, 1);
                textBoxNewBuy.SelectionStart = selectindexstextbox;
            }
        }
    }
}
