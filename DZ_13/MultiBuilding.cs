using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13
{
    sealed class MultiBuilding:Building
    {
        int floor;
        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 0)
                    floor = 0;
                else if (floor > 100)
                    floor = 100;
            }
        }
        public MultiBuilding(string address, int lengthBilding, int widthBilding, int heightBilding, int floor)
            : base(address, lengthBilding, widthBilding, heightBilding)
        {
            this.floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {floor}";
            return result;
        }
    }
}
