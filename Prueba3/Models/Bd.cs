using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prueba3.Models
{
    public class Bd {

        public static bool Conectar()
        {
            string cnnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camil\source\repos\Prueba3\Prueba3\App_Data\Database1.mdf;Integrated Security=True";
            SqlCommand cmdSelect;
            SqlDataReader dr;
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnStr))
                {
                    cnn.Open();

                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}