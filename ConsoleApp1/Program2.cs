using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Old;
        public int Salary;
        public int Tax;
    }
    internal class Program2
    {
        User user1 = new User();

        user1.Id = 1;
        user1.FirstName = "John";
        user1.LastName = "Doe";
        user1.Old = 30;
        user1.Salary = 50000;
        user1.Tax = 20;
    }
}
