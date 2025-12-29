namespace FootballClubManagement.Forms
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            btnSave = new Button();
            cbControlling = new CheckBox();
            cbDefend = new CheckBox();
            cbAttack = new CheckBox();
            lbPlayingStyle = new Label();
            rdbtnOthers = new RadioButton();
            rdbtnEuropaLeague = new RadioButton();
            rdbtnChampionLeague = new RadioButton();
            cbbLeague = new ComboBox();
            txtName = new TextBox();
            lbCupTournament = new Label();
            lbLeague = new Label();
            lbName = new Label();
            lblEditClub = new Label();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.MediumSlateBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(484, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 68);
            btnSave.TabIndex = 38;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // cbControlling
            // 
            cbControlling.AutoSize = true;
            cbControlling.ForeColor = Color.Black;
            cbControlling.Location = new Point(925, 374);
            cbControlling.Name = "cbControlling";
            cbControlling.Size = new Size(170, 37);
            cbControlling.TabIndex = 37;
            cbControlling.Text = "Controlling";
            cbControlling.UseVisualStyleBackColor = true;
            // 
            // cbDefend
            // 
            cbDefend.AutoSize = true;
            cbDefend.ForeColor = Color.Black;
            cbDefend.Location = new Point(707, 374);
            cbDefend.Name = "cbDefend";
            cbDefend.Size = new Size(122, 37);
            cbDefend.TabIndex = 36;
            cbDefend.Text = "Defend";
            cbDefend.UseVisualStyleBackColor = true;
            // 
            // cbAttack
            // 
            cbAttack.AutoSize = true;
            cbAttack.ForeColor = Color.Black;
            cbAttack.Location = new Point(456, 374);
            cbAttack.Name = "cbAttack";
            cbAttack.Size = new Size(114, 37);
            cbAttack.TabIndex = 35;
            cbAttack.Text = "Attack";
            cbAttack.UseVisualStyleBackColor = true;
            // 
            // lbPlayingStyle
            // 
            lbPlayingStyle.AutoSize = true;
            lbPlayingStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPlayingStyle.ForeColor = Color.Black;
            lbPlayingStyle.Location = new Point(163, 374);
            lbPlayingStyle.Name = "lbPlayingStyle";
            lbPlayingStyle.Size = new Size(176, 32);
            lbPlayingStyle.TabIndex = 34;
            lbPlayingStyle.Text = "Playing style:";
            // 
            // rdbtnOthers
            // 
            rdbtnOthers.AutoSize = true;
            rdbtnOthers.ForeColor = Color.Black;
            rdbtnOthers.Location = new Point(925, 303);
            rdbtnOthers.Name = "rdbtnOthers";
            rdbtnOthers.Size = new Size(114, 37);
            rdbtnOthers.TabIndex = 33;
            rdbtnOthers.TabStop = true;
            rdbtnOthers.Text = "Others";
            rdbtnOthers.UseVisualStyleBackColor = true;
            // 
            // rdbtnEuropaLeague
            // 
            rdbtnEuropaLeague.AutoSize = true;
            rdbtnEuropaLeague.ForeColor = Color.Black;
            rdbtnEuropaLeague.Location = new Point(707, 303);
            rdbtnEuropaLeague.Name = "rdbtnEuropaLeague";
            rdbtnEuropaLeague.Size = new Size(198, 37);
            rdbtnEuropaLeague.TabIndex = 32;
            rdbtnEuropaLeague.TabStop = true;
            rdbtnEuropaLeague.Text = "Europa league";
            rdbtnEuropaLeague.UseVisualStyleBackColor = true;
            // 
            // rdbtnChampionLeague
            // 
            rdbtnChampionLeague.AutoSize = true;
            rdbtnChampionLeague.ForeColor = Color.Black;
            rdbtnChampionLeague.Location = new Point(456, 301);
            rdbtnChampionLeague.Name = "rdbtnChampionLeague";
            rdbtnChampionLeague.Size = new Size(233, 37);
            rdbtnChampionLeague.TabIndex = 31;
            rdbtnChampionLeague.TabStop = true;
            rdbtnChampionLeague.Text = "Champion league";
            rdbtnChampionLeague.UseVisualStyleBackColor = true;
            // 
            // cbbLeague
            // 
            cbbLeague.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLeague.FlatStyle = FlatStyle.Popup;
            cbbLeague.FormattingEnabled = true;
            cbbLeague.Location = new Point(456, 229);
            cbbLeague.Name = "cbbLeague";
            cbbLeague.Size = new Size(225, 41);
            cbbLeague.TabIndex = 30;
            // 
            // txtName
            // 
            txtName.Location = new Point(456, 165);
            txtName.MaxLength = 15;
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 40);
            txtName.TabIndex = 29;
            // 
            // lbCupTournament
            // 
            lbCupTournament.AutoSize = true;
            lbCupTournament.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCupTournament.ForeColor = Color.Black;
            lbCupTournament.Location = new Point(163, 303);
            lbCupTournament.Name = "lbCupTournament";
            lbCupTournament.Size = new Size(222, 32);
            lbCupTournament.TabIndex = 28;
            lbCupTournament.Text = "Cup tournament:";
            // 
            // lbLeague
            // 
            lbLeague.AutoSize = true;
            lbLeague.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLeague.ForeColor = Color.Black;
            lbLeague.Location = new Point(163, 232);
            lbLeague.Name = "lbLeague";
            lbLeague.Size = new Size(110, 32);
            lbLeague.TabIndex = 27;
            lbLeague.Text = "League:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(163, 165);
            lbName.Name = "lbName";
            lbName.Size = new Size(91, 32);
            lbName.TabIndex = 26;
            lbName.Text = "Name:";
            // 
            // lblEditClub
            // 
            lblEditClub.AutoSize = true;
            lblEditClub.FlatStyle = FlatStyle.Popup;
            lblEditClub.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditClub.ForeColor = Color.MidnightBlue;
            lblEditClub.Location = new Point(188, 70);
            lblEditClub.Name = "lblEditClub";
            lblEditClub.Size = new Size(828, 46);
            lblEditClub.TabIndex = 25;
            lblEditClub.Text = "Feel free to make this club nicely updated";
            // 
            // btnGoBack
            // 
            btnGoBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGoBack.BackColor = Color.SteelBlue;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Image = (Image)resources.GetObject("btnGoBack.Image");
            btnGoBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoBack.Location = new Point(9, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(173, 68);
            btnGoBack.TabIndex = 39;
            btnGoBack.Text = "Go back";
            btnGoBack.TextAlign = ContentAlignment.MiddleRight;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1200, 594);
            Controls.Add(btnGoBack);
            Controls.Add(btnSave);
            Controls.Add(cbControlling);
            Controls.Add(cbDefend);
            Controls.Add(cbAttack);
            Controls.Add(lbPlayingStyle);
            Controls.Add(rdbtnOthers);
            Controls.Add(rdbtnEuropaLeague);
            Controls.Add(rdbtnChampionLeague);
            Controls.Add(cbbLeague);
            Controls.Add(txtName);
            Controls.Add(lbCupTournament);
            Controls.Add(lbLeague);
            Controls.Add(lbName);
            Controls.Add(lblEditClub);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organize your clubs here";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox cbControlling;
        private CheckBox cbDefend;
        private CheckBox cbAttack;
        private Label lbPlayingStyle;
        private RadioButton rdbtnOthers;
        private RadioButton rdbtnEuropaLeague;
        private RadioButton rdbtnChampionLeague;
        private ComboBox cbbLeague;
        private TextBox txtName;
        private Label lbCupTournament;
        private Label lbLeague;
        private Label lbName;
        private Label lblEditClub;
        private Button btnGoBack;
    }
}