using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCreator
{
    class SweetnessBar : ISweetness
    {
        double Sugar { get; set; }

        void Eat()
        {
            Console.WriteLine("Eat SweetBar");
        }
    }
}
