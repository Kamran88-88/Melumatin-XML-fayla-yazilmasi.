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



        }
    }

    abstract class Base
    {
        public virtual void func()
        {
           
        }

        public virtual int func2(int a)
        {
            return a;
        }
    }

    class User:Base
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
    }
}
