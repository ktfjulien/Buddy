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
    public partial class ConversationsForm : Form {
        public ConversationsForm() {
            InitializeComponent();

        }

        private void ConversationsForm_Load(object sender, EventArgs e) {
            foreach (var x in us.currentuser.friends) {
                listBox1.Items.Add(x.username);
            }
            var temp = us.currentuser.ReceivedMessages.Select(b => b);
            foreach (var x in temp) {
                if (x.sender.username == (string)listBox1.SelectedItem) {
                    string.Join(Environment.NewLine, x.content);
                }
            }
            listBox1.SelectedIndex = 0;
        }

        private void LoadMessages(string otheruser) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            MessagesBox.Text = String.Empty;
            User temp = us.db.Users.Find(listBox1.SelectedItem);
            var z = new List<Message>();

            foreach (var x in temp.SentMessages) {
                x.content = x.content.Insert(0, temp.username + ": ");
                if (x.recipient == us.currentuser) {
                    z.Add(x);
                }
            }

            foreach (var x in us.currentuser.SentMessages) {
                x.content = x.content.Insert(0, us.currentuser.username + ": ");
                if (x.recipient == temp) {
                    z.Add(x);
                }
            }

            z.Sort((x, y) => x.TimeSent.CompareTo(y.TimeSent));

            foreach (var x in z) {
                MessagesBox.Text += x.content + '\n';
            }

            // Replacing this with new, conversation like sorted messages code

            //var temp = us.currentuser.ReceivedMessages.ToArray();
            //foreach (var x in temp) {
            //    if (x.sender.username == (string)listBox1.SelectedItem) {
            //        MessagesBox.Text += string.Join(Environment.NewLine, x.content);
            //    }
            //}
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            if (textBox1.Text == "Search friends") {
                textBox1.Text = String.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            if (textBox1.Text == String.Empty) {
                textBox1.Text = "Search friends";
            }
        }

        private void MessageTextBox_Enter(object sender, EventArgs e) {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e) {
            us.SendMessage(listBox1.SelectedItem.ToString(), MessageTextBox.Text);

        }
    }
}