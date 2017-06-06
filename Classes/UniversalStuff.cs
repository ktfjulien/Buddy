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
                    db.Users.Add(new User { username = name, password = sha.ComputeHash(Encoding.UTF8.GetBytes(pass)).ToString() });
                } else {
                    MessageBox.Show("username is in use", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            db.SaveChangesAsync();
            
            

            
        }
    }

    
}