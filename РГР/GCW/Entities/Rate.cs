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
            NameRate = reader.GetString(1);
            Rate = reader.GetUInt32(2);
            PathLogo = reader.GetString(3);
        }

        public CRate(string nameRate, uint rate, string pathLogo)
        {
            NameRate = nameRate;
            Rate = rate;
            PathLogo = pathLogo;
        }

        public uint Id { get; set; }
        public string NameRate { get; set; }
        public uint Rate { get; set; }
        public string PathLogo { get; set; }

    }
}
