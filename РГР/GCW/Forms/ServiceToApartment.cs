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
    public partial class ServiceToApartment : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CServiceToApartment m_rateOfPayment;

        public ServiceToApartment()
        {
            InitializeComponent();
            m_rateOfPayment = new CServiceToApartment();
            FillFields();
        }
        public ServiceToApartment(CServiceToApartment rateOfPayment)
        {
            InitializeComponent();
            m_rateOfPayment = rateOfPayment;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            var idApartments = m_mySqlWrapper.GetIdList(Table.Apartments);
            foreach (var element in idApartments)
            {
                comboBoxIdApartment.Items.Add(element);
            }

            var idService = m_mySqlWrapper.GetIdList(Table.Rate);
            foreach (var element in idService)
            {
                comboBoxIdService.Items.Add(element);
            }

        }

        private bool CheckFields()
        {
            if (comboBoxIdApartment.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id квартиры\"", "Ошибка");
                return false;
            }
            if (comboBoxIdService.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id услуги\"", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_rateOfPayment.IdApartment = uint.Parse(comboBoxIdApartment.Text);
            m_rateOfPayment.IdService = uint.Parse(comboBoxIdService.Text);

            if (m_create)
            {
                m_mySqlWrapper.AddServiceToApartment(m_rateOfPayment);
            }
            else
            {
                m_mySqlWrapper.UpdateServiceToApartment(m_rateOfPayment);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxIdApartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIdService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
