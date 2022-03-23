using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OOP_Assessment
{
    class Report
        //takes the values from the analyse class and displays them to console
    {
        public void reportValues(List<int> results)
        {
            Console.WriteLine("sentences " + results[0]);
            Console.WriteLine("Total Consonants " + results[2]);
            Console.WriteLine("Vowels " + results[1]);
            Console.WriteLine("Upper Case " + results[3]);
            Console.WriteLine("Lower Case " + results[4]);
            Console.WriteLine("Total Characters " + results[5]);

        }
    }
}
