using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// JSON FAYLINA MELUMATIN YAZILMASI VE OXUNMASI
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Kamran", Surname = "Alisoy", Age = 45 };

            var json = JsonConvert.SerializeObject(user);
            using (StreamWriter strwriter=new StreamWriter("FILE.json"))
            {
                strwriter.WriteLine(json);
            }

            using (StreamReader strReader=new StreamReader("FILE.json"))
            {
                var obj = JsonConvert.DeserializeObject(strReader.ReadToEnd());
            }


        }
    }

    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
    }
}
