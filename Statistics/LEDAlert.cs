namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows { get; set; }

        public void Alert()
        {
            ledGlows = true;
        }
    }
}