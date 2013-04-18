using System;
using System.Linq;

namespace StringCalcKata.Console
{
    public class StringCalculator
    {
        public int Add(string delimitedNumbers)
        {
            if (String.IsNullOrEmpty(delimitedNumbers)) {
                return 0;
            }

            var delimiters = new char[] {',', '\n'};
            var positionOfDelimiter = delimitedNumbers.IndexOfAny(delimiters);
            if (positionOfDelimiter < 0) {
                return int.Parse(delimitedNumbers);
            }

            var delimiterUsed = delimitedNumbers.ToArray()[positionOfDelimiter];
            var numbers = delimitedNumbers.Split(delimiterUsed);
            return numbers.Aggregate(0, (current, number) => current + int.Parse(number));
        }
    }
}
