using MySql.Data.MySqlClient;

namespace GCW.Entities
{
    public class CService
    {
        public CService()
        {
        }
        public CService(MySqlDataReader reader)
        {
            Id = reader.GetUInt32(0);
            Name = reader.GetString(1);
        }

        public CService(string name)
        {
            Name = name;
        }

        public uint Id { get; set; }
        public string Name { get; set; }
    }
}
