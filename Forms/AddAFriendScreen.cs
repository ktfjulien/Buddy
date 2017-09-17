using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buddy.Forms {

    public partial class Add_A_Friend_Screen : Form {
        public Add_A_Friend_Screen() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            List<String> poop = new List<string>();
            if (us.db.Users.Any(u => u.username == usernametextbox.Text)) {
                if (usernametextbox.Text != us.currentuser.username) {
                    //db.Users.Find(currentuser.username).friends += usernametextbox.Text + ",";
                    //db.Users.Find(usernametextbox.Text).friends += currentuser.username + ",";
                    if (us.currentuser.friends != null) {
                        foreach (var x in us.currentuser.friends.ToArray()) {
                            poop.Add(x.username);
                        }
                    }
                    
                    if (poop.Contains(usernametextbox.Text)) {
                        MessageBox.Show("That user is already your friend", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        us.currentuser.friends.Add(us.db.Users.Find(usernametextbox.Text));
                        us.db.Users.Find(usernametextbox.Text).friends.Add(us.currentuser);
                        us.db.SaveChanges();
                        MessageBox.Show("Friend successfully added", "noice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainScreen main = new MainScreen();
                        main.Show();
                        this.Close();
                    }
                } else {
                    MessageBox.Show("You can't add yourself", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("User doesn't exist with that username", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            //MainScreen main = new MainScreen();
            //main.Show();
            this.Close();
        }
    }
}