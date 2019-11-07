using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema_5._1
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHourPerDay) : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDays = workHourPerDay;
        }
        public int WeekSalary { get; set; }
        public int WorkHoursPerDays { get; set; }

        public int MoneyPerHour()
        {

            int moneyEarn = WeekSalary / (WorkHoursPerDays * 5);

            return moneyEarn;
        }
        public static void SortByMoneyPerHourDescending(List<Worker> workers)
        {
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Workers sorted by money per hours in descending order:");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1}",worker.FirstName, worker.LastName);
            }
        }

        

    }
}
