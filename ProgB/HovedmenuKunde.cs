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
    public partial class HovedmenuKunde : Form
    {
        public HovedmenuKunde()
        {
            InitializeComponent();
        }

        private void btn_bookBane_Click(object sender, EventArgs e)
        {
            Bookingside bs = new Bookingside();

            bs.Show();
            this.Hide();
        }
    }
}
