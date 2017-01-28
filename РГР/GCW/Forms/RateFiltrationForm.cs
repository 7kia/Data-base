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
    public partial class RateFiltrationForm : Form
    {
        public string filter { get; set; }
        public string include { get; set; }
        public string orderBy { get; set; }


        public RateFiltrationForm()
        {
            InitializeComponent();

            filter = "";
        }

        private void radioNameRateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNameRateButton.Checked)
            {
                radioRateButton.Checked = false;
            }
        }

        private void radioRateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRateButton.Checked)
            {
                radioNameRateButton.Checked = false;
            }
        }

        private void radioSearchNameRateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchNameRateButton.Checked)
            {
                radioSearchRateButton.Checked = false;
            }
        }

        private void radioSearchRateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchRateButton.Checked)
            {
                radioSearchNameRateButton.Checked = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioNameRateButton.Checked)
            {
                orderBy = "Название тарифа";
            }
            else if (radioRateButton.Checked)
            {
                orderBy = "Тариф";
            }

            if (radioSearchNameRateButton.Checked)
            {
                filter = "Название тарифа";
            }
            else if (radioSearchRateButton.Checked)
            {
                filter = "Тариф";
            }

            if (filter.Length != 0)
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
            if ((radioNameRateButton.Checked && radioSearchNameRateButton.Checked)
                || (radioRateButton.Checked && radioSearchRateButton.Checked))
            {
                MessageBox.Show("Нельзя одновременно сортировать и искать по одной колонке", "Ошибка");
                return false;
            }

            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле для поиска по шаблону", "Ошибка");
                return false;
            }

            if (radioSearchRateButton.Checked)
            {
                uint res;
                if (!uint.TryParse(textBoxSearch.Text, out res))
                {
                    MessageBox.Show("Тариф должен быть положительным целым число", "Ошибка");
                    return false;
                }
            }
            return true;
        }
    }
}
