using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AgilesGloboGroup.Services
{
    public class Conexion
    {
        string cade = "Data Source=JESUSLLAYA\\SQLEXPRESS;Initial Catalog=GloboGroup;Integrated Security=True";
        SqlConnection cn;

        public SqlConnection conexionBD()
        {
            cn = new SqlConnection(cade);
            return cn;
        }
    }
}