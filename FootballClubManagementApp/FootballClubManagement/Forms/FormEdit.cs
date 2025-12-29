using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballClubManagement.Forms
{
    public partial class FormEdit : Form
    {
        int currentSelectedTabIndex;
        String[] leagueItems;
        public FormEdit()
        {
            InitializeComponent();

            leagueItems = new String[] { "Laliga", "Premeire League", "Bundesliga", "Serie A", "Ligue 1" };
            this.cbbLeague.Items.AddRange(leagueItems);
            this.cbbLeague.SelectedIndex = 0;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormShowClubs().Show();
        }
    }
}
