
namespace mysql_konyvtar_2 {
    partial class LoginForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameContainer = new System.Windows.Forms.Panel();
            this.usernameTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KezdolapLoginLabel = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ContainerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UsernameContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.LoginBtn);
            this.ContainerPanel.Controls.Add(this.panel1);
            this.ContainerPanel.Controls.Add(this.UsernameContainer);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 90);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Padding = new System.Windows.Forms.Padding(80);
            this.ContainerPanel.Size = new System.Drawing.Size(666, 310);
            this.ContainerPanel.TabIndex = 4;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(80, 150);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(506, 35);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Tovább";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passwordTBX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(80, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 35);
            this.panel1.TabIndex = 1;
            // 
            // passwordTBX
            // 
            this.passwordTBX.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTBX.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTBX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTBX.Location = new System.Drawing.Point(158, 0);
            this.passwordTBX.MaxLength = 30;
            this.passwordTBX.Name = "passwordTBX";
            this.passwordTBX.PasswordChar = '#';
            this.passwordTBX.Size = new System.Drawing.Size(346, 32);
            this.passwordTBX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jelszó";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameContainer
            // 
            this.UsernameContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameContainer.Controls.Add(this.usernameTBX);
            this.UsernameContainer.Controls.Add(this.label1);
            this.UsernameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsernameContainer.Location = new System.Drawing.Point(80, 80);
            this.UsernameContainer.Margin = new System.Windows.Forms.Padding(10);
            this.UsernameContainer.Name = "UsernameContainer";
            this.UsernameContainer.Size = new System.Drawing.Size(506, 35);
            this.UsernameContainer.TabIndex = 0;
            // 
            // usernameTBX
            // 
            this.usernameTBX.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTBX.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.usernameTBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTBX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTBX.Location = new System.Drawing.Point(158, 0);
            this.usernameTBX.MaxLength = 30;
            this.usernameTBX.Name = "usernameTBX";
            this.usernameTBX.Size = new System.Drawing.Size(346, 32);
            this.usernameTBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KezdolapLoginLabel
            // 
            this.KezdolapLoginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KezdolapLoginLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KezdolapLoginLabel.Location = new System.Drawing.Point(0, 0);
            this.KezdolapLoginLabel.Name = "KezdolapLoginLabel";
            this.KezdolapLoginLabel.Size = new System.Drawing.Size(666, 90);
            this.KezdolapLoginLabel.TabIndex = 3;
            this.KezdolapLoginLabel.Text = "Bejelentkezés";
            this.KezdolapLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBTN.BackColor = System.Drawing.Color.Transparent;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBTN.Location = new System.Drawing.Point(626, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(40, 40);
            this.CloseBTN.TabIndex = 5;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 400);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.KezdolapLoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(666, 400);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.ContainerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UsernameContainer.ResumeLayout(false);
            this.UsernameContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel UsernameContainer;
        private System.Windows.Forms.TextBox usernameTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KezdolapLoginLabel;
        private System.Windows.Forms.Button CloseBTN;
    }
}

