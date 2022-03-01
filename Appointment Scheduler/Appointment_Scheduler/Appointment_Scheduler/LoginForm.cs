using System;
using System.Windows.Forms;
using System.Globalization;

namespace Appointment_Scheduler
{
    public partial class LoginForm : Form
    {
        private string loginFail = "The credentials entered are incorrect.";
        private string error = "There was an error which has been logged to \"ErrorLog.txt\"";
        private bool exception = false;

        public LoginForm()
        {
            if (CultureInfo.CurrentCulture.Name.Contains("de"))
            {
                loginFail = "Die Anmeldeinformationen sind falsch.";
                error = "Es ist ein Fehler aufgetreten, bei dem angemeldet wurde \"ErrorLog.txt\"";
            }
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (new Common().Login(txtUserName.Text, txtPassword.Text, ref exception))
                {
                    txtUserName.Text = null;
                    txtPassword.Text = null;
                    Hide();
                    new MainScreen().ShowDialog();
                    Common.WriteToLog(false);
                    User.SetUserID(0);
                    User.SetUserName(null);
                    
                    if (!IsDisposed)
                    {
                        Show();
                    }
                }
                else
                {
                     MessageBox.Show(exception ? error : loginFail);
                }
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();
    }
}