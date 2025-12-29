using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballClubManagement.Forms
{
    public partial class FormShowClubs : Form

    {
        int currentSelectedTabIndex;
        String[] leagueItems;
        public FormShowClubs()
        {
            InitializeComponent();

            currentSelectedTabIndex = this.tbctrlShowClubs.SelectedIndex;
            leagueItems = new String[] { "Laliga", "Premeire League", "Bundesliga", "Serie A", "Ligue 1" };
            this.cbbLeague.Items.AddRange(leagueItems);
            this.cbbLeague.SelectedIndex = 0;
            this.cbbLeague.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tbctrlShowClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbctrlShowClubs.SelectedIndex == 4)
            {
                if (MessageBox.Show("Confirm to sign out now ?", "Sign out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Hide();
                    new FormMain().Show();
                }
                else
                {
                    this.tbctrlShowClubs.SelectedIndex = currentSelectedTabIndex;

                }
            }

            currentSelectedTabIndex = this.tbctrlShowClubs.SelectedIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormEdit().Show();
        }
    }
}
 