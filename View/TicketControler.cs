using Model;

namespace Controler
{
    public class TicketControler
    {
        public static List<Ticket> tickets {get; set;}= new List<Ticket>() ;
         Ticket ticket = new Ticket();

         public TicketControler()
         {
            loadTickets();
         }

         private void loadTickets(){
            tickets =ticket.ReadFromXml();
         }

        public TicketControler(Ticket ticket)
        {
             this.ticket = ticket;
            tickets = ticket.ReadFromXml();
        }

        public  void addNewTicket(Ticket ticket)
        {
           tickets.Add(ticket);
           saveTickets();
        }

        public void saveTickets ()
        {
           ticket.SerializeAsXml(tickets);
        }

        public List<Ticket> getAllTickets()
        {
            //tickets =ticket.ReadFromXml();

            return tickets;
        }

        public Ticket getTicketByID(int id)
        {
            Ticket ti = new Ticket();
            foreach(Ticket t in tickets)
            {
                if (t.id == id)
                {
                    ti = t;
                }
            }
            return ti;

        }
    }
}