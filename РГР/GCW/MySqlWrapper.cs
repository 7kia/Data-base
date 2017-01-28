using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using GCW.Entities;
using CGW;

namespace CGW
{
    public enum Table// For future entities
    {
        Apartments  = 0
        , Payment
        , Rate
        , ServiceToApartment
    };


    public class Names
    {
        NameTables()
        {
            tables = new List<KeyValuePair<Table, string>>()
            {
                new KeyValuePair<Table, string>(Table.Apartments, "`квартиры`"),
                new KeyValuePair<Table, string>(Table.Payment, "`оплата`"),
                new KeyValuePair<Table, string>(Table.Rate, "`тарифы услуг`"),
                new KeyValuePair<Table, string>(Table.ServiceToApartment, "`услуги в квартире`"),
            }
        }

        public List<KeyValuePair<Table, string>> tables;

    };
    

    public class MySqlWrapper : IDisposable
    {
        // private members

        private const string m_source = "Database=GCW;Data Source=127.0.0.1;User Id={0};Password={1}";
        private MySqlConnection m_connection;

        // public methods

        public MySqlWrapper()
        {
            var settings = Settings.Instance;
            string source = string.Format(m_source, settings.Login, settings.Password);
            m_connection = new MySqlConnection(source);

            try
            {
                m_connection.Open();
                m_connection.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Execute error");
            }        
        }

        ~MySqlWrapper()
        {
        }

        public void Dispose()
        {
            m_connection.Dispose();
        }
        
