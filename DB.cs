using System.Configuration;
using System.Data.SQLite;

namespace WisejWebPageApplication1
{
    public static class DB
    {
        public static SQLiteConnection GetConnection(bool autoOpen = true)
        {
            var newConn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DBString"].ConnectionString);
            if (autoOpen)
                newConn.Open();
            return newConn;
        }
    }
}
