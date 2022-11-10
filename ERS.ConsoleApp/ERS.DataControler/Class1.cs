using ERS.Model;
using System.Data.SqlClient;

namespace ERS.DataControler
{
    public class SqlRepository
    {
        readonly string _connectionString;
        public SqlRepository(string connection) 
        {
            this._connectionString = connection ??
                        throw new ArgumentNullException(nameof(connection));
        
        }

        public IEnumerable<Ticket> getAllTickets()
        {
            List<Ticket> result = new List<Ticket>();

            using SqlConnection connection = new SqlConnection(this._connectionString);
            using SqlCommand cmd = new SqlCommand("SELECT Ticket_ID, About_Data, Amount"

            return result;
        }

    }
}