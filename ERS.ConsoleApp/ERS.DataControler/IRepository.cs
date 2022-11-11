using ERS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS.DataControler
{
    internal interface IRepository
    {
        public IEnumerable<Ticket> getAllTickets();
        public IEnumerable<Ticket> GetMyTickets(int id);
        public Ticket GetTicketById(int id);
        public void AddNewTicket(Ticket t, int Id);


        public IEnumerable<User> GetAllUsers();
        public User GetUserById(int id);
        public User CreateNewUser(User u);




    }
}
