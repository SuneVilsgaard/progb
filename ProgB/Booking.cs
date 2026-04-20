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
        DateTime dato;
        string tidspunkt;

        public Booking OpretBooking(string Type, DateTime Dato, string Tidspunkt)
        {
            string connectionString =
                      "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            MySqlCommand cmd = null;

            MySqlDataReader reader = null;

            try
            {
                conn.Open();

                string query = "INSERT INTO Courts(TypeOffCourt, Date, Time)" +
                    "VALUES(@type, @dato, @tidspunkt);";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@dato", Dato);
                cmd.Parameters.AddWithValue("@tidspunkt", Tidspunkt);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0) 
                {
                    Booking b = new Booking();

                    b.type = Type;
                    b.dato = Dato;
                    b.tidspunkt = Tidspunkt;
                    
                    MessageBox.Show("Du har booket en " + b.type + "bane d. " + b.dato + " til tidspunktet: " + b.tidspunkt);
                    
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
