using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql_konyvtar_2 {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }
        
        private void CloseBTN_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void LoginBtn_Click(object sender, EventArgs e) {
            if(usernameTBX.Text.Length>0) {
                testConnect(genCS("localhost", usernameTBX.Text, passwordTBX.Text, "konyvtar"));
            }
        }
        private static string genCS(string server, string user, string pw, string db) {
            return $@"server={server};userid={user};password={pw};database={db}";
        }
        private void testConnect(string _cs) {
            string ver = "";
            try {
                using var con = new MySqlConnection(_cs);
                con.Open();
                ver = con.ServerVersion;
            }
            catch {
                MessageBox.Show("Az adatbázishoz való kapcsolódás sikertelen, ellenőrizze felhasználónevét és jelszavát!","Hiba!");
            }
            if (ver.Length > 0) {
                MainForm m = new MainForm(_cs);
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
        }
    }
}
