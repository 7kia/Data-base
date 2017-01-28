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
            textBoxNameRate.Text = m_rate.NameRate;
            textBoxRate.Text = m_rate.Rate.ToString();
        }

        private bool CheckFields()
        {
            if (textBoxNameRate.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Название тарифа\"", "Ошибка");
                return false;
            }

            uint res;
            if (!uint.TryParse(textBoxRate.Text, out res))
            {
                MessageBox.Show("В поле \"Тариф\" должно быть положительное целое число", "Ошибка");
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

            m_rate.NameRate = textBoxNameRate.Text;
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
