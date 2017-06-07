using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buddy {
    public partial class FirstScreen : Form {

        public FirstScreen() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            this.Hide();
            var register = new RegisterScreen();
            register.FormClosed += (s, args) => this.Close();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            var login = new LoginScreen();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}