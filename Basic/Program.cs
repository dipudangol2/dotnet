using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            //Calendar using jagged arrays(For 2024)
            int[][] months = new int[12][]; // 12 months
            months[0] = new int[31]; // January
            months[1] = new int[29]; // February (leap year)
            months[2] = new int[31]; // March
            months[3] = new int[30]; // April
            months[4] = new int[31]; // May
            months[5] = new int[30]; // June
            months[6] = new int[31]; // July
            months[7] = new int[31]; // August
            months[8] = new int[30]; // September
            months[9] = new int[31]; // October
            months[10] = new int[30]; // November
            months[11] = new int[31]; // December

            for (int i = 0; i < months.Length; i++)
            {
                for (int j = 0; j < months[i].Length; j++)
                {
                    months[i][j] = j + 1;
                }
            }

            //Dictionary to map months with index
            Dictionary<int, string> mapMonths = new Dictionary<int, string>()
            {
                {0,"January" },
                {1,"February" },
                {2,"March" },
                {3,"April" },
                {4,"May" },
                {5,"June" },
                {6,"July" },
                {7,"August" },
                {8,"September" },
                {9,"October" },
                {10,"November" },
                {11,"December" },
            };
            //Dictionary to map days with index
            Dictionary<int, string> mapDays = new Dictionary<int, string>()
            {
                {0, "Sunday"},
                {1, "Monday"},
                {2, "Tuesday"},
                {3, "Wednesday"},
                {4, "Thursday"},
                {5, "Friday"},
                {6, "Saturday"}
            };

            //Dictionary to store starting days for each month
            Dictionary<string, int> startingDays = new Dictionary<string, int>()
            {
            { "January", 1 },  // Monday
            { "February", 4 }, // Thursday
            { "March", 5 },    // Friday
            { "April", 1 },    // Monday
            { "May", 3 },      // Wednesday
            { "June", 6 },     // Saturday
            { "July", 1 },     // Monday
            { "August", 4 },   // Thursday
            { "September", 0 },// Sunday
            { "October", 2 },  // Tuesday
            { "November", 5 }, // Friday
            { "December", 0 }  // Sunday
            };

            for (int i = 0; i < months.Length; i++)
            {
                //Print the month name
                Console.WriteLine($"\n{mapMonths[i]}");
                for (int j = 0; j < 7; j++)
                {
                    //Print the day names
                    Console.Write($"{mapDays[j],-12}");
                }
                Console.WriteLine();
                //Get start day for month
                int startDay = startingDays[mapMonths[i]];
                for (int j = 0; j < startDay; j++)
                {
                    //fill the days up to starting days with gaps
                    Console.Write($"{" ",-12}");
                }

                for (int k = 0; k < months[i].Length; k++)
                {
                    //Print the days
                    Console.Write($"{months[i][k],-12}");
                    if ((k + startDay + 1) % 7 == 0)
                    {
                        //Make sure the line breaks on each saturday(index 6)
                        Console.WriteLine();
                    }
                }


            }



            Console.ReadLine();
        }
    }
}
