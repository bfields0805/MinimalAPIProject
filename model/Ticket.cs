namespace Model
{
   public class Ticket
   {
      
      public string data {get; private set;}
      public double amount {get; private set;}
     public  Employee employee;

      protected TicketStatus status {get; private set;}

      public Ticket(Employee employee, double amount, string data)
      {
         this.employee = employee;
         this.amount= amount;
         this.data = data;
         status = Status.Pending;
      }

      public void approveOrDeny(Employee emp, TicketStatus status)
      {
         if(emp.isManager){
            this.status = status;
         }
      }


      public override string ToString()
      {
         StringBuilder sb = new StringBuilder("Created by: "+employee.name+" Amount: "+ amount+
         " Status: "+ status);

         return sb;
      }


   }
}