        private void OpenConnection()
        {
            try
            {
                m_connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Connection failed");
                MessageBox.Show(e.Message, "Connection");
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (m_connection != null)
                {
                    m_connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Closing connection failed");
                MessageBox.Show(e.Message, "Closing connection");
            }
        }

        ////////////////////////////////////////////////
        /// GetListOf
        /// 
        /// @filter - ищем это значение
        /// @patternMatching - строка для сравнения с шаблоном
        /// @orderBy - столбцы со строками для сортировки(для ORDER BY
        public IEnumerable<CService> GetListOfServiceToApartment(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CService>();
            OpenConnection();
            var request = "SELECT * FROM `услуги в квартире` ";
            /*
             Add code for filter, patternMatching, orderBy
             */
           

            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CService(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CApartments> GetListOfApartments(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CApartments>();
            OpenConnection();
            var request = "SELECT * FROM `квартиры` ";
            /*
             Add code for filter, patternMatching, orderBy
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CApartments(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CPayment> GetListOfPayment(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CPayment>();
            OpenConnection();
            var request = "SELECT * FROM `оплата` ";
            /*
             Add code for filter, patternMatching, orderBy
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CPayment(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CRate> GetListOfRate(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CRate>();
            OpenConnection();
            var request = "SELECT * FROM `тарифы услуг` ";
            /*
             Add code for filter, patternMatching, orderBy
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CRate(reader));
            CloseConnection();
            return list;
        }
        ////////////////////////////////////////////////
        ///  Update
        public void UpdateApartment(CApartments apartment)
        {
            var request = "UPDATE `квартиры` SET `Адрес` = @адрес, `Номер платежа` = @номер WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", apartment.Id),
                new MySqlParameter("адрес", apartment.Address),
                new MySqlParameter("номер", apartment.NumberPayment),
            }
            );
            Execute(command);
        }

        public void UpdatePayment(CPayment payment)
        {
            var request = "UPDATE `оплата` SET `Номер платежа` = @номер, `Дата` = @дата, `Сумма` = @сумма WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", payment.Id),
                new MySqlParameter("номер", payment.NumberPayment),
                new MySqlParameter("дата", payment.Data),
                new MySqlParameter("сумма", payment.Sum),
            }
            );
            Execute(command);
        }

        public void UpdateRate(CRate rate)
        {
            var request = "UPDATE `тариф` SET `Название тарифа` = @названиеТарифа," +
                "`Тариф` = @Тариф WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", rate.Id),
                new MySqlParameter("названиеТарифа", rate.NameRate),
                new MySqlParameter("Тариф", rate.Rate),
            }
            );
            Execute(command);
        }

        public void UpdateServiceToApartment(CServiceToApartment rateOfPayment)
        {
            var request = "UPDATE `тарифы услуг` SET " +
                          " `Id квартиры` = @Idквартиры, `Id услуги` = @Idуслуги WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", rateOfPayment.Id),
                new MySqlParameter("Idквартиры", rateOfPayment.IdApartment),
                new MySqlParameter("Idуслуги", rateOfPayment.IdService),
            }
            );
            Execute(command);
        }

        ////////////////////////////////////////////////
        /// Add
        public void AddApartment(CApartments apartment)
        {
            var request = "INSERT INTO `квартиры`" +
                          "(" +
                          "`Адрес`, `Номер платежа`" +
                          ") " +
                          "VALUES " +
                          "(" +
                          "@адрес,@номер" +
                          ")";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("адрес", apartment.Address),
                new MySqlParameter("номер", apartment.NumberPayment),
            }
            );
            Execute(command);
        }

        public void AddPayment(CPayment payment)
        {
            var request = "INSERT INTO `оплата`" +
              "(" +
              "`Номер платежа`, `Дата`, `Сумма`" +
              ") " +
              "VALUES " +
              "(" +
              "@номер,@дата,@сумма" +
              ")";

            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("номер", payment.NumberPayment),
                new MySqlParameter("дата", payment.Data),
                new MySqlParameter("сумма", payment.Sum),
            }
            );
            Execute(command);
        }

        public void AddRate(CRate rate)
        {
            var request = "INSERT INTO `тарифы услуг`" +
                            "(" +
                            "`Название тарифа`, `Тариф`" +
                            ") " +
                            "VALUES " +
                            "(" +
                            "@названиеТарифа,@Тариф" +
                            ")";

            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("названиеТарифа", rate.NameRate),
                new MySqlParameter("Тариф", rate.Rate),
            }
            );
            Execute(command);
        }

        public void AddServiceToApartment(CServiceToApartment rateOfPayment)
        {
            var request = "INSERT INTO `тарифы услуг`" +
                "(" +
                "`Id квартиры`, `Id услуги`" +
                ") " +
                "VALUES " +
                "(" +
                "@IdТарифа,@IdПлатежа,@Оплачено" +
                ")";


            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("Idквартиры", rateOfPayment.IdApartment),
                new MySqlParameter("Idуслуги", rateOfPayment.IdService),
            }
            );
            Execute(command);
        }

        ////////////////////////////////////////////////
        /// Remove
        public void RemoveApartment(CApartments apartment)
        {
            var request = "DELETE FROM `квартиры` WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", apartment.Id)
            });
            Execute(command);
        }

        public void RemovePayment(CPayment payment)
        {
            var request = "DELETE FROM `оплата` WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", payment.Id)
            });
            Execute(command);
        }

        public void RemoveRate(CRate rate)
        {
            var request = "DELETE FROM `тарифы услуг` WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", rate.Id)
            });
            Execute(command);
        }
        ////////////////////////////////////////////////
        public List<string> GetIdList(Table table)
        {
            List<string> result = new List<string>();

            switch (table)
            {
                case Table.Apartments:
                    var databaseApartments = GetListOfApartments();

                    foreach (CApartments element in databaseApartments)
                    {
                        result.Add(element.Id.ToString());
                    }
                    break;
                case Table.Payment:
                    var databasePayment = GetListOfPayment();

                    foreach (CPayment element in databasePayment)
                    {
                        result.Add(element.Id.ToString());
                    }
                    break;
                case Table.Rate:
                    var databaseRate = GetListOfRate();

                    foreach (CRate element in databaseRate)
                    {
                        result.Add(element.Id.ToString());
                    }
                    break;
                case Table.ServiceToApartment:
                    var databaseRateOfPayment = GetListOfRateOfPayment();

                    foreach (CServiceToApartment element in databaseRateOfPayment)
                    {
                        result.Add(element.Id.ToString());
                    }
                    break;                
                default:
                    break;
            }
            
            return result;
        }

        public List<string> GetNumberPaymentList()
        {
            List<string> result = new List<string>();
            var databasePayment = GetListOfPayment();

            foreach (CPayment element in databasePayment)
            {
                result.Add(element.NumberPayment.ToString());
            }

            return result;
        }


        private void Execute(MySqlCommand command)
        {
            try
            {
                OpenConnection();
                command.Prepare();// Проверка парметров
                command.ExecuteNonQuery();// выполнение комманды
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Execute error");
            }
            finally
            {
                CloseConnection();
            }

            CloseConnection();
        }
    }
}
