using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGW;
using GCW.Entities;

namespace GCW.Forms
{
    public partial class PaymentForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CPayment m_payment;

        public PaymentForm()
        {
            InitializeComponent();
            m_payment = new CPayment();
            FillFields();
        }
        public PaymentForm(CPayment rate)
        {
            InitializeComponent();
            m_payment = rate;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            textNumber.Text = m_payment.NumberPayment.ToString();
            textSum.Text = m_payment.Sum.ToString();
        }

        private bool CheckFields()
        {
            if (textNumber.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Номер платежа\"", "Ошибка");
                return false;
            }
            if(!m_payment.IsCorrectNumberPaymentFormat(textNumber.Text))
            {
                return false;
            }

            uint res;
            if (textSum.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Сумма\"", "Ошибка");
                return false;
            }
            if (!uint.TryParse(textSum.Text, out res))
            {
                MessageBox.Show("В поле \"Сумма\" должно быть положительное целое число", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_payment.NumberPayment = uint.Parse(textNumber.Text);
            m_payment.Data = dateTimePicker.Value;
            m_payment.Sum = uint.Parse(textSum.Text);

            if (m_create)
            {
                m_mySqlWrapper.AddPayment(m_payment);
            }
            else
            {
                m_mySqlWrapper.UpdatePayment(m_payment);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
