using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess
{
    /// <summary>
    /// Conección a la base de datos
    /// </summary>
    public class DB_Connection
    {
        public string connDB_intranet = "Data Source=10.0.0.46\\BDAPPDEV;Initial Catalog=BD_INTRANET;User ID=developer;password=Developer.2022";
        public string connDB_name = "Data Source=10.0.0.46\\BDAPPDEV;Initial Catalog=BD_SEGURIDADES;User ID=developer;password=Developer.2022"; 
    }
}