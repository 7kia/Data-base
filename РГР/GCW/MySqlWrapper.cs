﻿using System;
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

    public class GetterWrapper
    {
        // TODO : do refactoring replace `<construction>` to name tables
        public List<string> tableNames = new List<string>()
        {
            "квартиры"
            , "оплата"
            , "тарифы услуг"
            , "услуги в квартире"
        };

        public List<string> apratmentColumns = new List<string>()
        {
            "`Id`"
            , "`Адрес`"
            , "`Номер платежа`"
        };
        public List<string> dependApratmentColumns = new List<string>()
        {
            "`Номер платежа`"
        };

        public List<string> paymentColumns = new List<string>()
        {
            "`Id`"
            , "`Номер платежа`"
            , "`Дата`"
            , "`Сумма`"
        };
        public List<string> dependPaymentColumns = new List<string>()
        {
        };

        public List<string> rateColumns = new List<string>()
        {
            "`Id`"
            , "`Название тарифа`"
            , "`Тариф`"
            , "`Logo кампании`"
        };
        public List<string> depenRateColumns = new List<string>()
        {
        };


        public List<string> serviceToApartmentColumns = new List<string>()
        {
            "`Id`"
            ,"`Id квартиры`"
            ,"`Id услуги`"
        };
        public List<string> dependServiceToApartmentColumns = new List<string>()
        {
            "`Id квартиры`"
            ,"`Id услуги`"
        };

        public MySqlConnection m_connection;
        public string m_source { get; set; }

        public GetterWrapper()
        {
            m_connection = new MySqlConnection();
            m_source = "Database=GCW;Data Source=127.0.0.1;User Id={0};Password={1}";
        }

        public GetterWrapper(MySqlConnection connection)
        {
            m_connection = connection;
            m_source = "Database=GCW;Data Source=127.0.0.1;User Id={0};Password={1}";
        }

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
                    var databaseRateOfPayment = GetListOfServiceToApartment();

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

        public List<string> GetNumberPaymentAsStringList()
        {
            List<string> result = new List<string>();
            var databasePayment = GetListOfPayment();

            foreach (CPayment element in databasePayment)
            {
                result.Add(element.NumberPayment.ToString());
            }

            return result;
        }

        public List<uint> GetNumberPaymentList()
        {
            List<uint> result = new List<uint>();
            var databasePayment = GetListOfPayment();

            foreach (CPayment element in databasePayment)
            {
                result.Add(element.NumberPayment);
            }

            return result;
        }


        public void OpenConnection()
        {
            try
            {
                m_connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                MessageBox.Show(e.Message, "Connection");
            }
        }

        public void CloseConnection()
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
        /// @columnsForSorting - столбцы со строками для сортировки(для ORDER BY
        /// @aggregationFunction - функция агрегации(min, max ...
        /// @columnsForSearch - колонка в которой искать, нужна для @aggregationFunction
        public IEnumerable<CServiceToApartment> GetListOfServiceToApartment(
              string filter = ""
            , string patternMatching = ""
            , string columnsForSorting = ""
            )
        {
            var list = new List<CServiceToApartment>();
            OpenConnection();
            string request = string.Format("SELECT * FROM `{0}`", tableNames[(int)Table.ServiceToApartment]);     

            if ((filter.Length != 0) && (patternMatching.Length != 0))
            {
                request += string.Format("where `{0}` = {1} ", filter, patternMatching);
            }
            else if((columnsForSorting.Length != 0))
            {
                request += string.Format("order by `{0}`", columnsForSorting);
            }           

            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new CServiceToApartment(reader));
            }
            CloseConnection();
            return list;
        }

        public IEnumerable<CApartments> GetListOfApartments(
              string filter = ""
            , string patternMatching = ""
            , string columnsForSorting = ""
            )
        {
            var list = new List<CApartments>();
            OpenConnection();
            var request = string.Format("SELECT * FROM `{0}`", tableNames[(int)Table.Apartments]);


            if (filter.Length != 0 && patternMatching.Length != 0)
            {
                if (filter == "Адрес")
                {
                    request += string.Format("where `{0}` = '{1}\' ", filter, patternMatching);
                }
                else
                {
                    request += string.Format("where `{0}` = {1} ", filter, patternMatching);
                }
            }

            if (columnsForSorting.Length != 0)
                request += "order by " + "`" + columnsForSorting + "`";


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CApartments(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CPayment> 
            GetListOfPayment(
              string filter = ""
            , string patternMatching = ""
            , string columnsForSorting = ""
            )
        {
            var list = new List<CPayment>();
            OpenConnection();
            var request = string.Format("SELECT * FROM `{0}`", tableNames[(int)Table.Payment]);

            if (filter.Length != 0 && patternMatching.Length != 0)
            {
                if (filter == "Дата")
                {
                    request += string.Format("where `{0}` = '{1}\' ", filter, patternMatching);
                }
                else
                {
                    request += string.Format("where `{0}` = {1} ", filter, patternMatching);
                }
            }

            if (columnsForSorting.Length != 0)
                request += "order by " + "`" + columnsForSorting + "`"; ;


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CPayment(reader));
            CloseConnection();
            return list;
        }

        public IEnumerable<CRate> GetListOfRate(
              string filter = ""
            , string patternMatching = ""
            , string columnsForSorting = ""
            )
        {
            var list = new List<CRate>();
            OpenConnection();
            var request = string.Format("SELECT * FROM `{0}`", tableNames[(int)Table.Rate]);

            if (filter.Length != 0 && patternMatching.Length != 0)
            {
                if (filter == "Название тарифа")
                {
                    request += string.Format("where `{0}` = '{1}\' ", filter, patternMatching);
                }
                else
                {
                    request += string.Format("where `{0}` = {1} ", filter, patternMatching);
                }
            }

            if (columnsForSorting.Length != 0)
                request += "order by " + "`" + columnsForSorting + "`";


            MySqlCommand cmd = new MySqlCommand(request, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CRate(reader));
            CloseConnection();
            return list;
        }

    };

    public class MySqlWrapper : GetterWrapper, IDisposable
    {
        // private members

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
        
        ////////////////////////////////////////////////
        ///  Update
        public void UpdateApartment(CApartments apartment)
        {
            var request = string.Format("UPDATE `{0}` SET `Адрес` = @адрес, `Номер платежа` = @номер WHERE id = @id"
                , tableNames[(int)Table.Apartments]);

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
            var request = string.Format("UPDATE `{0}` SET `Номер платежа` = @номер, `Дата` = @дата, `Сумма` = @сумма WHERE id = @id"        
                , tableNames[(int)Table.Payment]);
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
            var request = string.Format("UPDATE `{0}` SET `Название тарифа` = @названиеТарифа," +
                "`Тариф` = @Тариф, `Logo кампании` = @Logo WHERE id = @id"
                , tableNames[(int)Table.Rate]);


            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("id", rate.Id),
                new MySqlParameter("названиеТарифа", rate.NameRate),
                new MySqlParameter("Тариф", rate.Rate),
                new MySqlParameter("Logo", rate.PathLogo),
            }
            );
            Execute(command);
        }

        public void UpdateServiceToApartment(CServiceToApartment rateOfPayment)
        {
            var request = string.Format("UPDATE `{0}` SET " +
                          " `Id квартиры` = @Idквартиры, `Id услуги` = @Idуслуги WHERE id = @id"
               , tableNames[(int)Table.ServiceToApartment]);

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
            var request = string.Format("INSERT INTO `{0}`" +
                          "(" +
                          "`Адрес`, `Номер платежа`" +
                          ") " +
                          "VALUES " +
                          "(" +
                          "@адрес,@номер" +
                          ")"
                          , tableNames[(int)Table.Apartments]);

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
            var request = string.Format("INSERT INTO `{0}`" +
              "(" +
              "`Номер платежа`, `Дата`, `Сумма`" +
              ") " +
              "VALUES " +
              "(" +
              "@номер,@дата,@сумма" +
              ")"
               , tableNames[(int)Table.Payment]);

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
            var request = string.Format("INSERT INTO `{0}`" +
                            "(" +
                            "`Название тарифа`, `Тариф`, `Logo кампании`" +
                            ") " +
                            "VALUES " +
                            "(" +
                            "@названиеТарифа,@Тариф,@Logo" +
                            ")"
                             , tableNames[(int)Table.Rate]);

            var command = new MySqlCommand(request, m_connection);

            command.Parameters.AddRange(new MySqlParameter[]
            {
                new MySqlParameter("названиеТарифа", rate.NameRate),
                new MySqlParameter("Тариф", rate.Rate),
                new MySqlParameter("Logo", rate.PathLogo),
            }
            );
            Execute(command);
        }

        public void AddServiceToApartment(CServiceToApartment rateOfPayment)
        {
            var request = string.Format("INSERT INTO `{0}`" +
                "(" +
                "`Id квартиры`, `Id услуги`" +
                ") " +
                "VALUES " +
                "(" +
                "@Idквартиры,@Idуслуги" +
                ")"
                 , tableNames[(int)Table.ServiceToApartment]);


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
            var request = string.Format("DELETE FROM `{0}` WHERE id = @id", tableNames[(int)Table.Apartments]);
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", apartment.Id)
            });
            Execute(command);
        }

        public void RemovePayment(CPayment payment)
        {
            var request = string.Format("DELETE FROM `{0}` WHERE id = @id", tableNames[(int)Table.Payment]);
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", payment.Id)
            });
            Execute(command);
        }

        public void RemoveRate(CRate rate)
        {
            var request = string.Format("DELETE FROM `{0}` WHERE id = @id", tableNames[(int)Table.Rate]); ;
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", rate.Id)
            });
            Execute(command);
        }

        public void RemoveServiceToApartment(CServiceToApartment serviceToApartment)
        {
            var request = string.Format("DELETE FROM `{0}` WHERE id = @id", tableNames[(int)Table.ServiceToApartment]); ;
            var command = new MySqlCommand(request, m_connection);
            command.Parameters.AddRange(new MySqlParameter[]{
                new MySqlParameter("id", serviceToApartment.Id)
            });
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
