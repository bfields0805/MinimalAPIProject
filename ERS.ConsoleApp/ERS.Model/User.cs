namespace ERS.Model
{
    public class User
    {

        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool isManager { get; set; }

        public int empId { get; set; }


        public User()
        { }

        public User(string name, string email, string password, int empId)
        {
            this.userName = name;
            this.email = email;
            this.password = password;
            this.empId = empId;
        }

        public User(string name, string email, string password, bool manager)
        {
            this.userName = name;
            this.email = email;
            this.password = password;
            this.isManager = manager;
        }
        public User(string name, string email, string password)
        {
            this.email = email;
            this.userName = name;
            this.password = password;
            isManager = false;
        }



        // public List<Ticket> viewTickets();

    }
}