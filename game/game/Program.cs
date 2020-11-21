using System;
using System.Threading;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            static void PointDisplay(int points)
            {
                if (points >= 0)
                {
                    Console.WriteLine($"You have {points} points!");
                }
                else
                {
                    points = 0;
                    Console.WriteLine($"You have {points} points!");

                }
                Thread.Sleep(2000);
            }

            //var points = 0;
            var yes = true;
            var no = false;
            var userAnswer = 0;

            //Introduction
            while (yes)
            {

                Console.WriteLine("Welcome to the game");
                Thread.Sleep(500);
                Console.WriteLine("Please answer the questions and I will judge how good of a person you are.");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

                //Q.1
                do
                {
                    Console.WriteLine("You see a person getting mugged by a man with a knife. What do you do?");
                    Thread.Sleep(500);
                    Console.WriteLine("1) Join in and mug the woman too");
                    Console.WriteLine("2) Call the police");
                    Console.WriteLine("3) Attempt to stop the man");
                    Console.WriteLine("4) Run away and cry");
                    Console.WriteLine("Please choose one of the numbers.");
                    try
                    {
                        userAnswer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        userAnswer = 0;
                    }


                    // responses 
                        switch (userAnswer)
                        {
                            case 1:
                                Console.WriteLine("Very bad choice");
                                points -= 10;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Good choice");
                                points += 10;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("Ok choice");
                                points += 5;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine("Bad choice");
                                points -= 5;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Pick a number between 1-4!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                        }
                    // Point display
                } while (userAnswer > 4 || userAnswer < 1);

                PointDisplay(points);

                //Q.2
                do
                {
                    Console.WriteLine("You see a homeless person, What do you do?");
                    Thread.Sleep(500);
                    Console.WriteLine("1) Give him money");
                    Console.WriteLine("2) Punch him cause' you hate homeless people");
                    Console.WriteLine("3) Steal all the money he has gotten");
                    Console.WriteLine("4) Give him all your belongings");
                    Console.WriteLine("Please choose one of the numbers.");
                    try
                    {
                        userAnswer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        userAnswer = 0;
                    }


                    // responses 
                    switch (userAnswer)
                    {
                        case 1:
                            Console.WriteLine("Decent choice");
                            points += 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("very bad choice");
                            points -= 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("bad choice");
                            points -= 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("A bit weird but good choice");
                            points += 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Pick a number between 1-4!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                    }
                    // Point display
                } while (userAnswer > 4 || userAnswer < 1);

                PointDisplay(points);

                //Q.3
                do
                {
                    Console.WriteLine("You are in an arguement with you're teacher");
                    Thread.Sleep(500);
                    Console.WriteLine("1) Cuss him out");
                    Console.WriteLine("2) Talk out your issues");
                    Console.WriteLine("3) Laugh at him and walk out");
                    Console.WriteLine("4) Listen to his long complaint");
                    Console.WriteLine("Please choose one of the numbers.");
                    try
                    {
                        userAnswer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        userAnswer = 0;
                    }


                    // responses to Q.3
                    switch (userAnswer)
                    {
                        case 1:
                            Console.WriteLine("Very bad choice");
                            points -= 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Good choice");
                            points += 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("bad choice");
                            points -= 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Ok choice");
                            points += 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Pick a number between 1-4!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                    }

                } while (userAnswer > 4 || userAnswer < 1);
                // Displays players karma points (Pretty obvious innit)
                PointDisplay(points);

                //Q.4
                do
                {
                    Console.WriteLine("You see a baseball bat and an orphan, what do you do?");
                    Thread.Sleep(500);
                    Console.WriteLine("1) proceed to steal his bat");
                    Console.WriteLine("2) Play baseball with him");
                    Console.WriteLine("3) Laugh at him for being an orphan");
                    Console.WriteLine("4) Adopt him");
                    Console.WriteLine("Please choose one of the numbers.");
                    try
                    {
                        userAnswer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        userAnswer = 0;
                    }


                    // responses to Q.3
                    switch (userAnswer)
                    {
                        case 1:
                            Console.WriteLine("Very bad choice");
                            points -= 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Good choice");
                            points += 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("bad choice");
                            points -= 5;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Great choice");
                            points += 10;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Pick a number between 1-4!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                    }

                } while (userAnswer > 4 || userAnswer < 1);
                // Displays players karma points (Pretty obvious innit)
                PointDisplay(points);

                Console.Clear();

                if (points == 40)
                {
                    Console.WriteLine("You are too good of a person. You should get yourself checked out!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                if (points >= 20 && points < 40)
                {
                    Console.WriteLine("You are an ok person. Not the greatest tho!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                if (points < 20)
                {
                    Console.WriteLine("You are a horrible person. please check into an anger managment class!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                //-------------------------------------------------------------------------------------------


                var playAgainAnswer = "";

                //This loop doesnt work no clue why so the breaks are necessary
                do
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to play again? y/n");
                    playAgainAnswer = Console.ReadLine();

                    if (playAgainAnswer[0] == 'y' | playAgainAnswer[0] == 'n')
                    {
                        if (playAgainAnswer[0] == 'y')
                        {
                            yes = yes;
                            //playAgainAnswer = "x";
                            points = 0;
                            Console.Clear();
                            break;
                        }
                        if (playAgainAnswer[0] == 'n')
                        {
                            //playAgainAnswer = "x";
                            yes = no;
                            Console.WriteLine("Thanks for playing!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only use y or n!");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine(!playAgainAnswer[0].Equals('y'));
                    Thread.Sleep(1000);
                } while  (!playAgainAnswer[0].Equals('y') | !playAgainAnswer[0].Equals('n'));

                
                
            }

            
        }
    }
}
