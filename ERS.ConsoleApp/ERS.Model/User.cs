using System.IO;
using System.Xml.Serialization;
namespace ERS.Model
{
    public class User
    {
      
        public string userName { get;  set; }
        public string password { get;  set; }
        public string email { get;  set; }
        public bool isManager {get; set; }
        

        public User()
        { }

        public User(string name, string email, string password)
        {
            this.userName = name;
            this.email = email;
            this.password = password;
        }

        public User(string name, string email, string password, bool manager)
        {
            this.userName = name;
            this.email = email;
            this.password = password;
            this.isManager = manager;
        }

      

        // public List<Ticket> viewTickets();

    }
}