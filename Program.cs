using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 5 && scoreCPU < 5) ;
                {



                    Console.Write("Choose  Rock, Paper or the Scissors:  ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 3);
                }
                switch (randomInt)
                {
                }
                {
                case1:
                    inputCPU = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    if (inputPlayer == "Rock") ;

                    Console.WriteLine("Tie!!\n\n");

                    
                        else if (inputPlayer == "Paper")
                }
                    Console.Write("Player won\n\n");
                    scorePlayer++;

                    {
                        else if (inputPlayer == "scissors")
                    } 
                Console.Write("CPU Won that one\n\n");

                break;

                
            {

            case2:
                inputCPU = "Paper";
                Console.Write("Computer chose Paper");
                if (inputPlayer == "paper")

                    Console.WriteLine("It is A Tie!!\n\n");

                else if (inputPlayer == "Rock")

                    break;
            } 
                { 
                case3:
                    inputCPU = "Scissors";
                    Console.WriteLine("Computer chose scissors");
                    if (inputPlayer == "Scissors")
                    {
                        Console.Write("Tie!\n\n");
                    }
                    else if (inputPlayer == "Rock")
                    {
                        Console.Write("Player won\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.Write("Cpu won!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("Player Won\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("sad to say CPU beat ya!!\n\n");
                        scoreCPU++;
                    }
                    break;
                }



            {
                Console.WriteLine("\n\nScores:\tPlayer:{0} ");
                break;


                if (scorePlayer == 5)
               
                    Console.WriteLine("Player wins");




                Console.WriteLine("CPU wins you lose!!!");


                
                        else

                        Console.WriteLine("Do you wanna play again?(y/n)");
                    string loop = Console.ReadLine();
                    if (loop = "y") ;
            }
            {
                playAgain = true;
            



                    
                    else if (loop = "n") ;
                    

                    playAgain = false;
                
            }
        }
    }
}