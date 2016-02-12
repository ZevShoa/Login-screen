using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_screen
{
    public partial class login : UserControl
    {

        public login()
        {
            InitializeComponent();
        }

        
        

        private void passBox_TextChanged_1(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
            passShow.Text = passBox.Text;
        }

       
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Form1.user == userBox.Text && Form1.pass == passBox.Text)
            {


                Form f = this.FindForm();
                f.Controls.Remove(this);
                Loged_In li = new Loged_In();
                f.Controls.Add(li);
               
            }
            else if (Form1.user != userBox.Text || Form1.pass != passBox.Text)
            {
                loginButton.Text = "wrong";
            }
        }
    }
}
