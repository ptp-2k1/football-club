namespace FootballClubManagement
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnSignIn = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ptbUserName = new PictureBox();
            ptbPassword = new PictureBox();
            lblSignIn = new Label();
            lblSignUp = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)ptbUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPassword).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignIn.BackColor = Color.MediumSpringGreen;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Image = (Image)resources.GetObject("btnSignIn.Image");
            btnSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignIn.Location = new Point(493, 351);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(223, 68);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.TextAlign = ContentAlignment.MiddleRight;
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            btnSignIn.MouseEnter += btnSignIn_MouseEnter;
            btnSignIn.MouseLeave += btnSignIn_MouseLeave;
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
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.FlatStyle = FlatStyle.Popup;
            lblSignIn.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.MidnightBlue;
            lblSignIn.Location = new Point(285, 50);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(637, 46);
            lblSignIn.TabIndex = 5;
            lblSignIn.Text = "Now let's sign you in to proceed";
            // 
            // lblSignUp
            // 
            lblSignUp.ActiveLinkColor = Color.SteelBlue;
            lblSignUp.AutoSize = true;
            lblSignUp.Location = new Point(471, 457);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(281, 33);
            lblSignUp.TabIndex = 6;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "No account ? join now !";
            lblSignUp.MouseClick += lblSignUp_MouseClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1200, 594);
            Controls.Add(lblSignUp);
            Controls.Add(lblSignIn);
            Controls.Add(ptbPassword);
            Controls.Add(ptbUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnSignIn);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organize your clubs here";
            ((System.ComponentModel.ISupportInitialize)ptbUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label lbUserName;
        private PictureBox ptbUserName;
        private PictureBox ptbPassword;
        private Label lblSignIn;
        private LinkLabel lblSignUp;
    }
}
