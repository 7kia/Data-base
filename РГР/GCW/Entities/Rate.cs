using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CRate
    {
        public CRate()
        {
        }
        public CRate(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            IdService = reader.GetUInt32(1);
            IdSettlement = reader.GetUInt32(2);
            Rate = reader.GetUInt32(3);
        }

        public CRate(uint idService, uint idSettlement, uint rate)
        {
            IdService = idService;
            IdSettlement = idSettlement;
            Rate = rate;
        }

        public uint Id { get; set; }
        public uint IdService { get; set; }
        public uint IdSettlement { get; set; }
        public uint Rate { get; set; }

    }
}
