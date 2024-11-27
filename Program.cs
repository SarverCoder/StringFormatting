using System.Text;
using System.Text.RegularExpressions;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Expence.txt";
            StringBuilder sb = new StringBuilder($" --------------------------------------\n" +
                                                 $"| {"Expense",-10} | {"Amount",-10} | {"Date",-10} |\n" +
                                                 $" --------------------------------------\n");

            //Console.WriteLine(sb);
            
            while (true)
            {
                Console.Write("Expense name: ");
                string exp = Console.ReadLine();

                Console.Write("Amount: ");
                double amount;
                bool checkAmount = double.TryParse(Console.ReadLine(), out amount);

                if (!checkAmount)
                {
                    Console.Write("Qayta kiriting: ");
                    checkAmount = double.TryParse(Console.ReadLine(), out amount);
                }

                Console.Write("Data exp (12:34): ");
                TimeSpan time;
                bool checkTime = TimeSpan.TryParse(Console.ReadLine(),out time);

                if (!checkTime)
                {
                    Console.Write("Vaqtni qayta kiriting: ");
                    checkTime = TimeSpan.TryParse(Console.ReadLine(), out time);
                }

                Console.Write("\n\nHit enter to add expense... ");
                string Stop = Console.ReadLine();
                Console.WriteLine("\n\n");

                if (string.IsNullOrEmpty(Stop))
                {
                    sb.AppendFormat($"| {exp,-10} | {amount,-10} | {time,-10} |\n");
                    sb.AppendFormat($" --------------------------------------\n");
                }
                if (Regex.IsMatch(Stop, "stop",  RegexOptions.IgnoreCase))
                {
                    break;
                }
                //if (Console.ReadKey().KeyChar == )
            }
            
            try
            {
                File.WriteAllText(path, sb.ToString());
                Console.WriteLine("Filega yozib qoyildi....");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void ExpenseTracker(string expense, double amount, DateTime time)
        {

        }
    }
}
