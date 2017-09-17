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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            MessagesBox.Text = String.Empty;
            var temp = us.currentuser.ReceivedMessages.ToArray();
            foreach (var x in temp) {
                if (x.sender.username == (string)listBox1.SelectedItem) {
                    MessagesBox.Text += string.Join(Environment.NewLine, x.content);
                }
            }
        }
    }
}