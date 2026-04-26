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
    public partial class SeBookinger : Form
    {
        public SeBookinger()
        {
            InitializeComponent();
        }

        private void btn_Tilbage1_Click(object sender, EventArgs e)
        {
            HovedmenuKunde hmk = new HovedmenuKunde();

            hmk.Show();
            this.Hide();
        }

        public void LoadData()
        {
            string connectionString = "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";

            MySqlDataReader reader = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TypeOffCourt, Date, Time FROM Courts WHERE CustomerID = @customerID";
                
                MySqlCommand cmd = null;


                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@customerID", value: Customer.CustomerID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void SeBookinger_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
