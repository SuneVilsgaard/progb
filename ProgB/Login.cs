using Eksamensprjekt_forsøg2;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Admin a = new Admin();

            string brugernavn = textBox1.Text;
            string kodeord = textBox2.Text;

            int resultKunde = k.Login(brugernavn, kodeord);

            int resultAdmin = a.LoginAdmin(brugernavn, kodeord);

            if (resultKunde != 0)
            {
                MessageBox.Show("Login lykkedes");
                HovedmenuKunde hm = new HovedmenuKunde();

                hm.Show();
                this.Hide();
            }
            else if (resultAdmin != 0)
            {
                MessageBox.Show("Tillyke: Login admin lykkedes");
                HovedmenuAdmin hma = new HovedmenuAdmin();

                hma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login mislykkedes");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btn_loginSomAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
