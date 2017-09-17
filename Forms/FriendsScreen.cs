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
    public partial class FriendsScreen : Form {
        public FriendsScreen() { 
            InitializeComponent();
            //UserLabel.Text = currentuser.username;
            foreach (var x in us.currentuser.friends) {
                FriendsLabel.Text += x.username;
            }
            //FriendsLabel.Text = currentuser.friends.;
        }

        private void BackButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
