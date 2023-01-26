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
    public partial class RentBook : Form {
        private string id = "";
        private string cs = "";
        public RentBook(string _id, string _cs) {
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
                string sql = $"SELECT id,cim FROM konyvek WHERE kolcsonzo IS NULL";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1)});
                }
                resultCountLBL.Text = $"{bookGrid.Rows.Count} szabad könyv";
            }
            catch(Exception e) {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!\r\n\r\n"+e, "Hiba!");
            }
        }
        private void CloseBTN_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void RentBookBTN_Click(object sender, EventArgs e) {
            if(bookGrid.SelectedRows.Count > 0) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "UPDATE konyvek SET lejarat=@lejarat, kolcsonzo=@uid WHERE id=@id";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@lejarat", DateTime.Now.AddMonths(1).ToString("yyyy.MM.dd."));
                    cmd.Parameters.AddWithValue("@uid", id);
                    cmd.Parameters.AddWithValue("@id", bookGrid.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A kölcsönzés megtörtént!", "Siker!");
                }
                catch(Exception err) {
                    MessageBox.Show("A kölcsönzés sikertelen!\r\n\r\n"+err, "Hiba!");
                }
            }
            GetBookList();
        }
    }
}
