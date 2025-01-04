using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool projectAgain = true;

            string responseOfProjectAgain;

            string projectAgainMessage1 = ("Enter only string values please!");
            string projectAgainMessage2 = ("Something went wrong!");

            try
            {
                do
                {
                    while (projectAgain)
                    {
                        string start;
                        string error = ("Something went wrong!");

                        Console.WriteLine("Welcome to My First Project!");
                        Console.WriteLine("This Project Has A Lot Of Minigames!");
                        Console.WriteLine("Let's Get Started!");
                        Console.WriteLine("------------------");
                        Console.WriteLine();

                        Console.Write("Press E For Start: ");
                        start = Console.ReadLine();
                        Console.WriteLine();

                        if (start != "E")
                        {
                            Console.WriteLine($"Error: {error}");
                            Console.WriteLine("Please try again later!");
                            Environment.Exit(1);
                        }

                        Console.Write("Game Loading");
                        System.Threading.Thread.Sleep(1000);

                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);

                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);

                        Console.Write(". \n \n");
                        System.Threading.Thread.Sleep(1000);

                        string message1 = ("Enter only integer values please!");
                        string message2 = ("Enter only string values please!");
                        string message3 = ("Enter valid value please!");
                        string message4 = ("Thanks for playing!");

                        try
                        {
                            do
                            {
                                Console.WriteLine("Minigame 1");
                                Console.WriteLine("Number Guessing Game");
                                Console.WriteLine("--------------------");
                                Console.WriteLine();

                                Random random = new Random();

                                bool playAgain = true;

                                int min = 1;
                                int max = 100;

                                int guess;
                                int guesses;

                                int number;

                                string response;

                                while (playAgain)
                                {
                                    guess = 0;
                                    guesses = 0;

                                    number = random.Next(min, max + 1);

                                    response = "";

                                    while (guess != number)
                                    {
                                        Console.Write("Enter the number between " + min + "-" + max + ": ");
                                        guess = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Guess: " + guess);

                                        if (guess > number)
                                        {
                                            Console.WriteLine(guess + " is to high!");
                                            Console.WriteLine();
                                        }

                                        else if (guess < number)
                                        {
                                            Console.WriteLine(guess + " is to low!");
                                            Console.WriteLine();
                                        }

                                        guesses++;
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Number: " + number);
                                    Console.WriteLine("YOU WIN!");
                                    Console.WriteLine("Guesses: " + guesses);

                                    Console.Write("Would you like to play again? (Y/N): ");
                                    response = Console.ReadLine();

                                    if (response == "Y")
                                    {
                                        playAgain = true;
                                    }

                                    else if (response == "N")
                                    {
                                        playAgain = false;
                                    }

                                    else if (response == null || response == string.Empty || response != "Y" || response != "N")
                                    {
                                        playAgain = false;
                                    }
                                }
                            }

                            while (Console.ReadLine().ToUpper() == "Y");
                        }

                        catch (FormatException a)
                        {
                            Console.WriteLine($"Error: {message1}");
                            Environment.Exit(1);
                        }

                        catch (Exception a)
                        {
                            Console.WriteLine($"Error: {error}");
                            Environment.Exit(1);
                        }

                        finally
                        {
                            Console.WriteLine(message4);
                            Console.WriteLine();
                        }

                        try
                        {
                            do
                            {
                                Console.WriteLine("Minigame 2");
                                Console.WriteLine("Rock Paper Scissors Game");
                                Console.WriteLine("------------------------");
                                Console.WriteLine();

                                Random random = new Random();

                                bool playAgain = true;

                                string player;
                                string computer;

                                string response;

                                int randomNumber;

                                while (playAgain)
                                {
                                    player = "";
                                    computer = "";

                                    response = "";

                                    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                                    {
                                        Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                                        player = Console.ReadLine();
                                        player = player.ToUpper();
                                        Console.WriteLine();
                                    }

                                    randomNumber = random.Next(1, 4);

                                    switch (randomNumber)
                                    {
                                        case 1:
                                            computer = "ROCK";
                                            break;

                                        case 2:
                                            computer = "PAPER";
                                            break;

                                        case 3:
                                            computer = "SCISSORS";
                                            break;

                                        default:
                                            Console.WriteLine($"Error: {message3}");
                                            Environment.Exit(1);
                                            break;
                                    }

                                    Console.WriteLine("Player: " + player);
                                    Console.WriteLine("Computer: " + computer);

                                    switch (player)
                                    {
                                        case "ROCK":

                                            if (computer == "ROCK")
                                            {
                                                Console.WriteLine("It's a draw!");
                                            }

                                            else if (computer == "PAPER")
                                            {
                                                Console.WriteLine("You lose!");
                                            }

                                            else if (computer == "SCISSORS")
                                            {
                                                Console.WriteLine("You win!");
                                            }

                                            break;

                                        case "PAPER":

                                            if (computer == "ROCK")
                                            {
                                                Console.WriteLine("You win!");
                                            }

                                            else if (computer == "PAPER")
                                            {
                                                Console.WriteLine("It's a draw!");
                                            }

                                            else if (computer == "SCISSORS")
                                            {
                                                Console.WriteLine("You lose!");
                                            }

                                            break;

                                        case "SCISSORS":

                                            if (computer == "ROCK")
                                            {
                                                Console.WriteLine("You lose!");
                                            }

                                            else if (computer == "PAPER")
                                            {
                                                Console.WriteLine("You win!");
                                            }

                                            else if (computer == "SCISSORS")
                                            {
                                                Console.WriteLine("It's a draw!");
                                            }

                                            break;

                                        default:
                                            Console.WriteLine($"Error: {message3}");
                                            Environment.Exit(1);
                                            break;
                                    }

                                    Console.Write("Would you like to play again? (Y/N): ");
                                    response = Console.ReadLine();

                                    if (response == "Y")
                                    {
                                        playAgain = true;
                                    }

                                    else if (response == "N")
                                    {
                                        playAgain = false;
                                    }

                                    else if (response == null || response == string.Empty || response != "Y" || response != "N")
                                    {
                                        playAgain = false;
                                    }
                                }
                            }

                            while (Console.ReadLine().ToUpper() == "Y");
                        }

                        catch (FormatException a)
                        {
                            Console.WriteLine($"Error: {message2}");
                        }

                        catch (Exception a)
                        {
                            Console.WriteLine($"Error: {error}");
                        }

                        finally
                        {
                            Console.WriteLine(message4);
                            Console.WriteLine();
                        }

                        try
                        {
                            do
                            {
                                Console.WriteLine("Minigame 3");
                                Console.WriteLine("Simple Calculator Program");
                                Console.WriteLine("-------------------------");
                                Console.WriteLine();

                                bool playAgain = true;

                                double number1;
                                double number2;

                                double result;

                                int choice;

                                string response;

                                while (playAgain)
                                {
                                    response = "";

                                    Console.Write("Enter first number: ");
                                    number1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();

                                    Console.Write("Enter second number: ");
                                    number2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();

                                    Console.WriteLine("Enter your operator:");
                                    Console.WriteLine("--------------------");
                                    Console.WriteLine();

                                    Console.WriteLine("1-)Addition");
                                    Console.WriteLine("2-)Substraction");
                                    Console.WriteLine("3-)Multiplication");
                                    Console.WriteLine("4-)Division");
                                    Console.WriteLine("5-)Exit");

                                    Console.Write("Enter your choice: ");
                                    choice = int.Parse(Console.ReadLine());

                                    switch (choice)
                                    {
                                        case 1:
                                            result = number1 + number2;
                                            Console.WriteLine();
                                            Console.WriteLine($"Your result: {number1} + {number2} = {result}");
                                            break;

                                        case 2:
                                            result = number1 - number2;
                                            Console.WriteLine();
                                            Console.WriteLine($"Your result: {number1} - {number2} = {result}");
                                            break;

                                        case 3:
                                            result = number1 * number2;
                                            Console.WriteLine();
                                            Console.WriteLine($"Your result: {number1} * {number2} = {result}");
                                            break;

                                        case 4:
                                            result = number1 / number2;
                                            Console.WriteLine();
                                            Console.WriteLine($"Your result: {number1} / {number2} = {result}");
                                            break;

                                        case 5:
                                            Console.WriteLine();
                                            Console.WriteLine("See you later!");
                                            Environment.Exit(1);
                                            break;

                                        default:
                                            Console.WriteLine();
                                            Console.WriteLine($"Error: {error}");
                                            Environment.Exit(1);
                                            break;
                                    }

                                    Console.Write("Would you like to play again? (Y/N): ");
                                    response = Console.ReadLine();

                                    if (response == "Y")
                                    {
                                        playAgain = true;
                                    }

                                    else if (response == "N")
                                    {
                                        playAgain = false;
                                    }

                                    else if (response == null || response == string.Empty || response != "Y" || response != "N")
                                    {
                                        playAgain = false;
                                    }
                                }
                            }

                            while (Console.ReadLine().ToUpper() == "Y");
                        }

                        catch (FormatException a)
                        {
                            Console.WriteLine($"Error: {message1}");
                            Environment.Exit(1);
                        }

                        catch (Exception a)
                        {
                            Console.WriteLine($"Error: {error}");
                            Environment.Exit(1);
                        }

                        finally
                        {
                            Console.WriteLine(message4);
                            Console.WriteLine();
                        }

                        try
                        {
                            do
                            {
                                Random random = new Random();

                                bool playAgain = true;

                                while (playAgain)
                                {
                                    int playerHealth = 100;
                                    int computerHealth = 100;

                                    int playerAttack = 20;
                                    int computerAttack = 20;

                                    int healAmount = 10;

                                    int computerChoice;

                                    int choice;

                                    string response;

                                    response = "";

                                    Console.WriteLine("Minigame 4");
                                    Console.WriteLine("Simple Combat Game");
                                    Console.WriteLine("------------------");
                                    Console.WriteLine();

                                    while (playerHealth > 0 && computerHealth > 0)
                                    {
                                        Console.WriteLine("Player Turn");
                                        Console.WriteLine("-----------");
                                        Console.WriteLine();

                                        Console.WriteLine("Player Health: " + playerHealth);
                                        Console.WriteLine("Computer Health: " + computerHealth);
                                        Console.WriteLine("--------------------");
                                        Console.WriteLine();

                                        Console.WriteLine("Enter your selection");
                                        Console.WriteLine("--------------------");
                                        Console.WriteLine();

                                        Console.WriteLine("Press 1 for attack");
                                        Console.WriteLine("Press 2 for heal");
                                        Console.WriteLine("Press 3 for exit");

                                        Console.Write("Enter your choice: ");
                                        choice = int.Parse(Console.ReadLine());
                                        Console.WriteLine();

                                        if (choice == 1)
                                        {
                                            computerHealth -= playerAttack;
                                            Console.WriteLine("You attack the computer " + playerAttack + " damage!");
                                            Console.WriteLine();
                                        }

                                        else if (choice == 2)
                                        {
                                            if (playerHealth == 100 || (playerHealth > 90 && playerHealth < 100))
                                            {
                                                Console.WriteLine("You can't restore health while your health full!");
                                                playerHealth = 100;
                                                Console.WriteLine();
                                            }

                                            else
                                            {
                                                playerHealth += healAmount;
                                                Console.WriteLine("Player restores " + healAmount + " health point!");
                                                Console.WriteLine();
                                            }
                                        }

                                        else if (choice == 3)
                                        {
                                            Console.WriteLine("See you later!");
                                            Environment.Exit(1);
                                        }

                                        if (computerHealth > 0)
                                        {
                                            Console.WriteLine("Computer Turn");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine();

                                            computerChoice = random.Next(0, 2);

                                            if (computerChoice == 0)
                                            {
                                                playerHealth -= computerAttack;
                                                Console.WriteLine("The computer attacks you " + computerAttack + " damage!");
                                                Console.WriteLine();
                                            }

                                            else
                                            {
                                                if (computerHealth == 100 || (computerHealth > 90 && computerHealth < 100))
                                                {
                                                    computerHealth = 100;
                                                }

                                                else
                                                {
                                                    computerHealth += healAmount;
                                                    Console.WriteLine("The computer restores " + healAmount + " health point!");
                                                }
                                            }
                                        }
                                    }

                                    if (playerHealth <= 0)
                                    {
                                        Console.WriteLine("Game over. You lose!");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Congratulations. You win!");
                                    }

                                    Console.Write("Would you like to play again? (Y/N): ");
                                    response = Console.ReadLine();

                                    if (response == "Y")
                                    {
                                        playAgain = true;
                                    }

                                    else if (response == "N")
                                    {
                                        playAgain = false;
                                    }

                                    else if (response == null || response == string.Empty || response != "Y" || response != "N")
                                    {
                                        playAgain = false;
                                    }
                                }
                            }

                            while (Console.ReadLine().ToUpper() == "Y");
                        }

                        catch (FormatException a)
                        {
                            Console.WriteLine($"Error: {message1}");
                            Environment.Exit(1);
                        }

                        catch (Exception a)
                        {
                            Console.WriteLine($"Error: {error}");
                            Environment.Exit(1);
                        }

                        finally
                        {
                            Console.WriteLine(message4);
                            Console.WriteLine();
                        }

                        try
                        {
                            do
                            {
                                bool playAgain = true;

                                while (playAgain)
                                {
                                    float height;
                                    float width;

                                    float radius;

                                    double resultOfRectangle;
                                    double resultOfCircle;

                                    string answer;
                                    string response;

                                    Console.WriteLine("Minigame 5");
                                    Console.WriteLine("Shape Area Program");
                                    Console.WriteLine("------------------");
                                    Console.WriteLine();

                                    Console.WriteLine("What shape would you like find the area of ?");
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine();

                                    Console.WriteLine("Press R for rectangle");
                                    Console.WriteLine("Press C for circle");

                                    answer = Console.ReadLine();
                                    Console.WriteLine();

                                    if (answer == "R")
                                    {
                                        Console.Write("Enter height of rectangle: ");
                                        height = Convert.ToSingle(Console.ReadLine());
                                        Console.WriteLine();

                                        Console.Write("Enter width of rectangle: ");
                                        width = Convert.ToSingle(Console.ReadLine());
                                        Console.WriteLine();

                                        resultOfRectangle = width * height;

                                        Console.WriteLine($"Result: {resultOfRectangle}");
                                    }

                                    else if (answer == "C")
                                    {
                                        Console.Write("Enter radius of circle: ");
                                        radius = Convert.ToSingle(Console.ReadLine());

                                        resultOfCircle = (float)Math.PI * (radius * radius);

                                        Console.WriteLine($"Result: {resultOfCircle}");
                                    }

                                    Console.WriteLine("Would you like to play again? (Y/N):");
                                    response = Console.ReadLine();

                                    if (response == "Y")
                                    {
                                        playAgain = true;
                                    }

                                    else if (response == "N")
                                    {
                                        playAgain = false;
                                    }

                                    else if (response == null || response == string.Empty || response != "Y" || response != "N")
                                    {
                                        playAgain = false;
                                    }
                                }
                            }

                            while (Console.ReadLine().ToUpper() == "Y");
                        }

                        catch (FormatException a)
                        {
                            Console.WriteLine($"Error: {message3}");
                            Environment.Exit(1);
                        }

                        catch (Exception a)
                        {
                            Console.WriteLine($"Error: {error}");
                            Environment.Exit(1);
                        }

                        finally
                        {
                            Console.WriteLine(message4);
                            Console.WriteLine();
                        }

                        Console.WriteLine("That was all!");
                        Console.WriteLine("If you liked this project I would be very happy!");

                        Console.Write("Would you like to play again the project? (Y/N): ");
                        responseOfProjectAgain = Console.ReadLine();

                        if (responseOfProjectAgain == "Y")
                        {
                            projectAgain = true;
                        }

                        else if (responseOfProjectAgain == "N")
                        {
                            projectAgain = false;
                        }

                        else if (responseOfProjectAgain == null || responseOfProjectAgain == string.Empty || responseOfProjectAgain != "Y" || responseOfProjectAgain != "N")
                        {
                            projectAgain = false;
                        }
                    }
                }

                while (Console.ReadLine().ToUpper() == "Y");
            }

            catch (FormatException a)
            {
                Console.WriteLine($"Error: {projectAgainMessage1}");
                Environment.Exit(1);
            }

            catch (Exception a)
            {
                Console.WriteLine($"Error: {projectAgainMessage2}");
                Environment.Exit(1);
            }

            Console.ReadKey();
        }
    }
}
