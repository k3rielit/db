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
    public partial class BookUC : UserControl {
        public string cs;
        private string lastQuery;
        public BookUC() {
            InitializeComponent();
        }

        private string GenWhere(string _pre) {
            string _st = searchtermTBX.Text;
            bool[] _checks = new bool[2] { idCHECK.Checked, titleCHECK.Checked};
            string[] _likes = new string[2] { $" konyvek.id LIKE '%{_st}%' ", $" konyvek.cim LIKE '%{_st}%' " };
            List<string> _result = new List<string>();
            for (int _i = 0; _i < _checks.Length; _i++) {
                if (_checks[_i]) {
                    _result.Add(_likes[_i]);
                }
            }
            return _result.Count < 1 ? "" : _pre+" "+string.Join("OR", _result);
        }
        public void RunLastQuery() {
            switch (lastQuery) {
                case "all": SelectAll(); break;
                case "kolcsonzok": SelectKolcsonzok(); break;
                case "nemkolcsonzok": SelectNemKolcsonzok(); break;
                default: SelectAll(); break;
            }
            resultCountLBL.Text = $"{bookGrid.Rows.Count} találat";
        }


        // -------------- //
        // DATABASE LOGIC //
        // -------------- //
        public void SelectAll() {
            lastQuery = "all";
            bookGrid.Rows.Clear();
            try {
                // https://zetcode.com/csharp/mysql/
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = $"SELECT * FROM konyvek {GenWhere("WHERE")}";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1) });
                    //bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3) });
                }
            }
            catch(Exception err) {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!\r\n\r\n"+err, "Hiba!");
            }
            resultCountLBL.Text = $"{bookGrid.Rows.Count} találat";
        }
        public void SelectKolcsonzok() {
            lastQuery = "kolcsonzok";
            bookGrid.Rows.Clear();
            try {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = "SELECT * FROM konyvek WHERE kolcsonzo IS NOT NULL AND (" + GenWhere("") + ")";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1) });
                }
            }
            catch
            {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!", "Hiba!");
            }
            resultCountLBL.Text = $"{bookGrid.Rows.Count} találat";
        }
        public void SelectNemKolcsonzok() {
            lastQuery = "nemkolcsonzok";bookGrid.Rows.Clear();
            try {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = "SELECT * FROM konyvek WHERE kolcsonzo IS NULL AND (" + GenWhere("")+")";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    bookGrid.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1) });
                }
            }
            catch
            {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!", "Hiba!");
            }
            resultCountLBL.Text = $"{bookGrid.Rows.Count} találat";
        }
        private long GetMaxId() {
            long id = -1;
            try {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = "SELECT MAX(id) FROM konyvek";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    id = rdr.GetInt64(0);
                }
            }
            catch {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!", "Hiba!");
            }
            return id;
        }


        // ----------- //
        // FORM EVENTS //
        // ----------- //
        private void SortOsszesBTN_Click(object sender, EventArgs e) => SelectAll();
        private void SortKolcsonzokBTN_Click(object sender, EventArgs e) => SelectKolcsonzok();
        private void SortNemKolcsonzokBTN_Click(object sender, EventArgs e) => SelectNemKolcsonzok();
        private void SearchBTN_Click(object sender, EventArgs e) => RunLastQuery();

        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            long id = GetMaxId() + 1;
            if (id > 0 && id <= 99999999 && titleTBX.TextLength > 0 && titleTBX.TextLength <= 255) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "INSERT INTO konyvek(id,cim,kolcsonzo,lejarat) VALUES(@id, @cim, NULL, NULL)";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@cim", titleTBX.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Könyv sikeresen hozzáadva!", "Siker!");
                }
                catch {
                    MessageBox.Show("Könyv hozzáadása sikertelen! Ellenőrizze az adatokat!", "Hiba!");
                }
            }
            RunLastQuery();
        }

        private void EditDataBTN_Click(object sender, EventArgs e) {
            if (bookGrid.SelectedRows.Count > 0) {
                EditBook eb = new EditBook(bookGrid.SelectedRows[0].Cells[0].Value.ToString(), bookGrid.SelectedRows[0].Cells[1].Value.ToString(), cs);
                eb.ShowDialog();
            }
            RunLastQuery();
        }

        private void DeleteBTN_Click(object sender, EventArgs e) {
            long id = Convert.ToInt64(bookGrid.SelectedRows[0].Cells[0].Value);
            string cim = bookGrid.SelectedRows[0].Cells[1].Value.ToString();
            try {
                if (bookGrid.SelectedRows.Count > 0) {
                    DialogResult dr = MessageBox.Show($"Biztosan törli ID:{id} {cim} könyvet?", "Megerősítés", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) {
                        using var con = new MySqlConnection(cs);
                        con.Open();
                        var sql = "DELETE FROM konyvek WHERE id=@id";
                        using var cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", bookGrid.SelectedRows[0].Cells[0].Value);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        RunLastQuery();
                        MessageBox.Show($" ID:{id} {cim} sikeresen törölve.", "Siker!");
                    }
                }
            }
            catch (Exception err) {
                MessageBox.Show($"Hiba a törlés közben!\r\n\r\n{err}", "Hiba!");
            }
        }
    }
}
