using Model;

namespace Controler
{
    public class UserControler
    {
        public static List<User> users { get; set; } = new List<User>();

        public User usr;
      //   public Employee emp;

      //   public Manager man;

        public UserControler()
         {
            usr = new User();
          //loadUsers();
         }

        private void loadUsers()
        {
          users = usr.ReadFromXml();

        }

        public void saveUsers()
        {
          usr.SerializeAsXml(users);
        }

        public void newUser( User user)
        {
           users.Add(user);
        }

        public List<User> getUsers()
        {
          return users;
        }



    }
}