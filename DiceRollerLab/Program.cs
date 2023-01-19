
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

            Random rand1 = new Random(); // initiate random number generation
            int myRandomNumber1 = rand1.Next(1, 7); // establish range of numbers,
            Console.WriteLine("First die reads: " + myRandomNumber1 + "!"); // display first die value

            Random rand2 = new Random();
            int myRandomNumber2 = rand2.Next(1, 7);
            Console.WriteLine("First die reads: " + myRandomNumber2 + "!"); // display second die value

            if (myRandomNumber1 == 1 && myRandomNumber2 == 1) // if both are 1, display snake eyes
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if ((myRandomNumber1 == 1 && myRandomNumber2 == 2) || (myRandomNumber1 == 2 && myRandomNumber2 == 1)) //if one is 1 and the other is 2 display ace deuce
            {
                Console.WriteLine("Ace Deuce!");
            }
            else if (myRandomNumber1 == 6 && myRandomNumber2 == 6) // if both rolls are 6 display box cars
            {
                Console.WriteLine("Box Cars!");

            }
            else if (myRandomNumber1 + myRandomNumber2 == 7 || myRandomNumber1 + myRandomNumber2 == 11) // if total value is either 7 or 11 display as a win
            {
                Console.WriteLine("Win!");
            }
            if (myRandomNumber1 + myRandomNumber2 == 2 || myRandomNumber1 + myRandomNumber2 == 3 || myRandomNumber1 + myRandomNumber2 == 12)  // if total value is 2, 3, or 12, display craps
            {
                Console.WriteLine("Craps!");
            }

            int rollTotal = (myRandomNumber1 + myRandomNumber2); // add each die together to get a total

            Console.WriteLine("If we add those up, the total comes to: " + rollTotal);//display total
        } 
        else // if the user does not choos a 6 sided die specifically, run this block
        {
            Console.WriteLine("You chose to roll a " + sides + " sided die"); // display number of sides chosen to user
            Console.WriteLine("Press the enter key to give 'em a roll"); // enter to roll
            Console.ReadLine();
            Random rand3 = new Random(); //initiate random number generation
            int myRandomNumber1 = rand3.Next(1, (sides + 1)); //establish range of numbersand add 1 to include the highest value
            Console.WriteLine("First die reads: " + myRandomNumber1 + "!"); //diplay first die value

            Random rand4 = new Random();
            int myRandomNumber2 = rand4.Next(1, (sides + 1));
            Console.WriteLine("First die reads: " + myRandomNumber2 + "!"); //display second die value

            int rollTotal = (myRandomNumber1 + myRandomNumber2); // add each die together to get a total

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
