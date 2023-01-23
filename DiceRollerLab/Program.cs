
using DiceRollerLab;

bool isValidNum; // establish a boolean that assures the user only inputs an integer
do
{
    Console.WriteLine("Hello, to roll, please input the numer of sides you would like on your dice");//Prompt user for number of sides per die

    string inputSides = Console.ReadLine(); // take input and store in string
    isValidNum = int.TryParse(inputSides, out int sides);// check to see if it is of type int

    if (isValidNum == true) //if input was in fact an int run this code
    {
        if (sides < 2 || sides == 3) // check sides to see if you can roll, ive never seen a 2 or three side die
        {
            Console.WriteLine("Uuumm what kind of dice are those?");
        }
        else if (sides == 2)
        {
            Console.WriteLine("Uuumm i think youd better do a coin flip instead");
        }



        else if (sides == 6) // if user chooses a 6 sided specifically run this style for crpas scoring
        {
            Console.WriteLine("You chose to roll a " + sides + " sided die"); // displays chosen amount of sides
            Console.WriteLine("Press the enter key to give 'em a roll"); // enter to roll
            Console.ReadLine();

            //Random rand1 = new Random(); // initiate random number generation
            //int myRandomNumber1 = rand1.Next(1, 7); // establish range of numbers,
            //Console.WriteLine("First die reads: " + myRandomNumber1 + "!"); // display first die value

            int roll1 = RollerClass.Roller6();
            int roll2 = RollerClass.Roller6();
            Console.WriteLine("First die reads: " + roll1 + "!");
            Console.WriteLine("Second die reads: " + roll2 + "!");
            

            if (roll1 == 1 && roll2 == 1) // if both are 1, display snake eyes
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1)) //if one is 1 and the other is 2 display ace deuce
            {
                Console.WriteLine("Ace Deuce!");
            }
            else if (roll1 == 6 && roll2 == 6) // if both rolls are 6 display box cars
            {
                Console.WriteLine("Box Cars!");

            }
            else if (roll1 + roll2 == 7 || roll1 + roll2 == 11) // if total value is either 7 or 11 display as a win
            {
                Console.WriteLine("Win!");
            }
            if (roll1 + roll2 == 2 || roll1 + roll2 == 3 || roll1 + roll2 == 12)  // if total value is 2, 3, or 12, display craps
            {
                Console.WriteLine("Craps!");
            }

            int rollTotal = (roll1 + roll2); // add each die together to get a total

            Console.WriteLine("If we add those up, the total comes to: " + rollTotal);//display total
        }
        else // if the user does not choos a 6 sided die specifically, run this block
        {

            Console.WriteLine("You chose to roll a " + sides + " sided die"); // display number of sides chosen to user
            Console.WriteLine("Press the enter key to give 'em a roll"); // enter to roll
            Console.ReadLine();

            int roll3 = RollerClass.Roller(sides);
            int roll4 = RollerClass.Roller(sides);
            Console.WriteLine("First die reads: " + roll3 + "!"); //diplay first die value
            Console.WriteLine("Second die reads: " + roll4 + "!");
           
            int rollTotal = (roll3 + roll4); // add each die together to get a total

            Console.WriteLine("If we add those up, the total comes to: " + rollTotal); //display total
        }


    }
    if (isValidNum == false) // if the user enters anything otherthan an inger display this message
    {
        Console.WriteLine("Sorry, please only enter whole numbers into this game");

    }

    Console.WriteLine("Would you like to continue? y/n?"); //continue running with a prompt at the end to see if they want to stop. 
    string choice2 = Console.ReadLine();
    while (choice2 != "y" && choice2 != "Y")
    {
        Console.WriteLine("See Ya!");
        return;

    }
} while (true);


