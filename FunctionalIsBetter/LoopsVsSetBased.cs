using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalIsBetter
{
    class LoopsVsSetBased
    {

        public List<int> TimesTwoBySet(List<int> theNumbers)
        {
            return theNumbers.Select(x => x*2).ToList();
        }

        public List<int> TimesTwoByForeach(List<int> theNumbers)
        {
            var timesTwoList = new List<int>();
            foreach (var number in theNumbers)
            {
                timesTwoList.Add(number * 2);
            }
            return timesTwoList;
        }

        public List<int> TimesTwoByFor(List<int> theNumbers)
        {
            var timesTwoList = new List<int>();
            for (var i = 0; i < theNumbers.Count ; i++)
            {
                var number = theNumbers[i];
                timesTwoList.Add(number * 2);
            }
            return timesTwoList;
        }
    }
}
