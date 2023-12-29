using System.Configuration;

namespace NREditor
{
    public static class ConnectionStrings
    {
        public static string connectionString => ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
    }
}
