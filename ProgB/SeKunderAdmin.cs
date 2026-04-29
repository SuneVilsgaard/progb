using Eksamensprjekt_forsøg2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgB
{
    public partial class SeKunderAdmin : Form
    {
        public SeKunderAdmin()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string connectionString = "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Kunde";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void btn_tilbage_Click(object sender, EventArgs e)
        {
            HovedmenuAdmin hma = new HovedmenuAdmin();

            hma.Show();
            this.Hide();
        }

        private void SeKunderAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_SletKunde_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(txb_CustomerID.Text);

            if (customerID == Customer.CustomerID)
            {
                MessageBox.Show("Du kan ikke slette admin brugeren");
            }
            else
            {
                Kunde k = new Kunde();

                k.SletKunde(customerID);

                MessageBox.Show("Du har lige slettet en kunde med KundeID'et: " + customerID);

                LoadData();
            }
        }
    }
}
