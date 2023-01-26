
namespace mysql_konyvtar_2 {
    partial class ListBooks {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListBooksTitleLBL = new System.Windows.Forms.Label();
            this.ListBooksTitlePanel = new System.Windows.Forms.Panel();
            this.ButtonContainerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RentNewBookBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExtendDateBTN = new System.Windows.Forms.Button();
            this.ReturnedBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolcsonzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lejarat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListBooksTitlePanel.SuspendLayout();
            this.ButtonContainerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBooksTitleLBL
            // 
            this.ListBooksTitleLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBooksTitleLBL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBooksTitleLBL.Location = new System.Drawing.Point(5, 5);
            this.ListBooksTitleLBL.Name = "ListBooksTitleLBL";
            this.ListBooksTitleLBL.Size = new System.Drawing.Size(790, 39);
            this.ListBooksTitleLBL.TabIndex = 0;
            this.ListBooksTitleLBL.Text = "Könyvek";
            this.ListBooksTitleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBooksTitlePanel
            // 
            this.ListBooksTitlePanel.Controls.Add(this.ListBooksTitleLBL);
            this.ListBooksTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBooksTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.ListBooksTitlePanel.Name = "ListBooksTitlePanel";
            this.ListBooksTitlePanel.Padding = new System.Windows.Forms.Padding(5);
            this.ListBooksTitlePanel.Size = new System.Drawing.Size(800, 49);
            this.ListBooksTitlePanel.TabIndex = 6;
            // 
            // ButtonContainerPanel
            // 
            this.ButtonContainerPanel.Controls.Add(this.label1);
            this.ButtonContainerPanel.Controls.Add(this.CloseBTN);
            this.ButtonContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainerPanel.Location = new System.Drawing.Point(0, 401);
            this.ButtonContainerPanel.Name = "ButtonContainerPanel";
            this.ButtonContainerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonContainerPanel.Size = new System.Drawing.Size(800, 49);
            this.ButtonContainerPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "0 találat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseBTN.Location = new System.Drawing.Point(674, 5);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(121, 39);
            this.CloseBTN.TabIndex = 8;
            this.CloseBTN.Text = "Bezárás";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RentNewBookBTN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ExtendDateBTN);
            this.panel1.Controls.Add(this.ReturnedBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(674, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 352);
            this.panel1.TabIndex = 11;
            // 
            // RentNewBookBTN
            // 
            this.RentNewBookBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RentNewBookBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentNewBookBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentNewBookBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentNewBookBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.RentNewBookBTN.Location = new System.Drawing.Point(0, 123);
            this.RentNewBookBTN.Name = "RentNewBookBTN";
            this.RentNewBookBTN.Size = new System.Drawing.Size(126, 37);
            this.RentNewBookBTN.TabIndex = 13;
            this.RentNewBookBTN.Text = "Új kölcsönzés";
            this.RentNewBookBTN.UseVisualStyleBackColor = true;
            this.RentNewBookBTN.Click += new System.EventHandler(this.RentNewBookBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 10);
            this.panel2.TabIndex = 12;
            // 
            // ExtendDateBTN
            // 
            this.ExtendDateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtendDateBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExtendDateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtendDateBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtendDateBTN.Location = new System.Drawing.Point(0, 76);
            this.ExtendDateBTN.Name = "ExtendDateBTN";
            this.ExtendDateBTN.Size = new System.Drawing.Size(126, 37);
            this.ExtendDateBTN.TabIndex = 11;
            this.ExtendDateBTN.Text = "Meghosszabbítás";
            this.ExtendDateBTN.UseVisualStyleBackColor = true;
            this.ExtendDateBTN.Click += new System.EventHandler(this.ExtendDateBTN_Click);
            // 
            // ReturnedBTN
            // 
            this.ReturnedBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnedBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReturnedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnedBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnedBTN.Location = new System.Drawing.Point(0, 39);
            this.ReturnedBTN.Name = "ReturnedBTN";
            this.ReturnedBTN.Size = new System.Drawing.Size(126, 37);
            this.ReturnedBTN.TabIndex = 10;
            this.ReturnedBTN.Text = "Visszahozta";
            this.ReturnedBTN.UseVisualStyleBackColor = true;
            this.ReturnedBTN.Click += new System.EventHandler(this.ReturnedBTN_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szerkesztés";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToAddRows = false;
            this.bookGrid.AllowUserToDeleteRows = false;
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cim,
            this.Kolcsonzo,
            this.Lejarat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGrid.Location = new System.Drawing.Point(0, 49);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowTemplate.Height = 25;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.ShowCellErrors = false;
            this.bookGrid.ShowCellToolTips = false;
            this.bookGrid.ShowEditingIcon = false;
            this.bookGrid.ShowRowErrors = false;
            this.bookGrid.Size = new System.Drawing.Size(674, 352);
            this.bookGrid.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Cim
            // 
            this.Cim.HeaderText = "Cím";
            this.Cim.MaxInputLength = 255;
            this.Cim.Name = "Cim";
            this.Cim.ReadOnly = true;
            // 
            // Kolcsonzo
            // 
            this.Kolcsonzo.HeaderText = "Kölcsönző";
            this.Kolcsonzo.MaxInputLength = 255;
            this.Kolcsonzo.Name = "Kolcsonzo";
            this.Kolcsonzo.ReadOnly = true;
            // 
            // Lejarat
            // 
            this.Lejarat.HeaderText = "Lejárat";
            this.Lejarat.MaxInputLength = 11;
            this.Lejarat.Name = "Lejarat";
            this.Lejarat.ReadOnly = true;
            // 
            // ListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonContainerPanel);
            this.Controls.Add(this.ListBooksTitlePanel);
            this.Name = "ListBooks";
            this.ShowIcon = false;
            this.Text = "Könyvek";
            this.ListBooksTitlePanel.ResumeLayout(false);
            this.ButtonContainerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListBooksTitleLBL;
        private System.Windows.Forms.Panel ListBooksTitlePanel;
        private System.Windows.Forms.Panel ButtonContainerPanel;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExtendDateBTN;
        private System.Windows.Forms.Button ReturnedBTN;
        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolcsonzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lejarat;
        private System.Windows.Forms.Button RentNewBookBTN;
        private System.Windows.Forms.Panel panel2;
    }
}