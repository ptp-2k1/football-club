using FootballClubManagement.Forms;

namespace FootballClubManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.IsWhiteSpace())
            {
                MessageBox.Show("You need to fill in user name !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.txtPassword.Text.IsWhiteSpace())
            {
                MessageBox.Show("You need to fill in password !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                new FormShowClubs().Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            this.btnSignIn.BackColor = Color.MediumSpringGreen;
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            this.txtUserName.BackColor = Color.PaleTurquoise;
            this.ActiveControl = null;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.PaleTurquoise;
            this.ActiveControl = null;
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            this.btnSignIn.BackColor = Color.MediumAquamarine;
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            this.txtUserName.BackColor = Color.White;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.White;
        }

        private void lblSignUp_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new FormSignUp().Show();
        }
    }
}
