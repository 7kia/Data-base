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
    public partial class ApartmentForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CApartments m_apartments;

        public ApartmentForm()
        {
            InitializeComponent();
            m_apartments = new CApartments();
            FillFields();
        }
        public ApartmentForm(CApartments apartments)
        {
            InitializeComponent();
            m_apartments = apartments;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            var idRates = m_mySqlWrapper.GetIdList(Table.Payment);
            foreach (var element in idRates)
            {
                comboBoxPaymentNumber.Items.Add(element);
            }

            textBoxAddress.Text = m_apartments.Address.ToString();
        }

        private bool CheckFields()
        {
            if (textBoxAddress.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Адрес\"", "Ошибка");
                return false;
            }
            if (comboBoxPaymentNumber.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Номер платежа\"", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_apartments.Address = textBoxAddress.Text;
            m_apartments.NumberPayment = uint.Parse(comboBoxPaymentNumber.Text);

            if (m_create)
            {
                m_mySqlWrapper.AddApartment(m_apartments);
            }
            else
            {
                m_mySqlWrapper.UpdateApartment(m_apartments);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
