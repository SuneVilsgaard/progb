using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Crypto;
using ProgB;

namespace Eksamensprjekt_forsøg2
{
    public class Kunde
    {
        public string Fornavn;
        public string Efternavn;
        public int Alder;
        public string Brugernavn;
        public string Kodeord;

        public static int CustomerID;




        public Kunde SignUp(string fornavn, string efternavn, int alder, string brugernavn, string kodeord)
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
                // Åbner forbindelsen til databasen
                conn.Open();

                // SQL-forespørgslen vi sender til databasen
                string query = "INSERT INTO Kunde (firstname,LastName ,Age, Username, password, IsAdmin)" +
                    "VALUES (@Fornavn, @efternavn, @alder, @brugernavn, Sha2(@kodeord,224), 0);";


                // Opretter kommando-objektet og kobler det til forbindelsen
                cmd = new MySqlCommand(query, conn);

                // Parameter (@id) beskytter mod SQL injection
                // og sender værdien sikkert til databasen

                if (fornavn == null || efternavn == null || alder == 0 || brugernavn == null || kodeord == null)
                {
                    MessageBox.Show("Alle felter skal være udfyldt");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Fornavn", fornavn);
                    cmd.Parameters.AddWithValue("@efternavn", efternavn);
                    cmd.Parameters.AddWithValue("@alder", alder);
                    cmd.Parameters.AddWithValue("@brugernavn", brugernavn);
                    cmd.Parameters.AddWithValue("@kodeord", kodeord);



                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        // Her mapper vi database-rækken over i et C# objekt
                        Kunde k = new Kunde();

                        // reader["Kolonnenavn"] henter værdien fra result set
                        // Convert bruges fordi databasen returnerer et object
                        k.Fornavn = fornavn;
                        k.Efternavn = efternavn;
                        k.Alder = alder;
                        k.Brugernavn = brugernavn;
                        k.Kodeord = kodeord;

                        MessageBox.Show("Du har nu lavet en konto, og reader er ikke null");

                        // Vi returnerer vores C# objekt
                        return k;
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





        public int Login(string brugernavn, string kodeord)
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

                string query = "SELECT CustomerID FROM Kunde WHERE Username = @brugernavn " +
                    "AND Password = SHA2(@kodeord, 224) AND IsAdmin= 0;";


                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@brugernavn", brugernavn);
                cmd.Parameters.AddWithValue("@kodeord", kodeord);

                object Result = cmd.ExecuteScalar();
                if (Result != null)
                {
                    Customer.CustomerID = Convert.ToInt32(Result);
                    Customer.IsAdmin = false;

                }

                return Customer.CustomerID;
            }
            catch(Exception ex)
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

        public void SletKunde(int CustomerID)
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

                string query = "DELETE FROM Courts WHERE CustomerID = @customerID;";
                string query2 = "DELETE FROM Kunde WHERE CustomerID = @customerID;";

                cmd = new MySqlCommand(query, conn);
                cmd2 = new MySqlCommand(query2, conn);

                cmd.Parameters.AddWithValue("@customerID", CustomerID);
                cmd2.Parameters.AddWithValue("@customerID", CustomerID);

                cmd.ExecuteNonQuery();

                int rowsAffected = cmd2.ExecuteNonQuery();

                if (rowsAffected != 0)
                {
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Du har lige slettet Kunden med kundeID'et: " + CustomerID);
                }
                else if (rowsAffected == 0)
                {
                    MessageBox.Show("KundeID'et findes ikke i databasen");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
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
