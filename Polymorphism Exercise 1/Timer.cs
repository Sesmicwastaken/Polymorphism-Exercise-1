namespace Polymorphism_Exercise_1
{
    public class Timer
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private TimeSpan TimeTaken
        {
            get
            {
                return _endTime - _startTime;
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
            _startTime = DateTime.Now;
            return _startTime;
        }

        public DateTime End()
        {
            _endTime = DateTime.Now;

            return _endTime;
        }
    }
}