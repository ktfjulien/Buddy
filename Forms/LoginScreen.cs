 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buddy.Forms;

namespace Buddy {

    public partial class LoginScreen : Form {
        public LoginScreen() {
            InitializeComponent();
            AcceptButton = button1;
        }

        public void button1_Click(object sender, EventArgs e) {
            byte[] hash;
            
            if (us.db.Users.Any(u => u.username == usernametextbox.Text)) {

                //hash text in password box and place bytes in to empty string x with foreach
                using (SHA512 sha = SHA512.Create()) {
                    hash = sha.ComputeHash(Encoding.UTF8.GetBytes(passwordtextbox.Text));
                }
                string x = string.Empty;
                foreach (byte y in hash) {
                    x += y;
                }
                
                if (us.db.Users.Any(u => u.username == usernametextbox.Text && u.password == x)) {
                    MessageBox.Show("Successfully logged in", "it worked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //whosloggedin = db.Users.Where(u => u.username == usernametextbox.Text && u.password == x).ToList()[0];
                    us.currentuser = us.db.Users.Find(usernametextbox.Text);
                    MainScreen main = new MainScreen();
                    main.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Your password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Account doesn't exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}