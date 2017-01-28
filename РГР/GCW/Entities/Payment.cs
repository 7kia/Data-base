using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GCW.Entities
{
    public class CPayment
    {
        public CPayment()
        {
        }
        public CPayment(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            NumberPayment = reader.GetUInt32(1);
            Data = reader.GetDateTime(2);
            Sum = reader.GetUInt32(3);
        }

        public CPayment(uint numberPayment, System.DateTime data, uint sum)
        {
            NumberPayment = NumberPayment;
            Data = data;
            Sum = sum;
        }

        public bool IsCorrectNumberPaymentFormat(string text)
        {
            if (text.Length != LENGTH_NUMBER)
            {
                MessageBox.Show(string.Format("Длина \"Номер платежа\" должна быть равна {0}", LENGTH_NUMBER), "Ошибка");
                return false;
            }

            uint res;
            if (!uint.TryParse(text, out res))
            {
                MessageBox.Show("В поле \"Номер платежа\" должно быть положительное целое число", "Ошибка");
                return false;
            }

            return true;
        }

        public uint Id { get; set; }
        public uint NumberPayment { get; set; }
        public System.DateTime Data { get; set; }
        public uint Sum { get; set; }

        public const uint LENGTH_NUMBER = 10;
    }
}
