using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class SportCar : Car
    {
        private int power;

        public int getPower()
        {
            return this.power;
        }

        public void printPrice()
        {

        }

        public void setPower(int power)
        {
            this.power = power;
        }
    }
}
