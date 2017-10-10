using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps
{
    class Charater
    {
        public Charater()
        {
            Console.WriteLine("------- Charaters -----------");
            string texts = "AB01-$%_0";
            char[] text = texts.ToArray(); // conver to char array 
            foreach (char item in text)
            {
                bool isNumber = char.IsNumber(item); // check is number
                var isLetter = char.IsLetter(item); // check is letter
                if (isNumber)
                {
                    Console.WriteLine($"this is number  : {item}"); //AB
                }
                else if (isLetter)
                    Console.WriteLine($"this is letter  : {item}"); //010
                else
                    Console.WriteLine($"this is  {item.GetType()} : {item}"); // -$%_
            }
        }

    }
}