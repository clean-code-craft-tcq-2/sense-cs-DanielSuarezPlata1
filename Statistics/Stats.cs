using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {

        public double average;
        public double max;
        public double min;

        public Stats(List<double> numbers)
        {
            average = CalculateAverage(numbers);
            max = GetMax(numbers);
            min = GetMin(numbers);
        }

        public double CalculateAverage(List<double> numbers)
        {
            if (numbers.Count == 0)
                return double.NaN;

            double sum = 0.0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

            }

            double avg = sum / numbers.Count;
    
            return avg;
        }

        public double GetMax(List<double> numbers)
        {
            if (numbers.Count == 0)
                return double.NaN;

            double max = numbers.Max(x => x);

            return max;
        }

        public double GetMin(List<double> numbers)
        {
            if (numbers.Count == 0)
                return double.NaN;

            double min = numbers.Min(x => x);

            return min;
        }


    }
}