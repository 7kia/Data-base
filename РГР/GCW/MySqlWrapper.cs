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
        /// @filter - ищем это значение
        /// @patternMatching - строка для сравнения с шаблоном
        /// @columnsForSorting - столбцы со строками для сортировки(для ORDER BY
        public IEnumerable<CService> GetListOfService(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CService>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */
           

            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CService(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CApartments> GetListOfApartments(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CApartments>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CApartments(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CPayment> GetListOfPayment(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CPayment>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CPayment(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CRate> GetListOfRate(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CRate>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CRate(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CRateOfPayment> GetListOfRateOfPayment(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CRateOfPayment>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CRateOfPayment(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CTypeOfSettlement> GetListOfTypeOfSettlement(string filter = "", string patternMatching = "", string columnsForSorting = "")
        {
            var list = new List<CTypeOfSettlement>();
            OpenConnection();
            var request = "SELECT * FROM `услуги` ";
            /*
             Add code for filter, patternMatching, columnsForSorting
             */


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CTypeOfSettlement(reader));
            CloseConnection();
            return list;
        }
        ////////////////////////////////////////////////
    }
}
