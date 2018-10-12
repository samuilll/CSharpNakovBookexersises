using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Utilities;

namespace Chapter_18_DictionariesHashTablesAndSets.Problem_11
{
    class Problem_11 : Problem
    {
        public override void Run()
        {
            Writer.WriteLine("I could not cope with this problem");
            HashSet<TimeInterval> set = new HashSet<TimeInterval>(new TimeIntervalComparer())
            {
                new TimeInterval
                    (
                    DateTime.ParseExact("08:24","hh:mm",CultureInfo.InvariantCulture),
                    DateTime.ParseExact("08:33","hh:mm",CultureInfo.InvariantCulture)
                    ),

                new TimeInterval
                (
                    DateTime.ParseExact("08:20","hh:mm",CultureInfo.InvariantCulture),
                    DateTime.ParseExact("09:00","hh:mm",CultureInfo.InvariantCulture)
                ),
                new TimeInterval
                (
                    DateTime.ParseExact("08:32","hh:mm",CultureInfo.InvariantCulture),
                    DateTime.ParseExact("08:37","hh:mm",CultureInfo.InvariantCulture)
                ),
                new TimeInterval
                (
                    DateTime.ParseExact("09:00","hh:mm",CultureInfo.InvariantCulture),
                    DateTime.ParseExact("09:15","hh:mm",CultureInfo.InvariantCulture)
                ),
                new TimeInterval
                (
                    DateTime.ParseExact("08:32","hh:mm",CultureInfo.InvariantCulture),
                    DateTime.ParseExact("08:37","hh:mm",CultureInfo.InvariantCulture)
                ),
            };

        }
    }
}
