using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Junior1:IDeveloper
    {
        public void Code()
        {
            Console.WriteLine("Coding as a junior");
        }
    }
    public class Junior2:IAccountant
    {
        public void KeepRecords()
        {
            Console.WriteLine("Accounting as a junior");
        }
    }
    public class Junior3:IManager
    {
        public void Manage()
        {
            Console.WriteLine("Managing as a junior");
        }
    }
    public class Junior4:IWriter
    {
        public void Write()
        {
            Console.WriteLine("Writing as a junior");
        }
    }

}
