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
    public partial class EditBook : Form {
        public string cs;
        public string id;
        public EditBook(string _id, string _cim, string _cs) {
            InitializeComponent();
            cimTBX.Text = _cim;
            id = _id;
            cs = _cs;
        }
        private void CancelBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e) {
            if (cimTBX.TextLength>0 && cimTBX.TextLength<=255) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "UPDATE konyvek SET cim=@cim WHERE id=@id";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cim", cimTBX.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A könyv adatai sikeresen módosításra kerültek!", "Siker!");
                    this.Close();
                }
                catch {
                    MessageBox.Show("A könyv adatainak módosítása sikertelen! Ellenőrizze az adatokat!", "Hiba!");
                }
            }
        }
    }
}
