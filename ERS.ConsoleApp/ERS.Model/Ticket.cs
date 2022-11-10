



namespace ERS.Model
{

    public class Ticket
    {
       
       
        public int id { get; set; }
        public string data { get; set; }
        public double amount { get; set; }
        public string employee { get; set; }

        public TicketStatus status { get; set; }

     

        

        public Ticket() { }

        public Ticket(string employee, double amount, string data, int status)
        {
            this.employee = employee;
            this.amount = amount;
            this.data = data;
            this.status = (TicketStatus) status;
            
           
        }


        public void changeStatus( TicketStatus s)
        {
            
            status = s;
        }






        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("ID: "+id+" Created by: " + employee + " Amount: " + amount +
             "For: "+ data+"Status: " + status);

            return sb.ToString();
        }


    }
}