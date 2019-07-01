using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        protected string model;

        public string GetModel()
        {
            return this.model;
        }

        public void printPrice()
        {
            
        }

        public void setModel(string model)
        {
            this.model = model;
        }
    }
}
