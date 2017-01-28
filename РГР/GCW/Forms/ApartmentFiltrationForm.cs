using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCW.Entities;

namespace GCW.Forms
{
    public partial class ApartmentFiltrationForm : Form
    {
        private CPayment m_payment;

        public string filter { get; set; }
        public string include { get; set; }
        public string orderBy { get; set; }

        public ApartmentFiltrationForm()
        {
            InitializeComponent();

            filter = "";
            m_payment = new CPayment();
            radioAddressButton.Checked = false;
            radioNumberPaymentButton.Checked = false;

            radioSearchAddressButton.Checked = false;
            radioSearchNumberPaymentButton.Checked = false;
        }

        private void radioAddressButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAddressButton.Checked)
            {
                radioNumberPaymentButton.Checked = false;
            }
        }

        private void radioNumberPaymentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNumberPaymentButton.Checked)
            {
                radioAddressButton.Checked = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(radioNumberPaymentButton.Checked)
            {
                orderBy = "Номер платежа";
            }
            else if(radioAddressButton.Checked)
            {
                orderBy = "Адрес";
            }

            if (radioSearchNumberPaymentButton.Checked)
            {
                filter = "Номер платежа";
            }
            else if (radioSearchAddressButton.Checked)
            {
                filter = "Адрес";
            }

            if(filter.Length != 0)
            {
                if (!CheckFields())
                    return;

                include = textBoxSearch.Text;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckFields()
        {
            if((radioNumberPaymentButton.Checked && radioSearchNumberPaymentButton.Checked)
                || (radioAddressButton.Checked && radioSearchAddressButton.Checked))
            {
                MessageBox.Show("Нельзя одновременно сортировать и искать по одной колонке", "Ошибка");
                return false;
            }

            if (textBoxSearch.Text.Length == 0)
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
            else if (radioSearchAddressButton.Checked)
            {
                if (textBoxSearch.Text.Length == 0)
                {
                    MessageBox.Show("Заполните поле для поиска по шаблону", "Ошибка");
                    return false;
                }
            }

            return true;
        }

        private void radioSearchAddressButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchAddressButton.Checked)
            {
                radioSearchNumberPaymentButton.Checked = false;
            }
        }

        private void radioSearchNumberPaymentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchNumberPaymentButton.Checked)
            {
                radioSearchAddressButton.Checked = false;
            }
        }
    }
}
