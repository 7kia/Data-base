using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CServiceToApartment
    {
        public CServiceToApartment()
        {
        }
        public CServiceToApartment(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            IdApartment = reader.GetUInt32(1);
            IdService = reader.GetUInt32(2);
        }

        public CServiceToApartment(uint idApartment, uint idService)
        {
            IdApartment = idApartment;
            IdService = idService;
        }

        public uint Id { get; set; }
        public uint IdApartment { get; set; }
        public uint IdService { get; set; }

    }
}
