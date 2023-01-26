
namespace mysql_konyvtar_2 {
    partial class RentBook {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListBooksTitleLBL = new System.Windows.Forms.Label();
            this.ButtonContainerPanel = new System.Windows.Forms.Panel();
            this.resultCountLBL = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ListBooksTitlePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RentBookBTN = new System.Windows.Forms.Button();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonContainerPanel.SuspendLayout();
            this.ListBooksTitlePanel.SuspendLayout();
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
            // ButtonContainerPanel
            // 
            this.ButtonContainerPanel.Controls.Add(this.resultCountLBL);
            this.ButtonContainerPanel.Controls.Add(this.CloseBTN);
            this.ButtonContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainerPanel.Location = new System.Drawing.Point(0, 401);
            this.ButtonContainerPanel.Name = "ButtonContainerPanel";
            this.ButtonContainerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonContainerPanel.Size = new System.Drawing.Size(800, 49);
            this.ButtonContainerPanel.TabIndex = 14;
            // 
            // resultCountLBL
            // 
            this.resultCountLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.resultCountLBL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultCountLBL.Location = new System.Drawing.Point(5, 5);
            this.resultCountLBL.Name = "resultCountLBL";
            this.resultCountLBL.Size = new System.Drawing.Size(232, 39);
            this.resultCountLBL.TabIndex = 9;
            this.resultCountLBL.Text = "0 szabad könyv";
            this.resultCountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseBTN.Location = new System.Drawing.Point(690, 5);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(105, 39);
            this.CloseBTN.TabIndex = 8;
            this.CloseBTN.Text = "Bezárás";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // ListBooksTitlePanel
            // 
            this.ListBooksTitlePanel.Controls.Add(this.ListBooksTitleLBL);
            this.ListBooksTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBooksTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.ListBooksTitlePanel.Name = "ListBooksTitlePanel";
            this.ListBooksTitlePanel.Padding = new System.Windows.Forms.Padding(5);
            this.ListBooksTitlePanel.Size = new System.Drawing.Size(800, 49);
            this.ListBooksTitlePanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RentBookBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(690, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 352);
            this.panel1.TabIndex = 17;
            // 
            // RentBookBTN
            // 
            this.RentBookBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RentBookBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentBookBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentBookBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentBookBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.RentBookBTN.Location = new System.Drawing.Point(0, 0);
            this.RentBookBTN.Name = "RentBookBTN";
            this.RentBookBTN.Size = new System.Drawing.Size(110, 37);
            this.RentBookBTN.TabIndex = 10;
            this.RentBookBTN.Text = "Kölcsönzés";
            this.RentBookBTN.UseVisualStyleBackColor = true;
            this.RentBookBTN.Click += new System.EventHandler(this.RentBookBTN_Click);
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToAddRows = false;
            this.bookGrid.AllowUserToDeleteRows = false;
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cim});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.bookGrid.Size = new System.Drawing.Size(690, 352);
            this.bookGrid.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Cim
            // 
            this.Cim.HeaderText = "Cím";
            this.Cim.MaxInputLength = 255;
            this.Cim.Name = "Cim";
            this.Cim.ReadOnly = true;
            // 
            // RentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonContainerPanel);
            this.Controls.Add(this.ListBooksTitlePanel);
            this.Name = "RentBook";
            this.ShowIcon = false;
            this.Text = "Kölcsönzés";
            this.ButtonContainerPanel.ResumeLayout(false);
            this.ListBooksTitlePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListBooksTitleLBL;
        private System.Windows.Forms.Panel ButtonContainerPanel;
        private System.Windows.Forms.Label resultCountLBL;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Panel ListBooksTitlePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RentBookBTN;
        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
    }
}