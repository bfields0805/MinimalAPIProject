using System;
using Model;
using Controler;

namespace View
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // TicketControler tc = new TicketControler();

            // Ticket t1 = new Ticket("employee1", 20.00, "Gas for company car");
            // Ticket t2 = new Ticket("employee2", 15.00, "Paper for copier");

            // tc.addNewTicket(t1);
            // tc.addNewTicket(t2);

            // List<Ticket> tkts = tc.getAllTickets();

            // foreach (Ticket t in tkts)
            // {
            //         Console.WriteLine(t);
            // }


              UserControler uc = new UserControler();
              Employee emp1 = new Employee("Bryon", "me@myemail.com", "fields");
              Manager man1 = new Manager("Teddy", "human@not_a_dog.com", "rawhide");

              uc.newUser(emp1);
              uc.newUser(man1);

              uc.saveUsers();


        }
    }
}