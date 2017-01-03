using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CRateOfPayment
    {
        public CRateOfPayment()
        {
        }
        public CRateOfPayment(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            IdRate = reader.GetUInt32(1);
            IdPayment = reader.GetUInt32(2);
            IsPaid = reader.GetBoolean(3);
        }

        public CRateOfPayment(uint idRate, uint idPayment, bool isPaid)
        {
            IdRate = idRate;
            IdPayment = idPayment;
            IsPaid = isPaid;
        }

        public uint Id { get; set; }
        public uint IdRate { get; set; }
        public uint IdPayment { get; set; }
        public bool IsPaid { get; set; }

    }
}
