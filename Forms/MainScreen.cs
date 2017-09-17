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
    public partial class MainScreen : Form {
        public MainScreen() {
            InitializeComponent();
            label2.Text = us.currentuser.username;
        }

        private void AddFriendButton_Click(object sender, EventArgs e) {
            this.Hide();
            var add = new Add_A_Friend_Screen();
            add.FormClosed += (s, args) => this.Show();
            add.Show();
            //Add_A_Friend_Screen add = new Add_A_Friend_Screen();
            //add.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void FriendsListButton_Click(object sender, EventArgs e) {
            this.Hide();
            var fr = new FriendsScreen();
            fr.FormClosed += (s, args) => this.Show();
            fr.Show();
            //FriendsScreen friends = new FriendsScreen();
            //friends.Show();
            //this.Close();
        }

        private void MessageButton_Click(object sender, EventArgs e) {
            if (us.currentuser.friends != null) {
                this.Hide();
                var send = new SendAMessageScreen();
                send.FormClosed += (s, args) => this.Show();
                send.Show();
                //SendAMessageScreen send = new SendAMessageScreen();
                //send.Show();
                //this.Close();
            } else {
                MessageBox.Show("You must have friends to send messages", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
        }

        private void MessagesButton_Click(object sender, EventArgs e) {
            this.Hide();
            var msg = new MessagesScreen();
            msg.FormClosed += (s, args) => this.Show();
            msg.Show();
            //MessagesScreen message = new MessagesScreen();
            //message.Show();
            //this.Close();
        }

        private void ConversationsButton_Click(object sender, EventArgs e) {
            this.Hide();
            var con = new Forms.ConversationsForm();
            con.FormClosed += (s, args) => this.Show();
            con.Show();
        }
    }
}