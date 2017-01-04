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
    public partial class RateForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CRate m_rate;

        public RateForm()
        {
            InitializeComponent();
            m_rate = new CRate();
            FillFields();
        }
        public RateForm(CRate rate)
        {
            InitializeComponent();
            m_rate = rate;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            var idRates = m_mySqlWrapper.GetIdList(Table.Service);
            foreach (var element in idRates)
            {
                comboBoxService.Items.Add(element);
            }

            var idPayments = m_mySqlWrapper.GetIdList(Table.TypeOfSettlement);
            foreach (var element in idPayments)
            {
                comboBoxSetlement.Items.Add(element);
            }

            textBoxRate.Text = m_rate.Rate.ToString();
        }

        private bool CheckFields()
        {
            if (comboBoxService.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id услуги\"", "Ошибка");
                return false;
            }
            if (comboBoxSetlement.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Id тип населённого пункта\"", "Ошибка");
                return false;
            }
            if (textBoxRate.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Тариф\"", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_rate.IdService = uint.Parse(comboBoxService.Text);
            m_rate.IdSettlement = uint.Parse(comboBoxSetlement.Text);
            m_rate.Rate = uint.Parse(textBoxRate.Text);

            if (m_create)
            {
                m_mySqlWrapper.AddRate(m_rate);
            }
            else
            {
                m_mySqlWrapper.UpdateRate(m_rate);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
