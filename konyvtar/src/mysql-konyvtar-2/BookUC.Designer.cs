
namespace mysql_konyvtar_2
{
    partial class BookUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.searchtermSpacerPanel = new System.Windows.Forms.Panel();
            this.titleCHECK = new System.Windows.Forms.CheckBox();
            this.idCHECK = new System.Windows.Forms.CheckBox();
            this.searchtermTBX = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SortNemKolcsonzottkBTN = new System.Windows.Forms.Button();
            this.SortKolcsonzottBTN = new System.Windows.Forms.Button();
            this.SortOsszesBTN = new System.Windows.Forms.Button();
            this.SzuresLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newMemberPanel = new System.Windows.Forms.Panel();
            this.newMemberSpacerPanel = new System.Windows.Forms.Panel();
            this.titleTBX = new System.Windows.Forms.TextBox();
            this.addMemberBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidebarConatinerPanel = new System.Windows.Forms.Panel();
            this.resultCountLBL = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EditDataBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPanel.SuspendLayout();
            this.searchtermSpacerPanel.SuspendLayout();
            this.newMemberPanel.SuspendLayout();
            this.newMemberSpacerPanel.SuspendLayout();
            this.sidebarConatinerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.searchtermSpacerPanel);
            this.controlPanel.Controls.Add(this.SearchBTN);
            this.controlPanel.Controls.Add(this.SortNemKolcsonzottkBTN);
            this.controlPanel.Controls.Add(this.SortKolcsonzottBTN);
            this.controlPanel.Controls.Add(this.SortOsszesBTN);
            this.controlPanel.Controls.Add(this.SzuresLabel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(10, 10);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.controlPanel.Size = new System.Drawing.Size(780, 56);
            this.controlPanel.TabIndex = 0;
            // 
            // searchtermSpacerPanel
            // 
            this.searchtermSpacerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtermSpacerPanel.Controls.Add(this.titleCHECK);
            this.searchtermSpacerPanel.Controls.Add(this.idCHECK);
            this.searchtermSpacerPanel.Controls.Add(this.searchtermTBX);
            this.searchtermSpacerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtermSpacerPanel.Location = new System.Drawing.Point(407, 5);
            this.searchtermSpacerPanel.Name = "searchtermSpacerPanel";
            this.searchtermSpacerPanel.Size = new System.Drawing.Size(304, 44);
            this.searchtermSpacerPanel.TabIndex = 6;
            // 
            // titleCHECK
            // 
            this.titleCHECK.AutoSize = true;
            this.titleCHECK.Checked = true;
            this.titleCHECK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.titleCHECK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleCHECK.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleCHECK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleCHECK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleCHECK.Location = new System.Drawing.Point(39, 23);
            this.titleCHECK.Name = "titleCHECK";
            this.titleCHECK.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.titleCHECK.Size = new System.Drawing.Size(50, 19);
            this.titleCHECK.TabIndex = 3;
            this.titleCHECK.Text = "Cím";
            this.titleCHECK.UseVisualStyleBackColor = true;
            // 
            // idCHECK
            // 
            this.idCHECK.AutoSize = true;
            this.idCHECK.Checked = true;
            this.idCHECK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idCHECK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idCHECK.Dock = System.Windows.Forms.DockStyle.Left;
            this.idCHECK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idCHECK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idCHECK.Location = new System.Drawing.Point(0, 23);
            this.idCHECK.Name = "idCHECK";
            this.idCHECK.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.idCHECK.Size = new System.Drawing.Size(39, 19);
            this.idCHECK.TabIndex = 2;
            this.idCHECK.Text = "ID";
            this.idCHECK.UseVisualStyleBackColor = true;
            // 
            // searchtermTBX
            // 
            this.searchtermTBX.BackColor = System.Drawing.SystemColors.Control;
            this.searchtermTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtermTBX.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchtermTBX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtermTBX.Location = new System.Drawing.Point(0, 0);
            this.searchtermTBX.Name = "searchtermTBX";
            this.searchtermTBX.PlaceholderText = "Keresési szöveg";
            this.searchtermTBX.Size = new System.Drawing.Size(302, 23);
            this.searchtermTBX.TabIndex = 1;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.SearchBTN.Location = new System.Drawing.Point(711, 5);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(62, 44);
            this.SearchBTN.TabIndex = 5;
            this.SearchBTN.Text = "Keres";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SortNemKolcsonzottkBTN
            // 
            this.SortNemKolcsonzottkBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortNemKolcsonzottkBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortNemKolcsonzottkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortNemKolcsonzottkBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortNemKolcsonzottkBTN.Location = new System.Drawing.Point(272, 5);
            this.SortNemKolcsonzottkBTN.Name = "SortNemKolcsonzottkBTN";
            this.SortNemKolcsonzottkBTN.Size = new System.Drawing.Size(135, 44);
            this.SortNemKolcsonzottkBTN.TabIndex = 3;
            this.SortNemKolcsonzottkBTN.Text = "Nem kölcsönzött";
            this.SortNemKolcsonzottkBTN.UseVisualStyleBackColor = true;
            this.SortNemKolcsonzottkBTN.Click += new System.EventHandler(this.SortNemKolcsonzokBTN_Click);
            // 
            // SortKolcsonzottBTN
            // 
            this.SortKolcsonzottBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortKolcsonzottBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortKolcsonzottBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortKolcsonzottBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortKolcsonzottBTN.Location = new System.Drawing.Point(173, 5);
            this.SortKolcsonzottBTN.Name = "SortKolcsonzottBTN";
            this.SortKolcsonzottBTN.Size = new System.Drawing.Size(99, 44);
            this.SortKolcsonzottBTN.TabIndex = 2;
            this.SortKolcsonzottBTN.Text = "Kölcsönzött";
            this.SortKolcsonzottBTN.UseVisualStyleBackColor = true;
            this.SortKolcsonzottBTN.Click += new System.EventHandler(this.SortKolcsonzokBTN_Click);
            // 
            // SortOsszesBTN
            // 
            this.SortOsszesBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortOsszesBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortOsszesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortOsszesBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortOsszesBTN.Location = new System.Drawing.Point(80, 5);
            this.SortOsszesBTN.Name = "SortOsszesBTN";
            this.SortOsszesBTN.Size = new System.Drawing.Size(93, 44);
            this.SortOsszesBTN.TabIndex = 1;
            this.SortOsszesBTN.Text = "Összes";
            this.SortOsszesBTN.UseVisualStyleBackColor = true;
            this.SortOsszesBTN.Click += new System.EventHandler(this.SortOsszesBTN_Click);
            // 
            // SzuresLabel
            // 
            this.SzuresLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SzuresLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SzuresLabel.Location = new System.Drawing.Point(5, 5);
            this.SzuresLabel.Name = "SzuresLabel";
            this.SzuresLabel.Size = new System.Drawing.Size(75, 44);
            this.SzuresLabel.TabIndex = 0;
            this.SzuresLabel.Text = "Szűrés";
            this.SzuresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 10);
            this.panel1.TabIndex = 1;
            // 
            // newMemberPanel
            // 
            this.newMemberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberPanel.Controls.Add(this.newMemberSpacerPanel);
            this.newMemberPanel.Controls.Add(this.addMemberBTN);
            this.newMemberPanel.Controls.Add(this.label1);
            this.newMemberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newMemberPanel.Location = new System.Drawing.Point(10, 76);
            this.newMemberPanel.Name = "newMemberPanel";
            this.newMemberPanel.Padding = new System.Windows.Forms.Padding(5);
            this.newMemberPanel.Size = new System.Drawing.Size(780, 49);
            this.newMemberPanel.TabIndex = 2;
            // 
            // newMemberSpacerPanel
            // 
            this.newMemberSpacerPanel.Controls.Add(this.titleTBX);
            this.newMemberSpacerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMemberSpacerPanel.Location = new System.Drawing.Point(173, 5);
            this.newMemberSpacerPanel.Name = "newMemberSpacerPanel";
            this.newMemberSpacerPanel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.newMemberSpacerPanel.Size = new System.Drawing.Size(562, 37);
            this.newMemberSpacerPanel.TabIndex = 5;
            // 
            // titleTBX
            // 
            this.titleTBX.BackColor = System.Drawing.SystemColors.Control;
            this.titleTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTBX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTBX.Location = new System.Drawing.Point(0, 6);
            this.titleTBX.Name = "titleTBX";
            this.titleTBX.PlaceholderText = "Cím";
            this.titleTBX.Size = new System.Drawing.Size(562, 25);
            this.titleTBX.TabIndex = 0;
            // 
            // addMemberBTN
            // 
            this.addMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.addMemberBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMemberBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.addMemberBTN.Location = new System.Drawing.Point(735, 5);
            this.addMemberBTN.Name = "addMemberBTN";
            this.addMemberBTN.Size = new System.Drawing.Size(38, 37);
            this.addMemberBTN.TabIndex = 4;
            this.addMemberBTN.Text = "+";
            this.addMemberBTN.UseVisualStyleBackColor = true;
            this.addMemberBTN.Click += new System.EventHandler(this.addMemberBTN_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új könyv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 10);
            this.panel4.TabIndex = 3;
            // 
            // sidebarConatinerPanel
            // 
            this.sidebarConatinerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarConatinerPanel.Controls.Add(this.resultCountLBL);
            this.sidebarConatinerPanel.Controls.Add(this.DeleteBTN);
            this.sidebarConatinerPanel.Controls.Add(this.EditDataBTN);
            this.sidebarConatinerPanel.Controls.Add(this.label2);
            this.sidebarConatinerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebarConatinerPanel.Location = new System.Drawing.Point(643, 135);
            this.sidebarConatinerPanel.Name = "sidebarConatinerPanel";
            this.sidebarConatinerPanel.Size = new System.Drawing.Size(147, 512);
            this.sidebarConatinerPanel.TabIndex = 4;
            // 
            // resultCountLBL
            // 
            this.resultCountLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultCountLBL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultCountLBL.Location = new System.Drawing.Point(0, 476);
            this.resultCountLBL.Name = "resultCountLBL";
            this.resultCountLBL.Size = new System.Drawing.Size(145, 34);
            this.resultCountLBL.TabIndex = 12;
            this.resultCountLBL.Text = "0 találat";
            this.resultCountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBTN.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteBTN.Location = new System.Drawing.Point(0, 107);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(145, 37);
            this.DeleteBTN.TabIndex = 11;
            this.DeleteBTN.Text = "Törlés";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EditDataBTN
            // 
            this.EditDataBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditDataBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditDataBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDataBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditDataBTN.Location = new System.Drawing.Point(0, 70);
            this.EditDataBTN.Name = "EditDataBTN";
            this.EditDataBTN.Size = new System.Drawing.Size(145, 37);
            this.EditDataBTN.TabIndex = 8;
            this.EditDataBTN.Text = "Adatmódosítás";
            this.EditDataBTN.UseVisualStyleBackColor = true;
            this.EditDataBTN.Click += new System.EventHandler(this.EditDataBTN_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 70);
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
            this.Title});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGrid.Location = new System.Drawing.Point(10, 135);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowTemplate.Height = 25;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.ShowCellErrors = false;
            this.bookGrid.ShowCellToolTips = false;
            this.bookGrid.ShowEditingIcon = false;
            this.bookGrid.ShowRowErrors = false;
            this.bookGrid.Size = new System.Drawing.Size(633, 512);
            this.bookGrid.TabIndex = 5;
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
            // Title
            // 
            this.Title.HeaderText = "Cím";
            this.Title.MaxInputLength = 255;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // BookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.sidebarConatinerPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.newMemberPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.Name = "BookUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 657);
            this.controlPanel.ResumeLayout(false);
            this.searchtermSpacerPanel.ResumeLayout(false);
            this.searchtermSpacerPanel.PerformLayout();
            this.newMemberPanel.ResumeLayout(false);
            this.newMemberSpacerPanel.ResumeLayout(false);
            this.newMemberSpacerPanel.PerformLayout();
            this.sidebarConatinerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button SortNemKolcsonzottkBTN;
        private System.Windows.Forms.Button SortKolcsonzottBTN;
        private System.Windows.Forms.Button SortOsszesBTN;
        private System.Windows.Forms.Label SzuresLabel;
        private System.Windows.Forms.Panel searchtermSpacerPanel;
        private System.Windows.Forms.TextBox searchtermTBX;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel newMemberPanel;
        private System.Windows.Forms.Panel newMemberSpacerPanel;
        private System.Windows.Forms.TextBox titleTBX;
        private System.Windows.Forms.Button addMemberBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel sidebarConatinerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.CheckBox titleCHECK;
        private System.Windows.Forms.CheckBox idCHECK;
        private System.Windows.Forms.Button EditDataBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label resultCountLBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}
