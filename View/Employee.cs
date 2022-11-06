
using System.Text;
using System.Xml.Serialization;
using Controler;
namespace Model
{
  
       [XmlInclude(typeof(User))]
    public class Employee : User
    {
        
          public Employee() : base(){}


        public Employee(string name, string email, string password) : base(name, email, password)
        {

        }

         public void generateTicket(double amount, string data)
         {
            Ticket ticket = new Ticket(this.userName, amount, data);
            TicketControler tc = new TicketControler();
            tc.addNewTicket(ticket);
         }


         public List<Ticket> viewTickets()
         {
            TicketControler tc = new TicketControler();
            return tc.getAllTickets();
         }







    }

}