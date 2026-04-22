using Eksamensprjekt_forsøg2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace ProgB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde();

            string f = TxtFornavn.Text;
            string h = TxtEfternavn.Text;
            int l;
            Int32.TryParse(""+TxtAlder.Text, out l);
            string g = TxtKodeord.Text;
            string b = TxtBrugernavn.Text;

            k.SignUp(f, h, l, b, g);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            Kunde k = new Kunde();

            string brugernavn = textBox1.Text;
            string kodeord = textBox2.Text;

            int result = k.Login(brugernavn, kodeord);


            if(result != 0)
            {
                HovedmenuKunde hm = new HovedmenuKunde();

                hm.Show();
                this.Hide();
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btn_loginSomAdmin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            string brugernavn = textBox1.Text;
            string kodeord = textBox2.Text;

            int result = a.LoginAdmin(brugernavn, kodeord);

            if (result != 0)
            {
                HovedmenuAdmin hma = new HovedmenuAdmin();

                hma.Show();
                this.Hide();
            }
        }
    }
}
