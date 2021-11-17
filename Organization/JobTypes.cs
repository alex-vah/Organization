using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public interface IDeveloper
    {
        void Code();
    }
    public interface IAccountant
    {
        void KeepRecords();
    }
    public interface IManager
    {
        void Manage();
    }
    public interface IWriter
    {
        void Write();
    }
}
