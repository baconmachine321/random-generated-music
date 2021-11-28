using System;
using System.Threading;
using System.Media;
using System.Linq;

namespace AI_GENERATED_MUSIC
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type 'play' to play some ai music :D");
            int BeatsPerSecond = 1; // subtract 2 zeros from this number and that will be how many BPS it is. (1000 BPS - 1 second) 

            string userinput = Console.ReadLine();

            if (userinput == "play")
            {

                while (true)
                {
                    Random myObject = new Random();
                    int ranNum = myObject.Next(0, 8);
                    Console.WriteLine("Note Called: " + ranNum);

                    if (ranNum == 0)
                    {
                        Thread.Sleep(500);
                    }

                    if (ranNum == 1)
                    {
                        Console.Beep(200, 400);
                    }

                    if (ranNum == 2)
                    {
                        Console.Beep(300, 400);
                    }

                    if (ranNum == 3)
                    {
                        Console.Beep(400, 400);
                    }

                    if (ranNum == 4)
                    {
                        Console.Beep(500, 400);
                    }

                    if (ranNum == 5)
                    {
                        Console.Beep(600, 400);
                    }

                    if (ranNum == 6)
                    {
                        Console.Beep(700, 400);
                    }

                    if (ranNum == 7)
                    {
                        Console.Beep(800, 400);
                    }

                    if (ranNum == 8)
                    {
                        Console.Beep(900, 400);
                    }
                    Thread.Sleep(BeatsPerSecond);
                }

            }
            if (userinput == "quit")
            {
                Environment.Exit(0);
            }

            Console.ReadLine();

        }

    }

}
