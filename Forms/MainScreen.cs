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
            Add_A_Friend_Screen add = new Add_A_Friend_Screen();
            add.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            NewMain first = new NewMain();
            first.Show();
            this.Close();
        }

        private void FriendsListButton_Click(object sender, EventArgs e) {
            FriendsScreen friends = new FriendsScreen();
            friends.Show();
            this.Close();
        }

        private void MessageButton_Click(object sender, EventArgs e) {
            if (us.currentuser.friends != null) {
                SendAMessageScreen send = new SendAMessageScreen();
                send.Show();
                this.Close();
            } else {
                MessageBox.Show("You must have friends to send messages", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            MessagesScreen message = new MessagesScreen();
            message.Show();
            this.Close();
        }
    }
}