using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.Жукова д.35", 10000, 30000,30000);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("пр.Ленинский д.4", 20000, 20000, 20000,7);
            Console.WriteLine(multiBuilding.Print());

            Console.ReadKey();
        }
    }
}
