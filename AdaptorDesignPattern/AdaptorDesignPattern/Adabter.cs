using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    public class Adabter : Transport
    {
        ITransport transport;
        public Adabter(DeEnum deEnum)
        {
            switch (deEnum)
            {
                case DeEnum.car:
                    transport = new Car();
                    break;
                case DeEnum.airplane:
                    transport = new Airplane();
                    break;
                case DeEnum.ship:
                    transport = new Ship();
                    break;
                default:
                    break;
            }
        }
        public override void Move()
        {
            if (transport == null) Console.WriteLine("object is null");
            transport.Move();
        }
    }
}
