using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class ReportsData
    {
        private static readonly string _con;

        // Constructor estático: se ejecuta una sola vez
        static ReportsData()
        {
            // Carga el appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())   // Ruta del ejecutable
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _con = config.GetConnectionString("DefaultConnection");
        }

        public static DataTable Query(string sql)
        {
            using var con = new SqlConnection(_con);
            using var da = new SqlDataAdapter(sql, con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static object Scalar(string sql)
        {
            using var con = new SqlConnection(_con);
            using var cmd = new SqlCommand(sql, con);
            con.Open();
            return cmd.ExecuteScalar();
        }
    }

}
