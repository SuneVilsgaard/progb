using Eksamensprjekt_forsøg2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgB
{
    public class Admin : Kunde
    { 
        public int LoginAdmin(string brugernavn, string kodeord)
        {
            string connectionString =
              "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            // MySqlCommand repræsenterer en SQL-forespørgsel vi vil sende til databasen
            MySqlCommand cmd = null;

            // MySqlDataReader svarer til et ResultSet fra databasen
            // Den bruges til at læse resultatet én række ad gangen
            MySqlDataReader reader = null;

            try
            {
                conn.Open();

                string query = "SELECT CustomerID FROM Kunde WHERE Username = @brugernavn AND Password = SHA2('@kodeord', 224) AND IsAdmin = true;";
                
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@brugernavn", brugernavn);
                cmd.Parameters.AddWithValue("@kodeord", kodeord);



                object Result = cmd.ExecuteScalar();

                if (Result == null)
                {
                    MessageBox.Show("Login mislykkedes");
                }
                else
                {
                    CustomerID = Convert.ToInt32(Result);
                    MessageBox.Show("TILLYKE: Login lykkedes, du er nu officielt administrator");
                    return CustomerID;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

            }
            return 0;
        }


    }
}
