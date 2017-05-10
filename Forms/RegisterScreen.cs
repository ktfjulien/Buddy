using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Buddy {
    public partial class RegisterScreen : Form {
        public RegisterScreen() {
            InitializeComponent();
            AcceptButton = button1;
        }

        void register() {
            byte[] hash;
            using (SHA512 sha = SHA512.Create()) {
                hash = sha.ComputeHash(Encoding.UTF8.GetBytes(passwordtextbox.Text));
            }
            string x = string.Empty;
            foreach (byte y in hash) {
                x += y;
            }
            try {
                User temp = new User { username = usernametextbox.Text, password = x, friends = new List<User>() };
                if (us.db.Users.Find(temp.username) == null) {
                    us.db.Users.Add(temp);
                    us.db.SaveChanges();
                    LoginScreen login = new LoginScreen();
                    login.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("User already exists with that username, choose new username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            register();
        }
    }
}