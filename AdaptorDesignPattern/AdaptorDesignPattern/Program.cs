using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Transport transport = new Transport();
                Adabter car = new Adabter(DeEnum.car);
                Adabter ship = new Adabter(DeEnum.ship);
                transport.Move();
                car.Move();
                ship.Move();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
