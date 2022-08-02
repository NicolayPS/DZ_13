using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13
{
    class Building
    {
        string address;
        int lengthBilding;
        int widthBilding;
        int heightBilding;

        string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (address=="")
                    address = "Ошибка! Введите адрес!";
            }
        }
        int LengthBilding
        {
            get
            {
                return lengthBilding;
            }
            set
            {
                if (value > 0)
                    lengthBilding = 0;
            }
        }
        int WidthBilding
        {
            get
            {
                return widthBilding;
            }
            set
            {
                if (value > 0)
                    lengthBilding = 0;
            }
        }
        int HeightBilding
        {
            get
            {
                return heightBilding;
            }
            set
            {
                if (value > 0)
                    lengthBilding = 0;
            }
        }
        public Building(string address, int lengthBilding, int widthBilding, int heightBilding)
        {
            this.address = address;
            this.lengthBilding = lengthBilding;
            this.widthBilding = widthBilding;
            this.heightBilding = heightBilding;
        }
        public string Print()
        {
            return $"{address} {lengthBilding} {widthBilding} {heightBilding}";
        }
    }
}
