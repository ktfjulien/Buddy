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
    public partial class MessagesScreen : Form {

        public MessagesScreen() {
            InitializeComponent();

            LoadMessages();

            //Fastest and elegant way to do this, doesnt work, also needs sender name before actual message

            //MainMessagesBox.Text = string.Join(Environment.NewLine, currentuser.ReceivedMessages.Select(b => b.sender.username), currentuser.ReceivedMessages.Select(b => b.content));

            //foreach (var x in currentuser.ReceivedMessages) {
            //    MainMessagesBox.Text += x.content;
            //}
            //MainMessagesBox.Text = currentuser.ReceivedMessages

            //Get received messages but from message IDS

            //List<string> things = new List<string>();
            //foreach (var x in currentuser.ReceivedMessages) {
            //    things = (from b in db.Messages where b.ID == x.ID select b.content).ToList();
            //}

            //foreach (var x in things) {
            //    MainMessagesBox.Text += x;
            //}



            //Received and sent messages are collections of ints

            //List<string> things = new List<string>();
            //foreach (var x in currentuser.ReceivedMessages) {
            //    things = (from b in db.Messages where b.ID == x select b.content).ToList();
            //}

            //foreach (var x in things) {
            //    MainMessagesBox.Text += x;
            //}
        }

        private void BackButton_Click(object sender, EventArgs e) {
            MainScreen main = new MainScreen();
            main.Show();
            this.Close();
        }

        private void LoadMessages() {
            
            MainMessagesBox.Text = string.Join(Environment.NewLine, us.currentuser.ReceivedMessages.Select(b => b.content));
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            //db.Entry(currentuser).Reload();
            //foreach (var entity in db.ChangeTracker.Entries()) {
            //    entity.Reload();
            //}
            us.db.Dispose();
            us.db = new UserContext();
            us.currentuser = us.db.Users.Find(us.currentuser.username);
            LoadMessages();
        }
    }
}