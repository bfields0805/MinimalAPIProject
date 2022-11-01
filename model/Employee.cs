

namespace Model
{
    public class Employee
    { 
        public string email {get; private set;}

        protected string pswd  {get; private set;}
        public string name {get; private set;}

        public bool isManager{get; private set;}
        
    
        public Employee(string email, string name)
        { 
          this.email = email;
          this.name = name;
          pswd = name;
          isManager = false;

        }

        public Employee (string email, string name, bool isManager)
        {
            this.email = email;
            this.name= name;
            this.isManager;
            pswd= name;
        }

        public void changePassword(string newPswd)
        {
           pswd= newPswd;
 
        }

        public void promote()
        {
            isManager = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(name+" "+" is manager? "+ isManager);
            return sb;
        }

        public Ticket createTicket(double money, string info){
            Ticket ticket = new Ticket(this, money, info );

            return ticket;
        }

        


    }

}