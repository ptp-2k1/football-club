namespace FootballClubManagement.Forms
{
    partial class FormShowClubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowClubs));
            tbctrlShowClubs = new TabControl();
            tbpShowClubs = new TabPage();
            listBox1 = new ListBox();
            pnShowClub = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            lbClubList = new Label();
            tbpRegisterClub = new TabPage();
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
            lblRegisterClub = new Label();
            tbpRunMatch = new TabPage();
            lblRunMatch = new Label();
            tbpViewMatch = new TabPage();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            btnRemove = new Button();
            lbViewMatch = new Label();
            tbpSignOut = new TabPage();
            tbctrlShowClubs.SuspendLayout();
            tbpShowClubs.SuspendLayout();
            pnShowClub.SuspendLayout();
            tbpRegisterClub.SuspendLayout();
            tbpRunMatch.SuspendLayout();
            tbpViewMatch.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbctrlShowClubs
            // 
            tbctrlShowClubs.Appearance = TabAppearance.Buttons;
            tbctrlShowClubs.Controls.Add(tbpShowClubs);
            tbctrlShowClubs.Controls.Add(tbpRegisterClub);
            tbctrlShowClubs.Controls.Add(tbpRunMatch);
            tbctrlShowClubs.Controls.Add(tbpViewMatch);
            tbctrlShowClubs.Controls.Add(tbpSignOut);
            tbctrlShowClubs.Cursor = Cursors.Hand;
            tbctrlShowClubs.Location = new Point(-2, -3);
            tbctrlShowClubs.Name = "tbctrlShowClubs";
            tbctrlShowClubs.SelectedIndex = 0;
            tbctrlShowClubs.ShowToolTips = true;
            tbctrlShowClubs.Size = new Size(1213, 610);
            tbctrlShowClubs.TabIndex = 0;
            tbctrlShowClubs.SelectedIndexChanged += tbctrlShowClubs_SelectedIndexChanged;
            // 
            // tbpShowClubs
            // 
            tbpShowClubs.BackColor = Color.SteelBlue;
            tbpShowClubs.Controls.Add(listBox1);
            tbpShowClubs.Controls.Add(pnShowClub);
            tbpShowClubs.Controls.Add(lbClubList);
            tbpShowClubs.ForeColor = Color.SlateBlue;
            tbpShowClubs.Location = new Point(4, 45);
            tbpShowClubs.Margin = new Padding(8);
            tbpShowClubs.Name = "tbpShowClubs";
            tbpShowClubs.Padding = new Padding(8);
            tbpShowClubs.Size = new Size(1205, 561);
            tbpShowClubs.TabIndex = 0;
            tbpShowClubs.Text = "Club list";
            tbpShowClubs.ToolTipText = "You can view all existed clubs here";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Lavender;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(135, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(917, 301);
            listBox1.TabIndex = 8;
            // 
            // pnShowClub
            // 
            pnShowClub.BackColor = Color.LightSteelBlue;
            pnShowClub.Controls.Add(btnDelete);
            pnShowClub.Controls.Add(btnEdit);
            pnShowClub.Location = new Point(135, 456);
            pnShowClub.Name = "pnShowClub";
            pnShowClub.Size = new Size(917, 82);
            pnShowClub.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(533, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 51);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.BackColor = Color.Gold;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(200, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 51);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "EDIT";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbClubList
            // 
            lbClubList.AutoSize = true;
            lbClubList.FlatStyle = FlatStyle.Popup;
            lbClubList.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbClubList.ForeColor = Color.MidnightBlue;
            lbClubList.Location = new Point(138, 60);
            lbClubList.Name = "lbClubList";
            lbClubList.Size = new Size(916, 46);
            lbClubList.TabIndex = 6;
            lbClubList.Text = "Welcome back, manage your clubs and more !";
            // 
            // tbpRegisterClub
            // 
            tbpRegisterClub.BackColor = Color.SteelBlue;
            tbpRegisterClub.BorderStyle = BorderStyle.Fixed3D;
            tbpRegisterClub.Controls.Add(btnSave);
            tbpRegisterClub.Controls.Add(cbControlling);
            tbpRegisterClub.Controls.Add(cbDefend);
            tbpRegisterClub.Controls.Add(cbAttack);
            tbpRegisterClub.Controls.Add(lbPlayingStyle);
            tbpRegisterClub.Controls.Add(rdbtnOthers);
            tbpRegisterClub.Controls.Add(rdbtnEuropaLeague);
            tbpRegisterClub.Controls.Add(rdbtnChampionLeague);
            tbpRegisterClub.Controls.Add(cbbLeague);
            tbpRegisterClub.Controls.Add(txtName);
            tbpRegisterClub.Controls.Add(lbCupTournament);
            tbpRegisterClub.Controls.Add(lbLeague);
            tbpRegisterClub.Controls.Add(lbName);
            tbpRegisterClub.Controls.Add(lblRegisterClub);
            tbpRegisterClub.ForeColor = Color.DarkSlateBlue;
            tbpRegisterClub.Location = new Point(4, 45);
            tbpRegisterClub.Margin = new Padding(8);
            tbpRegisterClub.Name = "tbpRegisterClub";
            tbpRegisterClub.Padding = new Padding(8);
            tbpRegisterClub.Size = new Size(1205, 561);
            tbpRegisterClub.TabIndex = 1;
            tbpRegisterClub.Text = "Register club";
            tbpRegisterClub.ToolTipText = "You can register a new club here";
            tbpRegisterClub.UseVisualStyleBackColor = true;
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
            btnSave.Location = new Point(485, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 68);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // cbControlling
            // 
            cbControlling.AutoSize = true;
            cbControlling.ForeColor = Color.Black;
            cbControlling.Location = new Point(926, 371);
            cbControlling.Name = "cbControlling";
            cbControlling.Size = new Size(170, 37);
            cbControlling.TabIndex = 23;
            cbControlling.Text = "Controlling";
            cbControlling.UseVisualStyleBackColor = true;
            // 
            // cbDefend
            // 
            cbDefend.AutoSize = true;
            cbDefend.ForeColor = Color.Black;
            cbDefend.Location = new Point(708, 371);
            cbDefend.Name = "cbDefend";
            cbDefend.Size = new Size(122, 37);
            cbDefend.TabIndex = 22;
            cbDefend.Text = "Defend";
            cbDefend.UseVisualStyleBackColor = true;
            // 
            // cbAttack
            // 
            cbAttack.AutoSize = true;
            cbAttack.ForeColor = Color.Black;
            cbAttack.Location = new Point(457, 371);
            cbAttack.Name = "cbAttack";
            cbAttack.Size = new Size(114, 37);
            cbAttack.TabIndex = 20;
            cbAttack.Text = "Attack";
            cbAttack.UseVisualStyleBackColor = true;
            // 
            // lbPlayingStyle
            // 
            lbPlayingStyle.AutoSize = true;
            lbPlayingStyle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPlayingStyle.ForeColor = Color.Black;
            lbPlayingStyle.Location = new Point(164, 371);
            lbPlayingStyle.Name = "lbPlayingStyle";
            lbPlayingStyle.Size = new Size(176, 32);
            lbPlayingStyle.TabIndex = 19;
            lbPlayingStyle.Text = "Playing style:";
            // 
            // rdbtnOthers
            // 
            rdbtnOthers.AutoSize = true;
            rdbtnOthers.ForeColor = Color.Black;
            rdbtnOthers.Location = new Point(926, 300);
            rdbtnOthers.Name = "rdbtnOthers";
            rdbtnOthers.Size = new Size(114, 37);
            rdbtnOthers.TabIndex = 18;
            rdbtnOthers.TabStop = true;
            rdbtnOthers.Text = "Others";
            rdbtnOthers.UseVisualStyleBackColor = true;
            // 
            // rdbtnEuropaLeague
            // 
            rdbtnEuropaLeague.AutoSize = true;
            rdbtnEuropaLeague.ForeColor = Color.Black;
            rdbtnEuropaLeague.Location = new Point(708, 300);
            rdbtnEuropaLeague.Name = "rdbtnEuropaLeague";
            rdbtnEuropaLeague.Size = new Size(198, 37);
            rdbtnEuropaLeague.TabIndex = 17;
            rdbtnEuropaLeague.TabStop = true;
            rdbtnEuropaLeague.Text = "Europa league";
            rdbtnEuropaLeague.UseVisualStyleBackColor = true;
            // 
            // rdbtnChampionLeague
            // 
            rdbtnChampionLeague.AutoSize = true;
            rdbtnChampionLeague.ForeColor = Color.Black;
            rdbtnChampionLeague.Location = new Point(457, 298);
            rdbtnChampionLeague.Name = "rdbtnChampionLeague";
            rdbtnChampionLeague.Size = new Size(233, 37);
            rdbtnChampionLeague.TabIndex = 13;
            rdbtnChampionLeague.TabStop = true;
            rdbtnChampionLeague.Text = "Champion league";
            rdbtnChampionLeague.UseVisualStyleBackColor = true;
            // 
            // cbbLeague
            // 
            cbbLeague.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLeague.FlatStyle = FlatStyle.Popup;
            cbbLeague.FormattingEnabled = true;
            cbbLeague.Location = new Point(457, 226);
            cbbLeague.Name = "cbbLeague";
            cbbLeague.Size = new Size(225, 41);
            cbbLeague.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(457, 162);
            txtName.MaxLength = 15;
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 40);
            txtName.TabIndex = 11;
            // 
            // lbCupTournament
            // 
            lbCupTournament.AutoSize = true;
            lbCupTournament.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCupTournament.ForeColor = Color.Black;
            lbCupTournament.Location = new Point(164, 300);
            lbCupTournament.Name = "lbCupTournament";
            lbCupTournament.Size = new Size(222, 32);
            lbCupTournament.TabIndex = 10;
            lbCupTournament.Text = "Cup tournament:";
            // 
            // lbLeague
            // 
            lbLeague.AutoSize = true;
            lbLeague.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLeague.ForeColor = Color.Black;
            lbLeague.Location = new Point(164, 229);
            lbLeague.Name = "lbLeague";
            lbLeague.Size = new Size(110, 32);
            lbLeague.TabIndex = 9;
            lbLeague.Text = "League:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(164, 162);
            lbName.Name = "lbName";
            lbName.Size = new Size(91, 32);
            lbName.TabIndex = 8;
            lbName.Text = "Name:";
            // 
            // lblRegisterClub
            // 
            lblRegisterClub.AutoSize = true;
            lblRegisterClub.FlatStyle = FlatStyle.Popup;
            lblRegisterClub.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterClub.ForeColor = Color.MidnightBlue;
            lblRegisterClub.Location = new Point(152, 60);
            lblRegisterClub.Name = "lblRegisterClub";
            lblRegisterClub.Size = new Size(899, 46);
            lblRegisterClub.TabIndex = 7;
            lblRegisterClub.Text = "Fill in all things about this new fanstantic club";
            // 
            // tbpRunMatch
            // 
            tbpRunMatch.BackColor = Color.SteelBlue;
            tbpRunMatch.BorderStyle = BorderStyle.Fixed3D;
            tbpRunMatch.Controls.Add(lblRunMatch);
            tbpRunMatch.Location = new Point(4, 45);
            tbpRunMatch.Name = "tbpRunMatch";
            tbpRunMatch.Size = new Size(1205, 561);
            tbpRunMatch.TabIndex = 2;
            tbpRunMatch.Text = "Run match";
            tbpRunMatch.ToolTipText = "Start a match randomly";
            // 
            // lblRunMatch
            // 
            lblRunMatch.AutoSize = true;
            lblRunMatch.FlatStyle = FlatStyle.Popup;
            lblRunMatch.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRunMatch.ForeColor = Color.MidnightBlue;
            lblRunMatch.Location = new Point(276, 60);
            lblRunMatch.Name = "lblRunMatch";
            lblRunMatch.Size = new Size(604, 46);
            lblRunMatch.TabIndex = 8;
            lblRunMatch.Text = "Are you ready for this match ?";
            // 
            // tbpViewMatch
            // 
            tbpViewMatch.BackColor = Color.SteelBlue;
            tbpViewMatch.Controls.Add(groupBox1);
            tbpViewMatch.Controls.Add(lbViewMatch);
            tbpViewMatch.Location = new Point(4, 45);
            tbpViewMatch.Name = "tbpViewMatch";
            tbpViewMatch.Size = new Size(1205, 561);
            tbpViewMatch.TabIndex = 4;
            tbpViewMatch.Text = "View match";
            tbpViewMatch.ToolTipText = "You can check out the matches' records here";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Location = new Point(136, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(931, 421);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Match - up";
            // 
            // listView1
            // 
            listView1.BackColor = Color.Lavender;
            listView1.Location = new Point(6, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(919, 319);
            listView1.TabIndex = 28;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemove
            // 
            btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemove.BackColor = Color.OrangeRed;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(377, 372);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(191, 43);
            btnRemove.TabIndex = 27;
            btnRemove.Text = "REMOVE";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // lbViewMatch
            // 
            lbViewMatch.AutoSize = true;
            lbViewMatch.FlatStyle = FlatStyle.Popup;
            lbViewMatch.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbViewMatch.ForeColor = Color.MidnightBlue;
            lbViewMatch.Location = new Point(121, 60);
            lbViewMatch.Name = "lbViewMatch";
            lbViewMatch.Size = new Size(964, 46);
            lbViewMatch.TabIndex = 9;
            lbViewMatch.Text = "What wonderful matches there were, weren't it ?";
            // 
            // tbpSignOut
            // 
            tbpSignOut.BorderStyle = BorderStyle.Fixed3D;
            tbpSignOut.Location = new Point(4, 45);
            tbpSignOut.Name = "tbpSignOut";
            tbpSignOut.Size = new Size(1205, 561);
            tbpSignOut.TabIndex = 3;
            tbpSignOut.Text = "Sign out";
            tbpSignOut.ToolTipText = "You can sign out here";
            tbpSignOut.UseVisualStyleBackColor = true;
            // 
            // FormShowClubs
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(1200, 594);
            Controls.Add(tbctrlShowClubs);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormShowClubs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organize your clubs here";
            tbctrlShowClubs.ResumeLayout(false);
            tbpShowClubs.ResumeLayout(false);
            tbpShowClubs.PerformLayout();
            pnShowClub.ResumeLayout(false);
            tbpRegisterClub.ResumeLayout(false);
            tbpRegisterClub.PerformLayout();
            tbpRunMatch.ResumeLayout(false);
            tbpRunMatch.PerformLayout();
            tbpViewMatch.ResumeLayout(false);
            tbpViewMatch.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbctrlShowClubs;
        private TabPage tbpShowClubs;
        private TabPage tbpRegisterClub;
        private TabPage tbpRunMatch;
        private TabPage tbpSignOut;
        private Label lblClubList;
        private Label lblRegisterClub;
        private Label lblRunMatch;
        private Label lbName;
        private Label lbCupTournament;
        private Label lbLeague;
        private Button btnSave;
        private RadioButton rdbtnChampionLeague;
        private ComboBox cbbLeague;
        private TextBox txtName;
        private RadioButton rdbtnOthers;
        private RadioButton rdbtnEuropaLeague;
        private CheckBox cbControlling;
        private CheckBox cbDefend;
        private CheckBox cbAttack;
        private Label lbPlayingStyle;
        private ListBox listBox1;
        private Panel pnShowClub;
        private Button btnEdit;
        private Label lbClubList;
        private TabPage tbpViewMatch;
        private Label lbViewMatch;
        private GroupBox groupBox1;
        private Button btnDelete;
        private ListView listView1;
        private Button btnRemove;
    }
}