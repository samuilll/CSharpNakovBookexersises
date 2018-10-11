using System;
using System.Globalization;
using System.Linq;

namespace Chapter_11_CreatingAndUsingObjects.Problem9
{
    class DatesManager
    {
        private DateTime[] holidays;
        private DateTime[] workingSaturdays;

        public DatesManager()
        {
            this.holidays = InitializeHolidays();
            this.workingSaturdays = InitializeWorkingSaturdays();
        }

        public bool IsDayHoliday(DateTime date)
        {
            if (date.DayOfWeek==DayOfWeek.Sunday)
            {
                return true;
            }

            if (date.DayOfWeek==DayOfWeek.Saturday)
            {
                bool isWorkingSaturday = this.workingSaturdays.Any(ws => ws.Day==date.Day&& ws.Month==date.Month&&ws.Year==date.Year);

                if (isWorkingSaturday)
                {
                    return false;
                }

                return true;
            }

            if (holidays.Any(h=>h.Day==date.Day && h.Month==date.Month))
            {
                return true;
            }

            return false;
        }

        private DateTime[] InitializeHolidays()
        {
            DateTime[] holidays = new DateTime[]
            {
                DateTime.ParseExact($"06-05-{Constants.HelpYear}", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"01-05-{Constants.HelpYear}", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"25-12-{Constants.HelpYear}", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"03-03-{Constants.HelpYear}", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"25-09-{Constants.HelpYear}", Constants.Format,CultureInfo.InvariantCulture),
            };

            return holidays;
        }

        private DateTime[] InitializeWorkingSaturdays()
        {
            DateTime[] workingSaturdays = new DateTime[]
            {
                DateTime.ParseExact($"24-11-2018", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"23-02-2019", Constants.Format,CultureInfo.InvariantCulture),
                DateTime.ParseExact($"26-01-2020", Constants.Format,CultureInfo.InvariantCulture),
            };

            return workingSaturdays;
        }
    }
}
