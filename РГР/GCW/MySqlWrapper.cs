using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

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

    }
}
