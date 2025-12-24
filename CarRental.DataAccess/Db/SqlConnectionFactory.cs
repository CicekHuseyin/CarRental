using System.Configuration;
using System.Data.SqlClient;

namespace CarRental.DataAccess.Db
{
    public static class SqlConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            var connSetting =
                ConfigurationManager.ConnectionStrings["CarRentalDb"];

            if (connSetting == null)
                throw new Exception("CarRentalDb connection string bulunamadı.");

            return new SqlConnection(connSetting.ConnectionString);
        }
    }
}
