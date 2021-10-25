using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {

        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here

            Stats stats = new Stats(numbers);

            return stats;
        }

    }
}
