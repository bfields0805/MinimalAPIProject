using ERS.DataControler;
using ERS.Model;

namespace ERS.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = File.ReadAllText("C:/Users/moros/Revature/221024-net/ConnectionStrings/P1.txt");
            Ticket t = new Ticket();
            SqlRepository repo = new SqlRepository(connectionString);

            IEnumerable<Ticket> tkts = new List<Ticket>();

            tkts = repo.getAllTickets();

            foreach (Ticket tkt in tkts)
            {
                Console.WriteLine(tkt);
            }


        }
    }
}
