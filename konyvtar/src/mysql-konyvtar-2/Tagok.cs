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
    public partial class Tagok : UserControl {
        public string cs = "";
        public string lastQuery = "";
        public Tagok() {
            InitializeComponent();
        }
        private string GenWhere() {
            string _st = searchtermTBX.Text;
            bool[] _checks = new bool[5]{idCHECK.Checked ,nameCHECK.Checked ,addressCHECK.Checked ,phoneCHECK.Checked , emailCHECK.Checked};
            string[] _likes = new string[5]{$" tagok.id LIKE '%{_st}%' ",$" tagok.nev LIKE '%{_st}%' ",$" tagok.lakcim LIKE '%{_st}%' ",$" tagok.telefon LIKE '%{_st}%' ",$" tagok.email LIKE '%{_st}%' "};
            List<string> _result = new List<string>();
            for (int _i = 0; _i < _checks.Length; _i++) {
                if (_checks[_i]) {
                    _result.Add(_likes[_i]);
                }
            }
            return _result.Count < 1 ? "" : "WHERE"+string.Join("OR",_result);
        }
        public void RunLastQuery() {
            switch(lastQuery) {
                case "all": SelectAll(); break;
                case "kolcsonzok": SelectKolcsonzok(); break;
                case "nemkolcsonzok": SelectNemKolcsonzok(); break;
                default: SelectAll(); break;
            }
            resultCountLBL.Text = $"{dataGridView1.Rows.Count} találat";
        }


        // -------------- //
        // DATABASE LOGIC //
        // -------------- //
        public void SelectAll() {
            lastQuery = "all";
            dataGridView1.Rows.Clear();
            try {
                // https://zetcode.com/csharp/mysql/
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = $"SELECT * FROM tagok {GenWhere()}";
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    dataGridView1.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4) });
                }
            }
            catch {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!","Hiba!");
            }
            resultCountLBL.Text = $"{dataGridView1.Rows.Count} találat";
        }
        public void SelectKolcsonzok() {
            lastQuery = "kolcsonzok";
            dataGridView1.Rows.Clear();
            try {
                // https://zetcode.com/csharp/mysql/
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = "SELECT DISTINCT(tagok.id), tagok.nev, tagok.lakcim, tagok.telefon,tagok.email FROM tagok INNER JOIN konyvek ON tagok.id = konyvek.kolcsonzo "+GenWhere();
                using MySqlCommand cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    dataGridView1.Rows.Add(new object[] { rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4) });
                }
            }
            catch {
                MessageBox.Show("Hiba az adatok lekérése közben! Ellenőrizze felhasználónevét és jelszavát, vagy próbálja újra később!", "Hiba!");
            }
            resultCountLBL.Text = $"{dataGridView1.Rows.Count} találat";
        }
        public void SelectNemKolcsonzok() {
            lastQuery = "nemkolcsonzok";
            SelectAll(); // TEMP SOLUTION
        }
        private long GetMaxId() {
            long id = -1;
            try {
                using var con = new MySqlConnection(cs);
                con.Open();
                string sql = "SELECT MAX(id) FROM tagok";
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

        private void addMemberBTN_Click(object sender, EventArgs e) {
            long id = GetMaxId()+1;
            if(id>0 && id<=99999999 && addressTBX.TextLength>0 && addressTBX.TextLength<=255 && emailTBX.TextLength>0 && emailTBX.TextLength<=255 && nameTBX.TextLength>0 && nameTBX.TextLength<=255) {
                try {
                    using var con = new MySqlConnection(cs);
                    con.Open();
                    var sql = "INSERT INTO tagok(id,nev,lakcim,telefon,email) VALUES(@id, @nev, @lakcim, @telefon, @email)";
                    using var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nev", nameTBX.Text);
                    cmd.Parameters.AddWithValue("@lakcim", addressTBX.Text);
                    cmd.Parameters.AddWithValue("@telefon", phoneNUM.Value);
                    cmd.Parameters.AddWithValue("@email", emailTBX.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Felhasználó sikeresen hozzáadva!", "Siker!");
                }
                catch {
                    MessageBox.Show("A felhasználó hozzáadása sikertelen! Ellenőrizze az adatokat!","Hiba!");
                }
            }
            RunLastQuery();
        }
        private void EditKolcsonzesBTN_Click(object sender, EventArgs e) { // már nem edit, csak lekérés xd
            if (dataGridView1.SelectedRows.Count > 0) {
                ListBooks lb = new ListBooks(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), cs);
                lb.ShowDialog();
            }
        }

        private void phoneNUM_ValueChanged(object sender, EventArgs e) {
        }

        private void phoneNUM_KeyPress(object sender, KeyPressEventArgs e) {
        }

        private void EditDataBTN_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                long _id = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);
                string _nev = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string _lakcim = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                long _telefon = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[3].Value);
                string _email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string _cs = cs;
                EditMember m_editor = new EditMember(_id,_nev,_lakcim,_telefon,_email,_cs);
                m_editor.ShowDialog();
                RunLastQuery();
                //MessageBox.Show($"{_id}, {_nev}, {_lakcim}, {_telefon}, {_email}, {_cs}");
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e) {
            long id = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);
            string nev = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            try {
                if (dataGridView1.SelectedRows.Count > 0) {
                    DialogResult dr = MessageBox.Show($"Biztosan törli ID:{id} {nev} tagot?", "Megerősítés", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) {
                        using var con = new MySqlConnection(cs);
                        con.Open();
                        var sql = "DELETE FROM tagok WHERE id=@id";   // HIBÁS, ELŐTTE MINDEN KÖNYVET TÖRÖLNI KELL RÓLA
                        using var cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        RunLastQuery();
                        MessageBox.Show($" ID:{id} {nev} sikeresen törölve.", "Siker!");
                    }
                }
            }
            catch(Exception err) {
                MessageBox.Show($"Hiba a törlés közben!\r\n\r\n{err}","Hiba!");
            }
        }
    }
}
