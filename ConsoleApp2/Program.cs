using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime.Parse("20---07");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }

    class A
    {

    }

    class B : A, IDate
    {
        public void Parse()
        {
            throw new NotImplementedException();
        }
    }

    interface IDate
    {
        void Parse();
    }
}
