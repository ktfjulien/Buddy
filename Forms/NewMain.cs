using Buddy.Forms;
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

namespace Buddy {
    public partial class NewMain : Form {
        public NewMain() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Rewritten login code
            //using (SHA512 sha = SHA512.Create()) {
            //    User temp = new User { username = usernametextbox.Text, password = sha.ComputeHash(Encoding.UTF8.GetBytes(passwordtextbox.Text)).ToString() };

            //    if (us.db.Users.Where(b => b.username == temp.username) != null) {
            //        MessageBox.Show("Successfully logged in", "it worked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}



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
                    //Forms.MainScreen main = new Forms.MainScreen();
                    //main.Show();
                    //this.Hide();
                    this.Hide();
                    var main = new MainScreen();
                    main.FormClosed += (s, args) => this.Close();
                    main.Show();
                } else {
                    MessageBox.Show("Your password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Account doesn't exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            //try {
                us.register(usernametextbox2.Text, passwordtextbox2.Text);
                us.currentuser = us.db.Users.Find(usernametextbox2.Text);
            //} catch {
            //    return;
            //}
            

            this.Hide();
            var main = new MainScreen();
            main.FormClosed += (s, args) => this.Close();
            main.Show();

            //byte[] hash;
            //using (SHA512 sha = SHA512.Create()) {
            //    hash = sha.ComputeHash(Encoding.UTF8.GetBytes(passwordtextbox.Text));
            //}
            //string x = string.Empty;
            //foreach (byte y in hash) {
            //    x += y;
            //}
            //try {
            //    User temp = new User { username = usernametextbox2.Text, password = x, friends = new List<User>() };
            //    if (us.db.Users.Find(temp.username) == null) {
            //        us.db.Users.Add(temp);
            //        us.db.SaveChanges();
            //        Forms.MainScreen main = new Forms.MainScreen();
            //        main.Show();
            //        this.Hide();
            //    } else {
            //        MessageBox.Show("User already exists with that username, choose new username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //} catch (Exception ex) {
            //    MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}