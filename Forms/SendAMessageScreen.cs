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
    public partial class SendAMessageScreen : Form {

        public SendAMessageScreen() {
            InitializeComponent();
            this.AcceptButton = SendButton;
            //Populate Combo Box with friends' names if user has friends, works but has no group messaging capability

            //if (currentuser.friends != null) {
            //    foreach (var x in currentuser.friends) {
            //        comboBox1.Items.Add(x.username);
            //    }
            //}

        }

        private void SendButton_Click(object sender, EventArgs e) {

            Message msg = new Message();
            try {
               msg = new Message { content = ContentBox.Text, sender = us.currentuser, recipient = us.db.Users.Find(textBox1.Text) };
            } catch {
                MessageBox.Show("User does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            us.db.Messages.Add(msg);
            us.currentuser.SentMessages.Add(us.db.Messages.Find(msg.ID));
            User temp =us. db.Users.Find(textBox1.Text);
            temp.ReceivedMessages.Add(us.db.Messages.Find(msg.ID));

            us. db.SaveChanges();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            MainScreen main = new MainScreen();
            main.Show();
            this.Close();
        }

        private void RecipientBox_TextChanged(object sender, EventArgs e) {

        }
    }
}