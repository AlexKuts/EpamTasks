using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            Gift gf = new Gift();

            gf.Add(new Candy() { 
            
            Name="qweqwe",
            Weight=2.4,
            Sugar=3.5,
            
            });    
                

            Console.ReadLine();
        
        }
    }
}
