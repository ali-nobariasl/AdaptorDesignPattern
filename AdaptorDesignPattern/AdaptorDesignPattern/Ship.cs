using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    public class Ship : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Ship moving type");
        }
    }
}
