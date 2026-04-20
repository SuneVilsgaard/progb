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
    public partial class HovedmenuAdmin : Form
    {
        public HovedmenuAdmin()
        {
            InitializeComponent();
        }

        private void HovedmenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_SeBaner_Click(object sender, EventArgs e)
        {
            SeBanerAdmin sba = new SeBanerAdmin();

            sba.Show();
            this.Hide();
        }

        private void btn_SeKunder_Click(object sender, EventArgs e)
        {
            SeKunderAdmin ska = new SeKunderAdmin();

            ska.Show();
            this.Hide();
        }
    }
}
