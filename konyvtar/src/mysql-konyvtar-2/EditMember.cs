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
    public partial class EditMember : Form {
        public string cs;
        public long id;
        public EditMember(long _id, string _nev, string _lakcim, long _telefon, string _email, string _cs) {
            InitializeComponent();
            nameTBX.Text = _nev;
            addressTBX.Text = _lakcim;
            phoneNUM.Value = _telefon;
            emailTBX.Text = _email;
            id = _id;
            cs = _cs;
        }

        private void phoneNUM_KeyPress(object sender, KeyPressEventArgs e) {
        }

        private void phoneNUM_ValueChanged(object sender, EventArgs e) {
        }

        private void CancelBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e) {
            if (addressTBX.TextLength>0 && addressTBX.TextLength<=255 && emailTBX.TextLength>0 && emailTBX.TextLength<=255 && nameTBX.TextLength>0 && nameTBX.TextLength<=255) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "UPDATE tagok SET nev=@nev,lakcim=@lakcim,telefon=@telefon,email=@email WHERE id=@id";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nev", nameTBX.Text);
                    cmd.Parameters.AddWithValue("@lakcim", addressTBX.Text);
                    cmd.Parameters.AddWithValue("@telefon", phoneNUM.Value);
                    cmd.Parameters.AddWithValue("@email", emailTBX.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A felhasználó adatai sikeresen módosításra kerültek!", "Siker!");
                    this.Close();
                }
                catch {
                    MessageBox.Show("A felhasználó adatainak módosítása sikertelen! Ellenőrizze az adatokat!", "Hiba!");
                }
            }
        }
    }
}
