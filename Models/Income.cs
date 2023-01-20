using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace TransactionManager.Models
{
    public class Income : Transactions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IncomeOrigin { get; set; }
        
        public Income() { }

        public decimal calculateMonthlyTotal(DateTime month)
        {
            decimal total = 0;
            foreach (var income in this.Where(i => i.Date.Month == month.Month && i.Date.Year == month.Year))
            {
                total += income.Amount;
            }
            return total;
        }
        public decimal calculateMonthlyTotal_v2(DateTime month)
        {
            decimal total = 0;
            foreach (var income in this)
            {
                if (income.Date.Month == month.Month && income.Date.Year == month.Year)
                {
                    total += income.Amount;
                }
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var income = new Income();
            // initialize income collection with test data
            var month = new DateTime(2022, 1, 1);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = income.calculateMonthlyTotal(month);
            stopwatch.Stop();
            var time1 = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            var result2 = income.calculateMonthlyTotal_v2(month);
            stopwatch.Stop();
            var time2 = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("calculateMonthlyTotal execution time: " + time1 + " ms");
            Console.WriteLine("calculateMonthlyTotal_v2 execution time: " + time2 + " ms");
            Console.ReadKey();
        }
    }
}
