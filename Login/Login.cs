using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Login
{
    public partial class LoginForm : Form
    {
        SQLConnection sc = new SQLConnection();
        Form2 fileform = new Form2();

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (sc.checkUser(NameBox.Text, sc.hashPW(PWBox.Text), registercheck.Checked) == true)
            {
                new ToastContentBuilder()
                   .AddArgument("action", "viewConversation")
                   .AddArgument("conversationId", 9813)
                   .AddText("Info")
                   .AddText("Logged In!")
                   .Show();
                fileform.ShowDialog();
            }
        }
    }
}
