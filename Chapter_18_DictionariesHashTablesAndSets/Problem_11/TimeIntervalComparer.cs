using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_18_DictionariesHashTablesAndSets.Problem_11
{
    class TimeIntervalComparer:IEqualityComparer<TimeInterval>
    {
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
