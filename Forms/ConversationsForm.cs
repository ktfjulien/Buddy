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
            listBox1.DataSource = us.currentuser.friends.ToList();
            //string[] s = new string[us.currentuser.friends.ToArray().Length];
            //var bud = new AutoCompleteStringCollection();
            //for (int i = 0; i < s.Length; i++) {
            //    s[i] = listBox1.Items[0].ToString();
            //}
            //bud.AddRange(s);
            //textBox1.AutoCompleteCustomSource = bud;
            
            comboBox1.DataSource = us.currentuser.friends.ToList();
        }

        private void ConversationsForm_Load(object sender, EventArgs e) {
            //foreach (var x in us.currentuser.friends) {
            //    listBox1.Items.Add(x.username);
            //}
            try {
                var temp = us.currentuser.ReceivedMessages.Select(b => b);
                foreach (var x in temp) {
                    if (x.sender.username == (string)listBox1.SelectedItem) {
                        string.Join(Environment.NewLine, x.content);
                    }
                }
                listBox1.SelectedIndex = 0;
            } catch {

            }
            
        }

        private void LoadMessages() {
            MessagesBox.Text = String.Empty;
            User temp = us.db.Users.Find(listBox1.SelectedItem.ToString());
            var z = new List<Message>();

            foreach (var x in temp.SentMessages) {
                //x.content = x.content.Insert(0, temp.username + ": ");
                if (x.recipient == us.currentuser) {
                    z.Add(x);
                }
            }

            foreach (var x in us.currentuser.SentMessages) {
                //x.content = x.content.Insert(0, us.currentuser.username + ": ");
                if (x.recipient == temp) {
                    z.Add(x);
                }
            }

            z.Sort((x, y) => x.TimeSent.CompareTo(y.TimeSent));

            foreach (var x in z) {
                //if (x.sender.username == us.currentuser.username) {
                //    MessagesBox.SelectionStart = 0;
                //    MessagesBox.SelectionLength = us.currentuser.username.Length + 1;
                //    MessagesBox.SelectionFont = new Font(MessagesBox.Font, System.Drawing.FontStyle.Bold);
                //}
                MessagesBox.Text += x.content + '\n';
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            LoadMessages();
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
            LoadMessages();
        }

        private void AddFriendButton_Click(object sender, EventArgs e) {
            //this.Hide();
            var add = new Add_A_Friend_Screen();
            add.FormClosed += (s, args) => this.Show();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog();
            listBox1.DataSource = us.currentuser.friends.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            //listBox1.Items.Clear();
            //foreach (var str in us.currentuser.friends) {
            //    if (str.username.StartsWith(textBox1.Text, StringComparison.CurrentCultureIgnoreCase)) {
            //        listBox1.Items.Add(str.username);
            //    }
            //}
        }
    }
}