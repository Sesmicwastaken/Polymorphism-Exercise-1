namespace Polymorphism_Exercise_1
{
    public class TimeValidation
    {
        private TimeSpan TimeTaken
        {
            get
            {
                DateTime start = Start();
                DateTime end = End();
                TimeSpan time = end - start;
                return time;
            }
        }

        public bool TimedOut { get; private set; }

        public void IsValid()
        {
            if (TimeTaken >= DbConnection.TimeOut)
            {
                TimedOut = true;
            }
        }

        public DateTime Start()
        {
            DateTime StartTime = DateTime.Now;
            return StartTime;
        }

        public DateTime End()
        {
            DateTime EndTime = DateTime.Now;
            return EndTime;
        }
    }
}