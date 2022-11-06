using System.Text;
using System.Xml.Serialization;


namespace Model
{
    [XmlInclude(typeof(User))]
    public class Manager : User
    {

        public Manager() : base(){}
        

       
        public Manager(string name, string email, string password) : base(name, email,password)
        {}

        //public void approveOrDeny(TicketStatus s)
        

    }
}