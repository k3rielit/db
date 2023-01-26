
namespace mysql_konyvtar_2 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.KonyvekBTN = new System.Windows.Forms.Button();
            this.TagokBTN = new System.Windows.Forms.Button();
            this.KijelentkezesBTN = new System.Windows.Forms.Button();
            this.tagok2 = new mysql_konyvtar_2.Tagok();
            this.bookuc1 = new mysql_konyvtar_2.BookUC();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuPanel.Controls.Add(this.KonyvekBTN);
            this.menuPanel.Controls.Add(this.TagokBTN);
            this.menuPanel.Controls.Add(this.KijelentkezesBTN);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(799, 43);
            this.menuPanel.TabIndex = 1;
            // 
            // KonyvekBTN
            // 
            this.KonyvekBTN.BackColor = System.Drawing.Color.LightGray;
            this.KonyvekBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.KonyvekBTN.FlatAppearance.BorderSize = 0;
            this.KonyvekBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KonyvekBTN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KonyvekBTN.Location = new System.Drawing.Point(127, 0);
            this.KonyvekBTN.Name = "KonyvekBTN";
            this.KonyvekBTN.Size = new System.Drawing.Size(127, 43);
            this.KonyvekBTN.TabIndex = 2;
            this.KonyvekBTN.Text = "Könyvek";
            this.KonyvekBTN.UseVisualStyleBackColor = false;
            this.KonyvekBTN.Click += new System.EventHandler(this.KonyvekBTN_Click);
            // 
            // TagokBTN
            // 
            this.TagokBTN.BackColor = System.Drawing.Color.Silver;
            this.TagokBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.TagokBTN.FlatAppearance.BorderSize = 0;
            this.TagokBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TagokBTN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagokBTN.Location = new System.Drawing.Point(0, 0);
            this.TagokBTN.Name = "TagokBTN";
            this.TagokBTN.Size = new System.Drawing.Size(127, 43);
            this.TagokBTN.TabIndex = 1;
            this.TagokBTN.Text = "Tagok";
            this.TagokBTN.UseVisualStyleBackColor = false;
            this.TagokBTN.Click += new System.EventHandler(this.TagokBTN_Click);
            // 
            // KijelentkezesBTN
            // 
            this.KijelentkezesBTN.BackColor = System.Drawing.Color.LightGray;
            this.KijelentkezesBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.KijelentkezesBTN.FlatAppearance.BorderSize = 0;
            this.KijelentkezesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KijelentkezesBTN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KijelentkezesBTN.Location = new System.Drawing.Point(672, 0);
            this.KijelentkezesBTN.Name = "KijelentkezesBTN";
            this.KijelentkezesBTN.Size = new System.Drawing.Size(127, 43);
            this.KijelentkezesBTN.TabIndex = 0;
            this.KijelentkezesBTN.Text = "Kijelentkezés";
            this.KijelentkezesBTN.UseVisualStyleBackColor = false;
            this.KijelentkezesBTN.Click += new System.EventHandler(this.KijelentkezesBTN_Click);
            // 
            // tagok2
            // 
            this.tagok2.Location = new System.Drawing.Point(-345, 204);
            this.tagok2.Name = "tagok2";
            this.tagok2.Padding = new System.Windows.Forms.Padding(10);
            this.tagok2.Size = new System.Drawing.Size(800, 657);
            this.tagok2.TabIndex = 2;
            // 
            // bookuc1
            // 
            this.bookuc1.Location = new System.Drawing.Point(461, 119);
            this.bookuc1.Name = "bookuc1";
            this.bookuc1.Padding = new System.Windows.Forms.Padding(10);
            this.bookuc1.Size = new System.Drawing.Size(800, 657);
            this.bookuc1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 564);
            this.Controls.Add(this.bookuc1);
            this.Controls.Add(this.tagok2);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(815, 603);
            this.Name = "MainForm";
            this.Text = "BittoDuo Könyvtár";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button KonyvekBTN;
        private System.Windows.Forms.Button TagokBTN;
        private System.Windows.Forms.Button KijelentkezesBTN;
        private Tagok tagok2;
        private BookUC bookuc1;
    }
}