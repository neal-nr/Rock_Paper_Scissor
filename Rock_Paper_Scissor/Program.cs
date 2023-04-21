using System;

namespace Rock_Paper_Scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pcount = 0;
            int ccount = 0;
            Console.WriteLine("How many games would you like to play? ");
            int num = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                int cpu = rand.Next(1, 4);
                Console.WriteLine("\nEnter rock, paper or scissors: (1,2,3) ");
                int player = int.Parse(Console.ReadLine());

                if (player == 1 && cpu == 1 || player == 2 && cpu == 2 || player == 3 && cpu == 3)
                {
                    Console.WriteLine("DRAW");
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    Console.WriteLine("You chose: " + player_input(player));
                    pcount++;
                    ccount++;
                }
                else if (player == 1 && cpu == 2)
                {
                    Console.WriteLine("YOU LOSE");
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    Console.WriteLine("You chose: " + player_input(player));
                    ccount++;
                }
                else if (player == 2 && cpu == 1)
                {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    Console.WriteLine("You chose: " + player_input(player));
                    pcount++;
                }
                else if (player == 1 && cpu == 3)
                {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    Console.WriteLine("You chose: " + player_input(player));
                    pcount++;
                }
                else if (player == 3 && cpu == 1)
                {
                    Console.WriteLine("YOU LOSE");
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    Console.WriteLine("You chose: " + player_input(player));
                    ccount++;
                }
                else if (player == 3 && cpu == 2)
                {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("You chose: " + player_input(player));
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    ccount++;
                }
                else if (player == 2 && cpu == 3)
                {
                    Console.WriteLine("YOU LOSE");
                    Console.WriteLine("You chose: " + player_input(player));
                    Console.WriteLine("Computer chose: " + cpu_input(cpu));
                    pcount++;
                }
                else
                    Console.WriteLine("ERROR!");
            }
            Console.WriteLine("\nScore is {0}:{1}", pcount, ccount);
        }
        public static object cpu_input(int cpu)
        {
            string cpuinp = "";
            if (cpu == 1)
            { cpuinp = "Rock";  }
            else if (cpu == 2)
            { cpuinp = "Paper"; }
            else if (cpu == 3)
            { cpuinp = "Scissor"; }

            return cpuinp;
        }
        public static object player_input(int player)
        {
            string playerinp = "";
            if (player == 1)
            { playerinp = "Rock"; }
            else if (player == 2)
            { playerinp = "Paper"; }
            else if (player == 3)
            { playerinp = "Scissor"; }

            return playerinp;
        }
    }
}
