using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes;

        protected Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public DateTime GetDate() => _date;
        public int GetLengthMinutes() => _lengthMinutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {GetType().Name} " +
                   $"({GetLengthMinutes()} min) - " +
                   $"Distance: {GetDistance():0.0} km, " +
                   $"Speed: {GetSpeed():0.0} kph, " +
                   $"Pace: {GetPace():0.0} min per km";
        }
    }
}
