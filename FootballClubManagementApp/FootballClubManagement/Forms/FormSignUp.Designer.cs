namespace FootballClubManagement.Forms
{
    partial class FormSignUp
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            btnSignUp = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ptbUserName = new PictureBox();
            ptbPassword = new PictureBox();
            lbSignUp = new Label();
            lbSignIn = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)ptbUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPassword).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignUp.BackColor = Color.MediumSpringGreen;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Image = (Image)resources.GetObject("btnSignUp.Image");
            btnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignUp.Location = new Point(483, 351);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(223, 68);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.TextAlign = ContentAlignment.MiddleRight;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            btnSignUp.MouseEnter += btnSignIn_MouseEnter;
            btnSignUp.MouseLeave += btnSignIn_MouseLeave;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.PaleTurquoise;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Location = new Point(471, 202);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User name";
            txtUserName.Size = new Size(301, 40);
            txtUserName.TabIndex = 1;
            txtUserName.MouseEnter += txtUserName_MouseEnter;
            txtUserName.MouseLeave += txtUserName_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.PaleTurquoise;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(471, 267);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(301, 40);
            txtPassword.TabIndex = 2;
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            // 
            // ptbUserName
            // 
            ptbUserName.Image = (Image)resources.GetObject("ptbUserName.Image");
            ptbUserName.Location = new Point(409, 202);
            ptbUserName.Name = "ptbUserName";
            ptbUserName.Size = new Size(56, 40);
            ptbUserName.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbUserName.TabIndex = 3;
            ptbUserName.TabStop = false;
            // 
            // ptbPassword
            // 
            ptbPassword.Image = (Image)resources.GetObject("ptbPassword.Image");
            ptbPassword.Location = new Point(409, 267);
            ptbPassword.Name = "ptbPassword";
            ptbPassword.Size = new Size(56, 40);
            ptbPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbPassword.TabIndex = 4;
            ptbPassword.TabStop = false;
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.FlatStyle = FlatStyle.Popup;
            lbSignUp.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignUp.ForeColor = Color.MidnightBlue;
            lbSignUp.Location = new Point(271, 52);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(669, 46);
            lbSignUp.TabIndex = 5;
            lbSignUp.Text = "Hey come join us now with 1 click";
            // 
            // lbSignIn
            // 
            lbSignIn.ActiveLinkColor = Color.SteelBlue;
            lbSignIn.AutoSize = true;
            lbSignIn.Location = new Point(409, 446);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(353, 33);
            lbSignIn.TabIndex = 7;
            lbSignIn.TabStop = true;
            lbSignIn.Text = "Already joined ? Let's sign in !";
            lbSignIn.LinkClicked += lbSignIn_LinkClicked;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1200, 594);
            Controls.Add(lbSignIn);
            Controls.Add(lbSignUp);
            Controls.Add(ptbPassword);
            Controls.Add(ptbUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnSignUp);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organize your clubs here";
            ((System.ComponentModel.ISupportInitialize)ptbUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label lbUserName;
        private PictureBox ptbUserName;
        private PictureBox ptbPassword;
        private Label lbSignUp;
        private LinkLabel lbSignIn;
    }
}