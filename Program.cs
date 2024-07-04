using System;

namespace rock_paper_scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerinput, cpuoutput;
            int randomint;
            
            bool tryagain = true;



            while (tryagain)
            {

                int scoreplayer = 0;
                int scorecpu = 0;

                while (scoreplayer < 3 && scorecpu < 3)
                {
                    Console.Write("Choose any one : ROCK, PAPER, SCISSOR:  ");
                    playerinput = Console.ReadLine();

                    Random rnd = new Random();
                    randomint = rnd.Next(1, 4);

                    switch (randomint)
                    {

                        case 1:
                            cpuoutput = "ROCK";
                            Console.WriteLine("Cpu Choose ROCK");
                            if (playerinput == "ROCK" || playerinput == "rock")
                            {
                                Console.WriteLine("DRAW");

                            }
                            else if (playerinput == "SCISSOR" || playerinput == "scissor")
                            {
                                Console.WriteLine("CPU wins");
                                scorecpu++;
                            }
                            else if (playerinput == "PAPER" || playerinput == "paper")
                            {
                                Console.WriteLine("Player wins");
                                scoreplayer++;
                            }

                            break;
                        case 2:
                            cpuoutput = "PAPER";
                            Console.WriteLine("Cpu Choose PAPER");
                            if (playerinput == "PAPER" || playerinput == "paper")
                            {
                                Console.WriteLine("DRAW");

                            }
                            else if (playerinput == "ROCK" || playerinput == "rock")
                            {
                                Console.WriteLine("CPU wins");
                                scorecpu++;
                            }
                            else if (playerinput == "SCISSOR" || playerinput == "scissor")
                            {
                                Console.WriteLine("Player wins");
                                scoreplayer++;
                            }

                            break;
                        case 3:
                            cpuoutput = "SCISSOR";
                            Console.WriteLine("Cpu Choose SCISSOR");
                            if (playerinput == "SCISSOR" || playerinput == "scissor")
                            {
                                Console.WriteLine("DRAW");

                            }
                            else if (playerinput == "PAPER" || playerinput == "paper")
                            {
                                Console.WriteLine("CPU wins");
                                scorecpu++;
                            }
                            else if (playerinput == "ROCK" || playerinput == "rock")
                            {
                                Console.WriteLine("Player wins");
                                scoreplayer++;
                            }

                            break;
                        default:
                            Console.WriteLine("Invalid Input TryAgain");
                            break;
                    }
                    Console.WriteLine("PLAYER SCORE :{0}\tCOMPUTER SCORE :{1}\n", scoreplayer, scorecpu);

                    

                }
                if (scoreplayer == 3)
                {
                    Console.WriteLine("\tPLAYER WON!!\t");
                }
                else if (scorecpu == 3)
                {
                    Console.WriteLine("\tCPU WON!!\t");
                }
                else
                {

                }
                Console.Write("Do you want to play again (y/n) : ");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    tryagain = true;
                    Console.Clear();
                   
                }
                else if(loop == "n")
                {
                    tryagain= false;
                    Console.Clear();
                   
                }
                else
                {

                }
            }
        }
    }
}