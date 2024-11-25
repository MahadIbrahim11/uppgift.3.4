using System;
namespace inl_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int hourlyRate = 80;
            const int maxDailyRate = 950;

            Console.WriteLine("hur mänga timmer vill du hyra bilen? (max 24 timmar): ");
            int hours;

            if (int.TryParse(Console.ReadLine(), out hours) && hours > 0 && hours <= 24)
            {
                int totalcost = hours * hourlyRate;
                if (totalcost > maxDailyRate)
                {
                    totalcost = maxDailyRate;
                }

                Console.WriteLine($"konstnaden för att hyra bilen i {hours} timmar är {totalcost}.");

            }
            else
            {

                Console.WriteLine("ange ett giltigt antal timmar mellan 1 och 24. ");
            }
        }
    }
}