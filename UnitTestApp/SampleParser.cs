using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public class SampleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
            }
        }

        public string NoRepeat(string target, char ch)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != ch)
                    result.Append(target[i]);
            }
            return result.ToString();
        }
    }
}
