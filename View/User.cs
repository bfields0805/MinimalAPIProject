using System.IO;
using System.Xml.Serialization;
namespace Model
{
    public class User
    {
        [XmlAttribute]
        public string userName { get;  set; }
        public string password { get;  set; }
        public string email { get;  set; }
        public XmlSerializer Serializer { get; } = new XmlSerializer(typeof(List<User>));

        public User()
        { }

        public User(string name, string email, string password)
        {
            this.userName = name;
            this.email = email;
            this.password = password;
        }

        public void SerializeAsXml(List<User> users)
        {

            var newStringWriter = new StringWriter();
            Serializer.Serialize(newStringWriter, users);

            File.WriteAllText("./users.xml", newStringWriter.ToString());

            newStringWriter.Close();
        }
        public List<User> ReadFromXml()
        {
            StreamReader reader = new StreamReader("./xml");
            var Users = (List<User>?)Serializer.Deserialize(reader);
            reader.Close();

            return Users;
        }

        // public List<Ticket> viewTickets();

    }
}