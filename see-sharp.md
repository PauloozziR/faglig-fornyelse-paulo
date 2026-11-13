c# (udtales C Sharp) er et case sensitivt objektorienteret programmeringssprog

Som bliver brugt til en masse forskelligt f.eks interactive websites, desktop app, mobil apps og spil

f.eks bruges c# sammen med blazor som er et open source webframework og html/css til at lave interaktive hjemmesider eller unity til at lave spil

i c# skriver man variabler med deres type foran som f.eks 
string variabelMedTekst = "Test tekst"; 
man kan stadig lave konstante variabler ved at sætte const foran data typen 
const string variabelMedTekst = "Test tekst";
hvis du ville lave en variabel med et array i c# sætter man [] efter typen og {} rundt om den value du giver variablen som f.eks
string[] variabelMedTekst = {"Test tekst 1", "Test tekst 2", "Test tekst 3"};



Tutorial til et choose your own adventure og et rock paper scissors mini game

i dette eksempel laver vi en console app
For at starte dit c# projekt installere vi en extensions med navnet C# Dev Kit og derefter kan vi starte et nyt projekt som console app(.NET Core) eller hvis vi har en projekt mappe klar kan vi skrive i konsollen:
dotnet new console -o (projekt navn eller . hvis mappen er åben i vs code)

inde i program.cs bruger vi namespace som sætter scope og hjælper med at organisere
linjen under class program er en metode
static betyder metoden hører til selve class Program og ikke et specifikt objekt inde i klassen
void betyder at metoden ikke har en return value
fjern hello world linjen og indsæt koden under

    namespace ChooseYourOwnAdventure
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Clear();
                    
                Console.Write("What is your name?: ");
                string playerName = Console.ReadLine();
                Console.WriteLine($"Hello, {playerName}! Welcome to ourstory.");

                Console.WriteLine("It begins on a cold rainy night.You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
                Console.Write("Type YES or NO: ");
                string firstChoice = Console.ReadLine().ToUpper();
            }
        }
    }

her bruger vi Console.Write/WriteLine til at printe til konsollen
og Console.ReadLine til at indlæse spillerens svar
i ReadLine sætter vi ToUpper for at ændre svaret til store bogstaver så i dette tilfælde acceptere det stadig acceptere svaret hvis brugeren skriver yes/no med småt

derefter skriver vi en if statement under den sidste kode hvor hvis der svares NO starter vi rock paper scissor mini game i et while loop for at brugeren efter kan sige ja til at spille igen
vi oprætter nogle variabler som vi kan bruge og give value senere inde i loopet
vi laver et andet while loop i starten for at ignorere hvis brugeren skriver noget andet en de options vi sætter

    if (firstChoice == "NO")
    {
        Console.WriteLine("You decide adventure can waanother day ignoring the noise and instead invite the ghost thats been haunting your room to a game rock paper scissors.");
        Random random = new Random();
        bool playAgain = true;
        string playerChoice;
        string ghostChoice;
        while (playAgain)
        {
            playerChoice = "";
            ghostChoice = "";
            while (playerChoice != "ROCK" && playerChoice "PAPER" && playerChoice != "SCISSORS")
            {
                Console.Write("Select an option ROCK, PAPER or SCISSORS: ");
                playerChoice = Console.ReadLine().ToUpper();
            }
        }
    }

efter bruger vi switch og laver en case for at fotælle hvad der sker ud fra spillerens valg
prøv selv at lave en case til paper og scissors som der er lavet til rock

    switch (random.Next(1, 4)) // med Next() sætter vi en range af tal den kan random imellem det lave tal er inklusivt men det høje tal er esklusivt så denne kode vil random 1-3
    {
        case 1:
            ghostChoice = "ROCK";
            break;
        case 2:
            ghostChoice = "PAPER";
            break;
        case 3:
            ghostChoice = "SCISSORS";
            break;
    }
    Console.WriteLine($"You selected {playerChoice}. The ghost selected {ghostChoice}.");

    switch (playerChoice)
    {
        case "ROCK":
            if (ghostChoice == "ROCK")
            {
                Console.WriteLine("Its a tie!");
            }
            else if (ghostChoice == "PAPER")
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
            break;
    }

og så i slutningen af vores while loop spørger vi om de vil spille igen
hvis der svares ja sætter den playAgain til true så while loopet fortsætter fra toppen
hvis der svares nej sætter vi playAgain til false så loopet stopper og ikke køre forfra

    Console.WriteLine("Would you like to play again (Y/N): ");
        string answer = Console.ReadLine().ToUpper();
        if (answer == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
            Console.WriteLine("THE END.");
        }


efter if(firstChoice == "NO){...}
laver vi hvad der skal ske hvis spilleren valgte yes i første valg med else if hvor vi fortsætter historien og giver spilleren nye options til at fortsætte

    else if (firstChoice == "YES")
        {
            Console.WriteLine("You walk into the hallway and see a lightcoming from under a door down the hall. You walk towards it.Do you open it or knock?");
            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine().ToUpper();
        }

lige under doorChoice laver vi en ny if hvor vi printer i konsollen at en stemme giver en gåde som spillerens skal svare på

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

og efter den if laver vi en else if hvor spillerens prøver at åbne døren men den er låst så vi giver option mellem et par nøgler og switch med en case til hver nøgle

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
                    Console.WriteLine("You choose the third key. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    break;
            }
        }

for at få en anden tekst farve tilføjer vi i toppen af vores metode (static void Main linjen)

    Console.ForegroundColor = ConsoleColor.Cyan;

og nede i vores switch(playerChoice) kan vi f.eks sætte forskelige farver på hver case

    case "ROCK":
        if (ghostChoice == "ROCK")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Its a tie!");
        }
        else if (ghostChoice == "PAPER")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lose!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win!");
        }
        break;

for at resete farven kan vi sætte farven i toppen af vores playAgain while loop

    Console.ForegroundColor = ConsoleColor.Cyan;