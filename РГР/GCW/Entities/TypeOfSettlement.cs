using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CTypeOfSettlement
    {
        public CTypeOfSettlement()
        {
        }
        public CTypeOfSettlement(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            Name = reader.GetString(1);
        }

        public CTypeOfSettlement(string name)
        {
            Name = name;
        }

        public uint Id { get; set; }
        public string Name { get; set; }
    }
}
