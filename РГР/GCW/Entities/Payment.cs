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
            IdApartments = reader.GetUInt32(1);
            NumberPayment = reader.GetUInt32(2);
        }

        public CPayment(uint idService, uint idApartments, uint numberPayment)
        {
            IdApartments = idApartments;
            NumberPayment = NumberPayment;
        }

        public uint Id { get; set; }
        public uint IdApartments { get; set; }
        public uint NumberPayment { get; set; }
    }
}
