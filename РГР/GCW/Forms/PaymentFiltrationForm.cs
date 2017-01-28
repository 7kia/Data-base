using GCW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCW.Forms
{
    public partial class PaymentFiltrationForm : Form
    {
        private CPayment m_payment;

        public string filter { get; set; }
        public string include { get; set; }
        public string orderBy { get; set; }


        public PaymentFiltrationForm()
        {
            InitializeComponent();

            m_payment = new CPayment();
            filter = "";
        }

        private void radioDataButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDataButton.Checked)
            {
                radioNumberPaymentButton.Checked = false;
                radioSumButton.Checked = false;
            }
        }

        private void radioNumberPaymentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNumberPaymentButton.Checked)
            {
                radioDataButton.Checked = false;
                radioSumButton.Checked = false;
            }
        }

        private void radioSumButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSumButton.Checked)
            {
                radioDataButton.Checked = false;
                radioNumberPaymentButton.Checked = false;
            }
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioNumberPaymentButton.Checked)
            {
                orderBy = "Номер платежа";
            }
            else if (radioDataButton.Checked)
            {
                orderBy = "Дата";
            }
            else if (radioSumButton.Checked)
            {
                orderBy = "Сумма";
            }

            if (radioSearchNumberPaymentButton.Checked)
            {
                filter = "Номер платежа";
            }
            else if (radioSearchDataButton.Checked)
            {
                filter = "Дата";
            }
            else if (radioSearchSumButton.Checked)
            {
                filter = "Сумма";
            }

            if (filter.Length != 0)
            {
                if (!CheckFields())
                    return;

                if (radioSearchDataButton.Checked)
                {
                    include = dateTimePicker.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    include = textBoxSearch.Text;
                }
            }

            this.DialogResult = DialogResult.OK;
            Close();

        }

        private bool CheckFields()
        {
            if ((radioNumberPaymentButton.Checked && radioSearchNumberPaymentButton.Checked)
                || (radioDataButton.Checked && radioSearchDataButton.Checked)
                || (radioSumButton.Checked && radioSearchSumButton.Checked))
            {
                MessageBox.Show("Нельзя одновременно сортировать и искать по одной колонке", "Ошибка");
                return false;
            }

            if ((textBoxSearch.Text.Length == 0) && !radioSearchDataButton.Checked)
            {
                MessageBox.Show("Заполните поле для поиска по шаблону", "Ошибка");
                return false;
            }

            if (radioSearchNumberPaymentButton.Checked)
            {
                if (!m_payment.IsCorrectNumberPaymentFormat(textBoxSearch.Text))
                {
                    return false;
                }
            }
            else if (radioSearchSumButton.Checked)
            {
                if (textBoxSearch.Text.Length == 0)
                {
                    MessageBox.Show("Заполните поле для поиска по шаблону", "Ошибка");
                    return false;
                }

                uint res;
                if (!uint.TryParse(textBoxSearch.Text, out res))
                {
                    MessageBox.Show("Cумма должна быть положительным целым число", "Ошибка");
                    return false;
                }
            }

            return true;
        }

        private void radioSearchSumButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchSumButton.Checked)
            {
                radioSearchNumberPaymentButton.Checked = false;
                radioSearchDataButton.Checked = false;

                textBoxSearch.Visible = true;
                dateTimePicker.Visible = false;
            }
        }

        private void radioSearchNumberPaymentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchNumberPaymentButton.Checked)
            {
                radioSearchDataButton.Checked = false;
                radioSearchSumButton.Checked = false;

                textBoxSearch.Visible = true;
                dateTimePicker.Visible = false;
            }
        }

        private void radioSearchDataButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchDataButton.Checked)
            {
                radioSearchSumButton.Checked = false;
                radioSearchNumberPaymentButton.Checked = false;

                textBoxSearch.Visible = false;
                dateTimePicker.Visible = true;
            }
        }


    }
}
