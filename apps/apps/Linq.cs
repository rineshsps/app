using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps
{
    class Linq
    {
        public Linq()
        {
            decimal[] numbers = { 101, 110, 55, 32, 300, 20 };

            //selecting number > 100
            dynamic result = numbers.Where(x => x > 100);
            
            // or 
            result = numbers.Where(x => x > 100)
                            .Select(x => x);

            //order by desc
            result = numbers
                            .OrderByDescending(x => x);
        }

    }
}
