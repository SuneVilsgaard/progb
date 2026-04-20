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
    public partial class SeBanerAdmin : Form
    {
        public SeBanerAdmin()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string connectionString = "server=localhost;database=Sportsbooking;uid=root;pwd=Hest123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Courts";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void SeBanerAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_tilbage_Click(object sender, EventArgs e)
        {
            HovedmenuAdmin hma = new HovedmenuAdmin();

            hma.Show();
            this.Hide();
        }
    }
}
