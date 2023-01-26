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
    public partial class MainForm : Form {
        private string cs;
        public MainForm(string _cs) {
            cs = _cs;
            InitializeComponent();
            InitUCs(_cs);
            tagok2.Show();
        }
        private void InitUCs(string _cs) {
            HideAll();
            tagok2.Dock = DockStyle.Fill;
            tagok2.cs = _cs;
            tagok2.SelectAll();
            bookuc1.Dock = DockStyle.Fill;
            bookuc1.cs = _cs;
            bookuc1.SelectAll();
        }
        private void ChangeTab(string tab) {
            switch (tab.ToLower()) {
                case "tagok":
                    HideAll();
                    tagok2.RunLastQuery();
                    tagok2.Show();
                    break;
                case "konyvek":
                    HideAll();
                    bookuc1.RunLastQuery();
                    bookuc1.Show();
                    break;
                default:
                    HideAll();
                    break;
            }
        }
        private void HideAll() {
            tagok2.Hide();
            bookuc1.Hide();
        }
        private void TagokBTN_Click(object sender, EventArgs e) {
            ChangeTab("tagok");
        }
        private void KonyvekBTN_Click(object sender, EventArgs e) {
            ChangeTab("konyvek");
        }
        private void KijelentkezesBTN_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
