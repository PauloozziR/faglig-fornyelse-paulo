/* using System; */

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /* THE MYSTERIOUS NOISE */
            
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string firstChoice = Console.ReadLine().ToUpper();

            if (firstChoice == "NO")
            {
                /* Console.WriteLine("You are too scared to check out the noise and cower in fear under the bedsheets all night. THE END!"); */
                Console.WriteLine("You decide adventure can wait another day ignoring the noise and instead invite the ghost thats been haunting your room to a game of rock paper scissors.");
                Console.Write("Select an option by typing ROCK, PAPER or SCISSORS: ");
                string rpsChoice = Console.ReadLine().ToUpper();
                string[] options = { "ROCK", "PAPER", "SCISSORS"};
                int ghostChoice = new Random().Next(0, 3); // det lave tal er inklusivt mens det høje tal er ekslusivt så denne linje rammer 0-2
                string ghostChoiceString = options[ghostChoice];
                Console.WriteLine($"You selected {rpsChoice}. The ghost selected {ghostChoiceString}.");

                if (rpsChoice == ghostChoiceString)
                {
                    Console.WriteLine("Its a tie!");
                }
                else if (rpsChoice == "ROCK" && ghostChoiceString == "SCISSORS")
                {
                    Console.WriteLine("You win!");
                }
                else if (rpsChoice == "PAPER" && ghostChoiceString == "ROCK")
                {
                    Console.WriteLine("You win!");
                }
                else if (rpsChoice == "SCISSORS" && ghostChoiceString == "PAPER")
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
            }
            else if (firstChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.Write("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine().ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says,");
                    Console.WriteLine("\"Answer this riddle: \"");
                    Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it, you die. What is it?\"");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door");
                        Console.WriteLine("THE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END.");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens with a chilling creek but NOTHING is there. Strange...");
                            Console.WriteLine("THE END.");
                            break;

                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;

                        case "3":
                            /* Console.WriteLine("You choose the third key. The door opens to a dark room! Your curiosity takes over but the moment you step inside the door slams behind you! Startled heart pounding as you desperately search for the lightswitch in the darkness, the light suddenly turns on revealing an old hooded lady.");
                            Console.WriteLine("The lady speaks with a haunting cackle \"You must win in a game of rock paper scissors to earn your freedom... \"");
                            Console.Write("Select an option ROCK, PAPER or SCISSORS: ");
                            string rpsChoice = Console.ReadLine();
                            int witchSelection = new Random().Next(0, 3);

                            if ()
                            {
                                
                            } */
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                    }
                }
            }
        }
    }
}
