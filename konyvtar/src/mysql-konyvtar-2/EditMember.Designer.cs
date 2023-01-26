
namespace mysql_konyvtar_2
{
    partial class EditMember
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newMemberPanel = new System.Windows.Forms.Panel();
            this.EditMemberTitleLBL = new System.Windows.Forms.Label();
            this.dataGroupContainerPanel = new System.Windows.Forms.Panel();
            this.newMemberSpacerPanel = new System.Windows.Forms.Panel();
            this.emailTBX = new System.Windows.Forms.TextBox();
            this.phoneNUM = new System.Windows.Forms.NumericUpDown();
            this.addressTBX = new System.Windows.Forms.TextBox();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.ButtonContainerPanel = new System.Windows.Forms.Panel();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.But = new System.Windows.Forms.Panel();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.newMemberPanel.SuspendLayout();
            this.dataGroupContainerPanel.SuspendLayout();
            this.newMemberSpacerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNUM)).BeginInit();
            this.ButtonContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMemberPanel
            // 
            this.newMemberPanel.Controls.Add(this.EditMemberTitleLBL);
            this.newMemberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newMemberPanel.Location = new System.Drawing.Point(10, 10);
            this.newMemberPanel.Name = "newMemberPanel";
            this.newMemberPanel.Padding = new System.Windows.Forms.Padding(5);
            this.newMemberPanel.Size = new System.Drawing.Size(758, 49);
            this.newMemberPanel.TabIndex = 3;
            // 
            // EditMemberTitleLBL
            // 
            this.EditMemberTitleLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditMemberTitleLBL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditMemberTitleLBL.Location = new System.Drawing.Point(5, 5);
            this.EditMemberTitleLBL.Name = "EditMemberTitleLBL";
            this.EditMemberTitleLBL.Size = new System.Drawing.Size(748, 39);
            this.EditMemberTitleLBL.TabIndex = 0;
            this.EditMemberTitleLBL.Text = "Szerkesztés";
            this.EditMemberTitleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGroupContainerPanel
            // 
            this.dataGroupContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGroupContainerPanel.Controls.Add(this.newMemberSpacerPanel);
            this.dataGroupContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGroupContainerPanel.Location = new System.Drawing.Point(10, 59);
            this.dataGroupContainerPanel.Name = "dataGroupContainerPanel";
            this.dataGroupContainerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dataGroupContainerPanel.Size = new System.Drawing.Size(758, 49);
            this.dataGroupContainerPanel.TabIndex = 4;
            // 
            // newMemberSpacerPanel
            // 
            this.newMemberSpacerPanel.Controls.Add(this.emailTBX);
            this.newMemberSpacerPanel.Controls.Add(this.phoneNUM);
            this.newMemberSpacerPanel.Controls.Add(this.addressTBX);
            this.newMemberSpacerPanel.Controls.Add(this.nameTBX);
            this.newMemberSpacerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMemberSpacerPanel.Location = new System.Drawing.Point(5, 5);
            this.newMemberSpacerPanel.Name = "newMemberSpacerPanel";
            this.newMemberSpacerPanel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.newMemberSpacerPanel.Size = new System.Drawing.Size(746, 37);
            this.newMemberSpacerPanel.TabIndex = 5;
            // 
            // emailTBX
            // 
            this.emailTBX.BackColor = System.Drawing.SystemColors.Control;
            this.emailTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTBX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTBX.Location = new System.Drawing.Point(518, 6);
            this.emailTBX.Name = "emailTBX";
            this.emailTBX.PlaceholderText = "Email";
            this.emailTBX.Size = new System.Drawing.Size(228, 25);
            this.emailTBX.TabIndex = 3;
            // 
            // phoneNUM
            // 
            this.phoneNUM.BackColor = System.Drawing.SystemColors.Control;
            this.phoneNUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNUM.Dock = System.Windows.Forms.DockStyle.Left;
            this.phoneNUM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNUM.Location = new System.Drawing.Point(409, 6);
            this.phoneNUM.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.phoneNUM.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.phoneNUM.Name = "phoneNUM";
            this.phoneNUM.Size = new System.Drawing.Size(109, 25);
            this.phoneNUM.TabIndex = 2;
            this.phoneNUM.Value = new decimal(new int[] {
            1941261632,
            8,
            0,
            0});
            this.phoneNUM.ValueChanged += new System.EventHandler(this.phoneNUM_ValueChanged);
            this.phoneNUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNUM_KeyPress);
            // 
            // addressTBX
            // 
            this.addressTBX.BackColor = System.Drawing.SystemColors.Control;
            this.addressTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTBX.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressTBX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTBX.Location = new System.Drawing.Point(198, 6);
            this.addressTBX.Name = "addressTBX";
            this.addressTBX.PlaceholderText = "Lakcím";
            this.addressTBX.Size = new System.Drawing.Size(211, 25);
            this.addressTBX.TabIndex = 1;
            // 
            // nameTBX
            // 
            this.nameTBX.BackColor = System.Drawing.SystemColors.Control;
            this.nameTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTBX.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameTBX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTBX.Location = new System.Drawing.Point(0, 6);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.PlaceholderText = "Név";
            this.nameTBX.Size = new System.Drawing.Size(198, 25);
            this.nameTBX.TabIndex = 0;
            // 
            // ButtonContainerPanel
            // 
            this.ButtonContainerPanel.Controls.Add(this.CancelBTN);
            this.ButtonContainerPanel.Controls.Add(this.But);
            this.ButtonContainerPanel.Controls.Add(this.SaveBTN);
            this.ButtonContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonContainerPanel.Location = new System.Drawing.Point(10, 108);
            this.ButtonContainerPanel.Name = "ButtonContainerPanel";
            this.ButtonContainerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonContainerPanel.Size = new System.Drawing.Size(758, 49);
            this.ButtonContainerPanel.TabIndex = 5;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelBTN.Location = new System.Drawing.Point(525, 5);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(105, 39);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "Mégse";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // But
            // 
            this.But.Dock = System.Windows.Forms.DockStyle.Right;
            this.But.Location = new System.Drawing.Point(630, 5);
            this.But.Name = "But";
            this.But.Size = new System.Drawing.Size(18, 39);
            this.But.TabIndex = 7;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBTN.ForeColor = System.Drawing.Color.OliveDrab;
            this.SaveBTN.Location = new System.Drawing.Point(648, 5);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(105, 39);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "Mentés";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 166);
            this.Controls.Add(this.ButtonContainerPanel);
            this.Controls.Add(this.dataGroupContainerPanel);
            this.Controls.Add(this.newMemberPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMember";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Szerkesztés";
            this.newMemberPanel.ResumeLayout(false);
            this.dataGroupContainerPanel.ResumeLayout(false);
            this.newMemberSpacerPanel.ResumeLayout(false);
            this.newMemberSpacerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNUM)).EndInit();
            this.ButtonContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newMemberPanel;
        private System.Windows.Forms.Label EditMemberTitleLBL;
        private System.Windows.Forms.Panel dataGroupContainerPanel;
        private System.Windows.Forms.Panel newMemberSpacerPanel;
        private System.Windows.Forms.TextBox emailTBX;
        private System.Windows.Forms.NumericUpDown phoneNUM;
        private System.Windows.Forms.TextBox addressTBX;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.Panel ButtonContainerPanel;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Panel But;
        private System.Windows.Forms.Button SaveBTN;
    }
}