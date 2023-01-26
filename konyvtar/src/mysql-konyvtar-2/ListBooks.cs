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
    public partial class ListBooks : Form {
        private string id = "";
        private string cs = "";
        public ListBooks(string _id, string _cs) {
            InitializeComponent();
            id = _id;
            cs = _cs;
            GetBookList();
        }
        private void GetBookList() {
            bookGrid.Rows.Clear();
            try {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = $"SELECT konyvek.id, konyvek.cim, konyvek.kolcsonzo, konyvek.lejarat FROM konyvek INNER JOIN tagok ON konyvek.kolcsonzo = tagok.id WHERE tagok.id='{id}'";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3) });
                }
                label1.Text = $"{bookGrid.Rows.Count} találat";
            }
            catch(Exception e) {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!\r\n\r\n"+e, "Hiba!");
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ReturnedBTN_Click(object sender, EventArgs e) {
            if(bookGrid.SelectedRows.Count > 0) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "UPDATE konyvek SET kolcsonzo=NULL,lejarat=NULL WHERE id=@id";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", bookGrid.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A könyv állapota sikeresen frissítve lett!", "Siker!");
                }
                catch(Exception err) {
                    MessageBox.Show("A könyv állapotát nem sikerült frissíteni!\r\n\r\n"+err, "Hiba!");
                }
            }
            GetBookList();
        }

        private void ExtendDateBTN_Click(object sender, EventArgs e) {
            if(bookGrid.SelectedRows.Count > 0) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "UPDATE konyvek SET lejarat=@lejarat WHERE id=@id";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@lejarat", DateTime.Now.AddMonths(1).ToString("yyyy.MM.dd."));
                    cmd.Parameters.AddWithValue("@id", bookGrid.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A határidő sikeresen meg lett hosszabbítva!", "Siker!");
                }
                catch(Exception err) {
                    MessageBox.Show("A határidő meghosszabbítása sikertelen!\r\n\r\n"+err, "Hiba!");
                }
            }
            GetBookList();
        }

        private void RentNewBookBTN_Click(object sender, EventArgs e) {
            RentBook rb = new RentBook(id, cs);
            rb.ShowDialog();
            GetBookList();
        }
    }
}
