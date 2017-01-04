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
    public partial class RateOfPaymentForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CRateOfPayment m_rateOfPayment;

        public RateOfPaymentForm()
        {
            InitializeComponent();
            m_rateOfPayment = new CRateOfPayment();
            FillFields();
        }
        public RateOfPaymentForm(CRateOfPayment rateOfPayment)
        {
            InitializeComponent();
            m_rateOfPayment = rateOfPayment;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            var idRates = m_mySqlWrapper.GetIdList(Table.Rate);
            foreach (var element in idRates)
            {
                comboBoxIdRate.Items.Add(element);
            }

            var idPayments = m_mySqlWrapper.GetIdList(Table.Payment);
            foreach (var element in idPayments)
            {
                comboBoxPayment.Items.Add(element);
            }

            checkBoxIsPaid.Checked = m_rateOfPayment.IsPaid;
        }

        private bool CheckFields()
        {
            if (comboBoxIdRate.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id тарифа\"", "Ошибка");
                return false;
            }
            if (comboBoxPayment.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id платежа\"", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_rateOfPayment.IdRate = uint.Parse(comboBoxIdRate.Text);
            m_rateOfPayment.IdPayment = uint.Parse(comboBoxPayment.Text);
            m_rateOfPayment.IsPaid = checkBoxIsPaid.Checked;

            if (m_create)
            {
                m_mySqlWrapper.AddRateOfPayment(m_rateOfPayment);
            }
            else
            {
                m_mySqlWrapper.UpdateRateOfPayment(m_rateOfPayment);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
