using CGW;
using MySql.Data.MySqlClient;
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
    public partial class ServiceToApartmentFiltrarion : Form
    {
        public string filter { get; set; }
        public string include { get; set; }
        public string orderBy { get; set; }

        public ServiceToApartmentFiltrarion(MySqlConnection connection)
        {
            InitializeComponent();

            filter = "";
        }

        private void radioIdApartmentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdApartmentButton.Checked)
            {
                radioIdServiceButton.Checked = false;
            }
        }

        private void radioIdServiceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdServiceButton.Checked)
            {
                radioIdApartmentButton.Checked = false;
            }
        }

        private void radioSearchIdApartmentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchIdApartmentButton.Checked)
            {
                radioSearchIdServiceButton.Checked = false;
            }
        }

        private void radioSearchIdServiceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSearchIdServiceButton.Checked)
            {
                radioSearchIdApartmentButton.Checked = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioIdApartmentButton.Checked)
            {
                orderBy = "Id квартиры";
            }
            else if (radioIdServiceButton.Checked)
            {
                orderBy = "Id услуги";
            }

            if (radioSearchIdApartmentButton.Checked)
            {
                filter = "Id квартиры";
            }
            else if (radioSearchIdServiceButton.Checked)
            {
                filter = "Id услуги";
            }

            if (filter.Length != 0)
            {
                if (!CheckFields())
                    return;

                include = textSearchBox.Text;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckFields()
        {
            if ((radioIdServiceButton.Checked && radioSearchIdServiceButton.Checked)
                || (radioIdApartmentButton.Checked && radioSearchIdApartmentButton.Checked))
            {
                MessageBox.Show("Нельзя одновременно сортировать и искать по одной колонке", "Ошибка");
                return false;
            }

            if (textSearchBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле для поиска по шаблону", "Ошибка");
                return false;
            }

            uint res;
            if (!uint.TryParse(textSearchBox.Text, out res))
            {
                MessageBox.Show("В поле должно быть положительное целое число", "Ошибка");
                return false;
            }

            return true;
        }
    }
}
