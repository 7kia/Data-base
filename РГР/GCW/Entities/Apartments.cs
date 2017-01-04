using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CApartments
    {
        public CApartments()
        {
        }
        public CApartments(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            Address = reader.GetString(1);
            NumberPayment = reader.GetUInt32(2);
        }

        public CApartments(string address, uint numberPayment)
        {
            Address = address;
            NumberPayment = numberPayment;
        }

        public uint Id { get; set; }
        public string Address { get; set; }
        public uint NumberPayment { get; set; }

    }
}
