using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess
{
    /// <summary>
    /// Conección a la base de datos
    /// </summary>
    public class DB_Connection
    {
        public string connDB_prod = "Data Source=MAT-CRE025\\SQLEXPRESS;Initial Catalog=BD_SEGURIDADES;Integrated Security=SSPI;";
        public string connDB_name = "Data Source=SRVWINBDWH\\ORIGINARSA;Initial Catalog=BD_SEGURIDADES;User ID=dpaz;password=P@ssw0rd.01"; 
    }
}