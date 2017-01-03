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
            IdApartments = reader.GetUInt32(2);
        }

        public CApartments(string address, uint idApartments)
        {
            Address = address;
            IdApartments = idApartments;
        }

        public uint Id { get; set; }
        public string Address { get; set; }
        public uint IdApartments { get; set; }

    }
}
