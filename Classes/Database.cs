using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Buddy {
    public class UserContext : DbContext {
        public UserContext() : base("name=Official") {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Message>().map
        //}
    }

    public class User {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        //public int test { get; set; }
        
        public virtual ICollection<User> friends { get; set; }
        
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }

        public static implicit operator User(bool v) {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return username;
        }
    }

    public class Message {
        [Key]
        public int ID { get; set; }
        
        public virtual User sender { get; set; }
        public virtual User recipient { get; set; }

        public string content { get; set; }

        public int TimeSent { get; set; }
    }
}