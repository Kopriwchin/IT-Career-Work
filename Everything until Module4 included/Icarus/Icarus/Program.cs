using System;
using System.Collections.Generic;
using System.Linq;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console
               .ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int startingPosition = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int initialDamage = 1;
            while (command != "Supernova")
            {
                string[] splitted = command.Split();
                string Direction = splitted[0];
                int steps = int.Parse(splitted[1]);

                if (Direction == "left")
                {
                    int counter = 0;

                    while (counter < steps)
                    {
                        if (startingPosition == 0)
                        {
                            startingPosition = sequence.Count - 1;
                            initialDamage++;
                            sequence[startingPosition] -= initialDamage;
                        }
                        else
                        {
                            sequence[startingPosition - 1] -= initialDamage;
                            startingPosition--;
                        }
                        counter++;
                    }
                }
                if (Direction == "right")
                {
                    int counter = 0;
                    while (counter < steps)
                    {
                        if (startingPosition == sequence.Count - 1)
                        {
                            startingPosition = 0;
                            initialDamage++;
                            sequence[startingPosition] -= initialDamage;
                        }
                        else
                        {
                            sequence[startingPosition + 1] -= initialDamage;
                            startingPosition++;
                        }
                        counter++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
