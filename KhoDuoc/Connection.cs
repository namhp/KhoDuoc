using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KhoDuoc
{
    public class Connection
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - F1276L2\NAMEXPRESS; Initial Catalog = KhoDuoc; Integrated Security = True");
    }
}
