using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    public class Transport : ITransport
    {
        public virtual void Move()
        {
            Console.WriteLine("unknow moving type");
        }
    }
}
