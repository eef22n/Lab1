using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Linq
    {
        public List<int> input { get; set; }

        public Linq(List<int> input)
        {
            this.input = input;
        }

        public void CalculateAverage()
        {
          
     
           double avg = input.Where(n => n >= 5 && n <= 15).DefaultIfEmpty().Average();

            Console.WriteLine("Середнє значення:" + avg);
            
        
        
        }




    }

}
