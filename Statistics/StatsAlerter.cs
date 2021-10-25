using System.Collections.Generic;

namespace Statistics
{
    public class StatsAlerter
    {
        private float maxThreshold;
        private IAlerter[] alerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<double> numbers)
        {
            Stats stats = new Stats(numbers);

            if(stats.max > maxThreshold)
            {
                foreach (var alerter in alerters)
                {
                    alerter.Alert();
                }
            }

        }
    }
}