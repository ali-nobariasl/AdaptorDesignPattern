using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    class Airplane : ITransport
    {
        public void Move()
        {
            Console.WriteLine("airplane moving type");
        }
    }
}
