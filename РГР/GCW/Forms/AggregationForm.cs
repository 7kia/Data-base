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
    public partial class AggregationForm : Form
    {
        private Table m_type;
        private MySqlWrapper m_mySqlWrapper;


        private List<string> tableNames = new List<string>()
        {
            "квартиры"
            , "оплата"
            , "тарифы услуг"
            , "услуги в квартире"
        };

        private List<string> aggregationFunc = new List<string>()
        {
            "MIN"
            , "MAX"
        };

        private List<string> apratmentColumns = new List<string>()
        {
            "`Номер платежа`"
        };

        private List<string> paymentColumns = new List<string>()
        {
            "`Номер платежа`"
            , "`Дата`"
            , "`Сумма`"
        };

        private List<string> rateColumns = new List<string>()
        {
            "`Тариф`"
        };

        private List<string> serviceToApartmentColumns = new List<string>()
        {
            "`Id квартиры`"
            , "`Id услуги`"
        };


        public AggregationForm(Table type, MySqlWrapper wrapper)
        {
            InitializeComponent();

            m_type = type;
            FillFields();

            m_mySqlWrapper = wrapper;
        }

        private void FillFields()
        {
            switch(m_type)
            {
                case Table.Apartments:
                    foreach (var element in apratmentColumns)
                    {
                        ColumnComboBox.Items.Add(element);
                    }
                    break;
                case Table.Payment:
                    foreach (var element in paymentColumns)
                    {
                        ColumnComboBox.Items.Add(element);
                    }
                    break;
                case Table.Rate:
                    foreach (var element in rateColumns)
                    {
                        ColumnComboBox.Items.Add(element);
                    }
                    break;
                case Table.ServiceToApartment:
                    foreach (var element in serviceToApartmentColumns)
                    {
                        ColumnComboBox.Items.Add(element);
                    }
                    break;
            };


            foreach (var element in aggregationFunc)
            {
                FuncComboBox.Items.Add(element);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            string tableName = "";
            switch(m_type)
            {
                case Table.Apartments:
                    tableName = tableNames[0];
                    break;
                case Table.Payment:
                    tableName = tableNames[1];
                    break;
                case Table.Rate:
                    tableName = tableNames[2];
                    break;
                case Table.ServiceToApartment:
                    tableName = tableNames[3];
                    break;
            }

            string request = string.Format("Select {0}(`{2}`.{1}) from `{2}`", FuncComboBox.Text, ColumnComboBox.Text, tableName);


            m_mySqlWrapper.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(request, m_mySqlWrapper.m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Type resultType = reader.GetValue(0).GetType();

                DateTime typeDate = new DateTime();
                if(resultType.Equals(1.GetType()))
                {
                    MessageBox.Show(string.Format("Результат = {0}", reader.GetUInt32(0)));
                }
                else if (resultType.Equals(typeDate.GetType()))
                {
                    MessageBox.Show(string.Format("Результат = {0}", reader.GetDateTime(0)));
                }
            }
            m_mySqlWrapper.CloseConnection();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckFields()
        {
            if (FuncComboBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Функция аггрегации\"", "Ошибка");
                return false;
            }

            if (!aggregationFunc.Contains(FuncComboBox.Text))
            {
                MessageBox.Show("В поле \"Функция аггрегации\" должен быть один  из существующих вариантов", "Ошибка");
                return false;
            }

            if (ColumnComboBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Столбец\"", "Ошибка");
                return false;
            }

            List<string> listCoulumns = new List<string>();
            switch (m_type)
            {
                case Table.Apartments:
                    listCoulumns = apratmentColumns;
                    break;
                case Table.Payment:
                    listCoulumns = paymentColumns;
                    break;
                case Table.Rate:
                    listCoulumns = rateColumns;
                    break;
                case Table.ServiceToApartment:
                    listCoulumns = serviceToApartmentColumns;
                    break;
            };
            if (!listCoulumns.Contains(ColumnComboBox.Text))
            {
                MessageBox.Show("В поле \"Столбец\" должен быть один  из существующих вариантов", "Ошибка");
                return false;
            }

            return true;
        }
    }
}
