using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgB
{
    public partial class Bookingside : Form
    {
        public Bookingside()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_vælg_Click(object sender, EventArgs e)
        {
            string TypeSport = comboBox1.Text;
            DateTime Dato = dtp_booking.Value;
            string Tidspunkt = cmb_Tidspunkt.Text;

            Booking bk = new Booking();

            bk.OpretBooking(TypeSport, Dato, Tidspunkt);
        }
    }
}
