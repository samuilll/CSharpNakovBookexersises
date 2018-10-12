using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_18_DictionariesHashTablesAndSets.Problem_11
{
    class TimeInterval : IComparable<TimeInterval>, IEqualityComparer<TimeInterval>
    {
        public TimeInterval(DateTime arrivingTime, DateTime departureTime)
        {
            ArrivalTime = arrivingTime;
            DepartureTime = departureTime;
        }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public int CompareTo(TimeInterval other)
        {
            if (this.Equals(this, other)) return 0;
            var arrivalTimeComparison = ArrivalTime.CompareTo(other.ArrivalTime);
            if (arrivalTimeComparison != 0) return arrivalTimeComparison;
            return DepartureTime.CompareTo(other.DepartureTime);
        }

        public bool Equals(TimeInterval x, TimeInterval y)
        {
            int arrivalComparison = DateTime.Compare(x.ArrivalTime, y.ArrivalTime);
            int departureComparison = DateTime.Compare(x.DepartureTime, y.DepartureTime);

            bool result = arrivalComparison == 0
                          && departureComparison == 0;

            return result;
        }

        public int GetHashCode(TimeInterval time)
        {
            return 0;
        }
    }
}