using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Intern1 : IDeveloper
    {
        public void Code()
        {
            Console.WriteLine("Coding");
        }
    }
    public class Intern2 : IAccountant
    {
        public void KeepRecords()
        {
            Console.WriteLine("keeping records");
        }
    }
    public class Intern3 : IManager
    {
        public void Manage()
        {
            Console.WriteLine("Managing");
        }
    }
    public class Intern4 : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Writing");
        }
    }
}
