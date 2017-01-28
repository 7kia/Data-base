using MySql.Data.MySqlClient;

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

        public uint Id { get; set; }
        public uint NumberPayment { get; set; }
        public System.DateTime Data { get; set; }
        public uint Sum { get; set; }
    }
}
