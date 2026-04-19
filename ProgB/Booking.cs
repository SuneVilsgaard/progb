using Eksamensprjekt_forsøg2;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgB
{
    public class Booking
    {
        string type;
        string dato;


        public Booking OpretBooking(string Type, DateTime Dato)
        {
            string connectionString =
                      "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            MySqlCommand cmd = null;

            MySqlDataReader reader = null;

            try
            {
                conn.Open();

                string query = "INSERT INTO Courts(TypeOffCourt, Date)" +
                    "VALUES('@typeBane', @dato);";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@typeBane", Type);
                cmd.Parameters.AddWithValue("@dato", Dato);


                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Booking b = new Booking();

                    b.type = Convert.ToString(reader["Type"]);
                    b.dato = Convert.ToString(reader["Dato"]);
                    
                    MessageBox.Show("Du har booket en " + b.type +"bane d. " + b.dato);
                    
                    return b;

                }
            }
            finally
            {
                // Lukker reader (lukker result set)
                if (reader != null)
                    reader.Close();

                // Lukker forbindelsen til databasen
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }



    }
}
