using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using GCW.Entities;

namespace CGW
{
    public enum Table// For future entities
    {
        Apartments
        , Payment
        , Rate
        , RateOfPayment
        , TypeOfSettlement
        , Service
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
        public IEnumerable<CService> GetListOfService(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CService>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
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
            var request = "SELECT * FROM `тариф` ";
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

        public IEnumerable<CRateOfPayment> GetListOfRateOfPayment(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CRateOfPayment>();
            OpenConnection();
            var request = "SELECT * FROM `тариф в платеже` ";
            /*
             Add code for filter, patternMatching, orderBy
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CRateOfPayment(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CTypeOfSettlement> GetListOfTypeOfSettlement(string filter = "", string patternMatching = "", string orderBy = "")
        {
            var list = new List<CTypeOfSettlement>();
            OpenConnection();
            var request = "SELECT * FROM `тип населённого пункта` ";
            /*
             Add code for filter, patternMatching, orderBy
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CTypeOfSettlement(reader));
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
            var request = "UPDATE `оплата` SET `Id квартиры` = @IdКвартиры, `Номер платежа` = @номер WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", payment.Id),
                new MySqlParameter("IdКвартиры", payment.IdApartments),
                new MySqlParameter("номер", payment.NumberPayment),
            }
            );
            Execute(command);
        }

        public void UpdateRate(CRate rate)
        {
            var request = "UPDATE `тариф` SET `Id услуги` = @IdУслуги," +
                          " `Id типа населенного пункта` = @IdПункта, `Тариф` = @Тариф WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", rate.Id),
                new MySqlParameter("IdУслуги", rate.IdService),
                new MySqlParameter("IdПункта", rate.IdSettlement),
                new MySqlParameter("Тариф", rate.Rate),
            }
            );
            Execute(command);
        }

        public void UpdateRateOfPayment(CRateOfPayment rateOfPayment)
        {
            var request = "UPDATE `тариф в платеже` SET `Id тарифа` = @IdТарифа," +
                          " `Id платежа` = @IdПлатежа, `Оплачено` = @Оплачено WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", rateOfPayment.Id),
                new MySqlParameter("IdТарифа", rateOfPayment.IdRate),
                new MySqlParameter("IdПлатежа", rateOfPayment.IdPayment),
                new MySqlParameter("Оплачено", rateOfPayment.IsPaid),
            }
            );
            Execute(command);
        }

        public void UpdateTypeOfSettlement(CTypeOfSettlement typeOfSettlement)
        {
            var request = "UPDATE `Тип населенного пункта` SET `Название` = @название WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", typeOfSettlement.Id),
                new MySqlParameter("название", typeOfSettlement.Name),
            }
            );
            Execute(command);
        }

        public void UpdateService(CService service)
        {
            var request = "UPDATE `услуги` SET `Название` = @название WHERE id = @id";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", service.Id),
                new MySqlParameter("название", service.Name),
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
              "`Id квартиры`, `Номер платежа`" +
              ") " +
              "VALUES " +
              "(" +
              "@IdКвартиры,@номер" +
              ")";

            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("IdКвартиры", payment.IdApartments),
                new MySqlParameter("номер", payment.NumberPayment),
            }
            );
            Execute(command);
        }

        public void AddRate(CRate rate)
        {
            var request = "INSERT INTO `тариф`" +
                            "(" +
                            "`Id услуги`, `Id типа населенного пункта`, `Тариф`" +
                            ") " +
                            "VALUES " +
                            "(" +
                            "@IdУслуги,@IdПункта,@Тариф" +
                            ")";

            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("IdУслуги", rate.IdService),
                new MySqlParameter("IdПункта", rate.IdSettlement),
                new MySqlParameter("Тариф", rate.Rate),
            }
            );
            Execute(command);
        }

        public void AddRateOfPayment(CRateOfPayment rateOfPayment)
        {
            var request = "INSERT INTO `тариф в платеже`" +
                "(" +
                "`Id тарифа`, `Id платежа`, `Оплачено`" +
                ") " +
                "VALUES " +
                "(" +
                "@IdТарифа,@IdПлатежа,@Оплачено" +
                ")";


            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("IdТарифа", rateOfPayment.IdRate),
                new MySqlParameter("IdПлатежа", rateOfPayment.IdPayment),
                new MySqlParameter("Оплачено", rateOfPayment.IsPaid),
            }
            );
            Execute(command);
        }

        public void AddTypeOfSettlement(CTypeOfSettlement typeOfSettlement)
        {
            var request = "INSERT INTO `Тип населенного пункта`" +
               "(" +
               "`Название`" +
               ") " +
               "VALUES " +
               "(" +
               "@название" +
               ")";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("название", typeOfSettlement.Name),
            }
            );
            Execute(command);
        }

        public void AddService(CService service)
        {
            var request = "INSERT INTO `услуги`" +
              "(" +
              "`Название`" +
              ") " +
              "VALUES " +
              "(" +
              "@название" +
              ")";
            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("название", service.Name),
            }
            );
            Execute(command);
        }
        ////////////////////////////////////////////////
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
