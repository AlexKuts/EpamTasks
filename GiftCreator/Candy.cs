using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCreator
{
    class Candy : IGiftItem, ISweetness
    {
        public string Name { get; set; }

        public double Weight { get; set; }
        
        public double Sugar { get; set; }
        
        public void Eat()
        {
            Console.WriteLine("Eat candy");
        }

        
    }
}
