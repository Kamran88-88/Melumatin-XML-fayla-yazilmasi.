using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));

            using (StreamReader streamReader = new StreamReader("Kamran.xml"))
            {
                users = xmlSerializer.Deserialize(streamReader) as List<User>;

                foreach (var item in users)
                {
                    Console.WriteLine(item.Name);
                }
            }


            string term = null;

            while (term != "ex")
            {
                User user = new User();
                Console.WriteLine("Name:");
                user.Name = Console.ReadLine();
                Console.WriteLine("Surname");
                user.Surname = Console.ReadLine();
                Console.WriteLine("Age");
                user.Age = Convert.ToInt32(Console.ReadLine());


                users.Add(user);
                Console.WriteLine("To continue press Enter. For Exit write 'ex'");
                term = Console.ReadLine();
                Console.Clear();

                if (term == "ex")
                {
                    term = "ex";
                }
            }



            using (StreamWriter streamWriter = new StreamWriter("Kamran.xml"))
            {
                xmlSerializer.Serialize(streamWriter, users);

            }


        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        [XmlIgnore]
        public int ID { get; set; }
    }
}