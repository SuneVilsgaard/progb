using Eksamensprjekt_forsøg2;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            MySqlCommand cmd2 = null;

            MySqlDataReader reader = null;

            try
            {
                conn.Open();

                string query = "INSERT INTO Courts(TypeOffCourt, Date, Time)" +
                    "VALUES(@type, @dato, @tidspunkt);";

                string query2 = "SELECT CourtID FROM Courts WHERE Date=@dato AND Time=@tidspunkt;";



                cmd = new MySqlCommand(query, conn);
                cmd2 = new MySqlCommand(query2, conn);


                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@dato", Dato);
                cmd.Parameters.AddWithValue("@tidspunkt", Tidspunkt);
                
                cmd2.Parameters.AddWithValue("@tidspunkt", Tidspunkt);
                cmd2.Parameters.AddWithValue("@dato", Dato);

                reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Tidspunktet er taget..");
                }
                else
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Booking b = new Booking();

                        b.type = Type;
                        b.dato = Dato;
                        b.tidspunkt = Tidspunkt;

                        MessageBox.Show("Du har booket en " + b.type + "bane d. " + Dato.Day + "-" + Dato.Month + "-" + Dato.Year + " kl. " + b.tidspunkt);

                        return b;

                    }
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


        public void CheckBooking()
        {

        }

        public void SletBooking()
        {
            string connectionString =
          "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            MySqlCommand cmd = null;

            MySqlDataReader reader = null;

            try
            {
                conn.Open();

                string query = "DELETE FROM Courts WHERE CourtID";
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }





    }
}
