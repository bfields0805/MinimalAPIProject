using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace Model
{

    public class Ticket
    {
        public static int nextID = 1;
        [XmlAttribute]
        public int id { get; set; } = 1;
        public string data { get; set; }
        public double amount { get; set; }
        public string employee { get; set; }

        public TicketStatus status { get; set; }

        public string changedBy { get; set; }

        public XmlSerializer Serializer { get; } = new XmlSerializer(typeof(List<Ticket>));

        public Ticket() { }

        public Ticket(string employee, double amount, string data)
        {
            this.employee = employee;
            this.amount = amount;
            this.data = data;
            this.status = TicketStatus.Pending;
            changedBy = "N/A";
            id = ++nextID;
        }

        public void SerializeAsXml(List<Ticket> tickets)
        {

            var newStringWriter = new StringWriter();
            Serializer.Serialize(newStringWriter, tickets);

            File.WriteAllText("./tickets.xml", newStringWriter.ToString());

            newStringWriter.Close();
        }
        public List<Ticket> ReadFromXml()
        {
            StreamReader reader = new StreamReader("./tickets.xml");
            var Tickets = (List<Ticket>?)Serializer.Deserialize(reader);
            reader.Close();

            return Tickets;
        }

        public void changeStatus(User m, TicketStatus s)
        {
            changedBy = m.userName;
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