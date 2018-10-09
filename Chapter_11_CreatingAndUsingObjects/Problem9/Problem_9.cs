using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Utilities;

namespace Chapter_11_CreatingAndUsingObjects.Problem9
{
    class Problem_9:Problem
    {

        public override void Run()
        {
            DatesManager manager = new DatesManager();

            string formattedDate = EnterTheDate();

            DateTime date = DateTime.ParseExact(formattedDate, Constants.Format, CultureInfo.InvariantCulture);

            int workingDays = CalculateWorkingDays(manager, date);

            PrintTheResult(formattedDate, workingDays);
        }

        private string EnterTheDate()
        {
            Writer.WriteLine($"Please insert a date in format \"{Constants.Format}\"");
            string formattedDate = this.Reader.ReadLine();
            return formattedDate;
        }

        private void PrintTheResult(string formattedDate, int workingDays)
        {
            Writer.WriteLine($"The count of working days till {formattedDate}  is:");
            Writer.WriteLine(workingDays);
        }

        private static int CalculateWorkingDays(DatesManager manager, DateTime date)
        {
            int workingDays = 0;

            for (DateTime day = DateTime.Now; DateTime.Compare(date, day) > 0; day = day.AddDays(1))
            {
                if (!manager.IsDayHoliday(day))
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}
