using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buddy {
    static class us {
        public static UserContext db = new UserContext();
        public static User currentuser;
        //public static int testinggithub;

        public static void register(string name, string pass) {
            using (SHA512 sha = SHA512.Create()) {
                //check if username is taken
                if (us.db.Users.Find(name) == null) {
                    byte[] hash;
                    hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
                    string x = string.Empty;
                    foreach (byte y in hash) {
                        x += y;
                    }
                    db.Users.Add(new User { username = name, password = x, friends = new List<User>() });
                } else {
                    MessageBox.Show("username is in use", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            db.SaveChanges();
        }

        public static void Login(string name, string pass, Form f) {
            byte[] hash;
            if (us.db.Users.Any(u => u.username == name)) {

                //hash text in password box and place bytes in to empty string x with foreach
                using (SHA512 sha = SHA512.Create()) {
                    hash = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
                }

                string x = string.Empty;
                foreach (byte y in hash) {
                    x += y;
                }

                if (us.db.Users.Any(u => u.username == name && u.password == x)) {
                    MessageBox.Show("Successfully logged in", "it worked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //whosloggedin = db.Users.Where(u => u.username == usernametextbox.Text && u.password == x).ToList()[0];
                    us.currentuser = us.db.Users.Find(name);
                    //Forms.MainScreen main = new Forms.MainScreen();
                    //main.Show();
                    //this.Hide();
                    f.Hide();
                    var main = new Forms.MainScreen();
                    main.FormClosed += (s, args) => f.Close();
                    main.Show();
                } else {
                    MessageBox.Show("Your password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Account doesn't exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void SendMessage(string recip, string content) {
            //assume sender is us.currentuser
            Message msg = new Message();
            try {
                msg = new Message { content = us.currentuser.username + ": " + content,
                    sender = us.currentuser,
                    recipient = us.db.Users.Find(recip),
                    TimeSent = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds };
            } catch {
                MessageBox.Show("User does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            us.db.Messages.Add(msg);
            us.currentuser.SentMessages.Add(us.db.Messages.Find(msg.ID));
            User temp = us.db.Users.Find(recip);
            temp.ReceivedMessages.Add(us.db.Messages.Find(msg.ID));

            us.db.SaveChanges();
        }
    }
}