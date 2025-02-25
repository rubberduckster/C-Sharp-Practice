namespace Program
{
    static class Program
    {
        public static void Main() {
            //Loop for main menu (options: variables, strings, arithmetic expressions, variables in expression,
            //boolean variables, if-else statements, switch cases, loops, extended control structure

            //Put them into different files (by assingment group) and use void methods()
            //Potentially make folder the for menus

            //Makes the console be able to read unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Background color
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            //Prints the menu
            Console.Write("|");
            Console.WriteLine("C# assignments.");
            Console.WriteLine("1. Variables ------------------------------------------ |");
            Console.WriteLine("2. Strings -------------------------------------------- |");
            Console.WriteLine("3. Arithmetic expressions ----------------------------- |");
            Console.WriteLine("4. Variables in expression ---------------------------- |");
            Console.WriteLine("5. Boolean variables ---------------------------------- |");
            Console.WriteLine("6. If-else statements --------------------------------- |");
            Console.WriteLine("7. Switch cases --------------------------------------- |");
            Console.WriteLine("8. Loops ---------------------------------------------- |");
            Console.WriteLine("9. Extended control structure ------------------------- |");
            Console.WriteLine("");
            Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
            Console.WriteLine("");
            Console.Write("Enter number: ");

            //Shared values for multiple cases
            string userInputMain = Console.ReadLine();

            switch (userInputMain) {
                case "1":
                    //Prints menu
                    VariableFunctions.VariablesMenu();

                    //Shared values for multiple cases
                    string userInput1 = Console.ReadLine();

                    switch (userInput1) {
                        case "1":
                        Console.Clear();
                        Console.WriteLine("1. Assignment - Printing 2 ints on 2 lines" + "\n");

                            //Assignment 1 - Found in Variables.cs
                            VariableFunctions.Variables1();
                            Console.WriteLine("Press 0 to go back");
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - Printing 2 ints in a string on 2 lines" + "\n");

                            int Number1 = 5, Number2 = 3;

                            Console.WriteLine("Number1 is " + Number1 + "\n" + "Number2 is " + Number2 + "\n");
                            Console.WriteLine("Press 0 to go back");
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. Assignment - Printing out multiple values to a string" + "\n");

                            string name = "Søren";
                            int age = 16;
                            double money = 123.34;

                            Console.WriteLine("My name is {0}, I'm {1} years old and have earned {2}kr. on fixing bicycles" + "\n");
                            Console.WriteLine("Press 0 to go back");
                            break;

                        case "4":

                            Console.Clear();
                            Console.WriteLine("4. Assignment - Printing out a reciept" + "\n");

                            double cake = 23.56, beer = 34.67, sausage = 65.34;
                            double total = cake + beer + sausage;

                            Console.WriteLine("Cake - 23,56kr." + "\n" + "Beer - 34,67kr." + "\n" + "Sausage - 65,34kr." + "\n" + "\n" + "{0:N2}kr.", total);
                            Console.WriteLine("Press 0 to go back");
                            break;

                        case "5":
                            Console.Clear();
                            Console.WriteLine("5. Assignment - Taking and printing user input" + "\n");

                            string userName = "";
                            string userAge = "";
                            int userAgeCon = 0;

                            Console.Write("Insert your name: ");
                            userName = Console.ReadLine();
                            Console.Write("Insert your age: ");
                            userAge = Console.ReadLine();
                            userAgeCon = int.Parse(userAge);

                            Console.WriteLine("\n" + "My name is {0} and I'm {1} years old.", userName, userAge);
                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("6. Assignment - Calculating area of a circle" + "\n");

                            string radius = "";
                            double radiusCon = 0;

                            Console.Write("Insert the circles radius: ");
                            radius = Console.ReadLine();
                            radiusCon = int.Parse(radius);

                            double result = Math.PI * Math.Pow(radiusCon, 2);
                            Console.WriteLine("The area of your circle is {0:N2}.", result);
                            break;
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("String assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("3. Assingment ----------------------------------------- |");
                    Console.WriteLine("4. Assignment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput2 = Console.ReadLine();
                    //Assignment 1 & 2
                    string text = "text";
                    int number = 1;
                    double deci = 1.1;

                    switch (userInput2)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - Printing values" + "\n");

                            Console.WriteLine(text + "\n" + number + "\n" + deci);
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - Changing values" + "\n");

                            text = "new";
                            number = 2;
                            deci = 2.2;

                            Console.WriteLine(text + "\n" + number + "\n" + deci);
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. Assignment - Printing string" + "\n");

                            string december = "Today it's the 24th of December.";

                            Console.WriteLine(december);
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("4. Assignment - Printing values with a string" + "\n");

                            double two = 200.50;
                            string have = "I have", bank = "kr. in the bank";

                            Console.WriteLine("{0} {1} {2}", have, two, bank);
                            break;
                    }

                    break;

                case "3":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Arithmetic expressions assignment.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput3 = Console.ReadLine();

                    switch (userInput3)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - Math" + "\n");

                            int calc1 = 2 + 1 * 2, calc2 = (2 + 1) * 2, calc3 = 5 / 2, calc4 = 8 % 3, calc5 = 1 - 5;

                            Console.WriteLine("2 + 1 * 2 = {0}\n(2 + 1) * 2 = {1}\n5 / 2 = {2}\n8 % 3 = {3}\n1 - 5 = {4}", calc1, calc2, calc3, calc4, calc5);
                            break;
                    }

                    break;

                case "4":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Variables in expression assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assingment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput4 = Console.ReadLine();

                    switch (userInput4)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - Math" + "\n");

                            double value1 = 4, value2 = 35, value3 = 12, result = 0;

                            result = value1 + value3 / value2;

                            Console.WriteLine("{0} + {1} / {2} = {3:N2}", value1, value3, value2, result);
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - Math" + "\n");

                            double number1 = 5, number2 = 7, number3 = 12, result1 = 0;

                            result1 = number1 + 4 + number2 / 3 * number3;

                            Console.WriteLine("");
                            break;
                    }

                    break;

                case "5":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Boolean variables assignment.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput5 = Console.ReadLine();

                    switch (userInput5)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - Bool" + "\n");

                            int var1 = 2, var2 = 4;
                            bool boolean = var1 > var2;

                            Console.WriteLine("{0} > {1} = {2}", var1, var2, boolean);

                            break;
                    }

                    break;

                case "6":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("If-else assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("3. Assingment ----------------------------------------- |");
                    Console.WriteLine("4. Assignment ----------------------------------------- |");
                    Console.WriteLine("5. Assingment ----------------------------------------- |");
                    Console.WriteLine("6. Assignment ----------------------------------------- |");
                    Console.WriteLine("7. Assignment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput6 = Console.ReadLine();

                    switch (userInput6)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - Bigger than" + "\n");

                            int num1 = 42, num2 = 64;
                            int result = num1 + num2;

                            Console.WriteLine("Is the total of {0} + {1} more, less or equal to 100? \n", num1, num2);

                            if (result > 100)
                            {
                                Console.WriteLine("The total is bigger than 100!");
                            }
                            else if (result < 100)
                            {
                                Console.WriteLine("The total is lower en 100.");
                            }
                            else
                            {
                                Console.WriteLine("The total is 100!");
                            }

                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - User input age" + "\n");

                            Console.Write("Insert your age: ");
                            string userAge = Console.ReadLine();
                            int userAge1 = 0;

                            userAge1 = int.Parse(userAge);

                            if (userAge1 < 57) 
                            {
                                Console.WriteLine("You are not too old.");
                            }
                            else if (userAge1 > 57)
                            {
                                Console.WriteLine("You are too old.");
                            }

                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. Assignment - User input age" + "\n");

                            Console.Write("Insert your age: ");
                            string age = Console.ReadLine();
                            int age1 = 0;

                            age1 = int.Parse(age);

                            if (age1 >= 50 && age1 <= 60)
                            {
                                Console.WriteLine("You're not too old or too young.");
                            }
                            else if (age1 > 60)
                            {
                                Console.WriteLine("You are too old");
                            }

                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("4. Assignment - User login" + "\n");

                            Console.WriteLine("Login.com");
                            Console.Write("Insert your username: ");
                            string username = Console.ReadLine();
                            Console.Write("");
                            Console.Write("Insert your password: ");
                            string password = Console.ReadLine();

                            if (username == "myname" && password == "mypassword")
                            {
                                Console.WriteLine("Login successful");
                            }
                            else
                            {
                                Console.WriteLine("Login failed");
                            }
                            break;

                        case "5":
                            Console.Clear();
                            Console.WriteLine("5. Assignment - User login" + "\n");

                            Console.WriteLine("Login.com");
                            Console.Write("Insert your username: ");

                            string username1 = Console.ReadLine();
                            if (username1 == "myname")
                            {
                                Console.Write("Insert your password: ");
                                string password1 = Console.ReadLine();

                                if (password1 == "mypassword")
                                {
                                    Console.WriteLine("Login successful");
                                }
                                else
                                {
                                    Console.WriteLine("Wrong password. Access denied.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong username. Access denied.");
                            }
                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("6. Assignment - Deduction" + "\n");

                            Console.WriteLine("Deduction on car travel - You get a 1,93kr deduction per km after 25km and 0,97kr after 120");
                            Console.Write("Insert how many km you drive to work everyday: ");

                            //Receives the distance the user has driven
                            int distance = Convert.ToInt32(Console.ReadLine());

                            double totalbetween, totalmore = 0;

                            if (distance < 25)
                            {
                                Console.WriteLine("You don't get any deduction");
                            }
                            else if (distance >= 25 && distance <= 120)
                            {
                                totalbetween = (distance - 24) * 1.93;
                                Console.WriteLine("You get {0:N2}kr deducted", totalbetween);
                            }
                            else if (distance > 121)
                            {
                                totalmore = 96 * 1.93 + (distance - 120) * 0.97;
                                Console.WriteLine("You get {0:N2}kr deducted", totalmore);
                            }

                            break;

                        case "7":
                            Console.Clear();
                            //Sets console title
                            Console.Title = "The Party";
                            Console.WriteLine("7. Assignment - Party" + "\n");

                            Console.WriteLine("What is your favorite color?\nYou can pick between:\n1. red\n2. green\n3. blue\n4. yellow\n");
                            Console.Write("Insert your favorite colors number: ");

                            //Receives users color pick
                            string backColor = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("How old are you?");
                            Console.Write("Insert your age: ");

                            //Receives users age
                            int drinkAge = Convert.ToInt32(Console.ReadLine());

                            //Sets background color based on users choice
                            if (backColor == "1")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Clear();

                            }
                            else if (backColor == "2")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Clear();
                            }
                            else if (backColor == "3")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                            }
                            else if (backColor == "4")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Clear();
                            }

                            //Tells user which bar they're allowed at (age based)
                            if (drinkAge > 18)
                            {
                                Console.WriteLine("You're welcome in the cocktail bar");
                                //Console.WriteLine("★"); //Can't make UTF8 encoding work right now //Fix later
                            }
                            else
                            {
                                Console.WriteLine("You're welcome in the soda bar");
                            }

                            break;
                    }

                    break;

                case "7":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Switch-case assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput7 = Console.ReadLine();

                    break;

                case "8":
                    Console.Clear();
                    //Sub menu - Loops
                    Console.Write("|");
                    Console.WriteLine("Loops assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("3. Assingment ----------------------------------------- |");
                    Console.WriteLine("4. Assignment ----------------------------------------- |");
                    Console.WriteLine("5. Assingment ----------------------------------------- |");
                    Console.WriteLine("6. Assignment ----------------------------------------- |");
                    Console.WriteLine("7. Assignment ----------------------------------------- |");
                    Console.WriteLine("8. Assignment ----------------------------------------- |");
                    Console.WriteLine("9. Assignment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Checks for user input for the menu
                    string userInput8 = Console.ReadLine();

                    switch (userInput8)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - 1 to 10" + "\n");

                            //Runs through numbers 1 to 10
                            Console.WriteLine("Done with for loop");
                             for (int i = 1; i < 11; i++)
                             {
                                 Console.WriteLine(i);
                             }

                            //Runs through numbers 1 to 10
                            Console.WriteLine("\nDone with while loop");
                             int a = 1;
                             while (a < 11)
                             {
                                 Console.WriteLine(a);
                                 a++;
                             }
                             break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - 100 to 1" + "\n");

                            //Runs through numbers 100 to 1
                            Console.WriteLine("Done with for loop");
                             for (int i = 100; i > 0; i--)
                             {
                                 Console.WriteLine(i);
                             }

                            //Runs through numbers 100 to 1
                            Console.WriteLine("\nDone with while loop");
                             int b = 100;
                             while (b > 0)
                             {
                                 Console.WriteLine(b);
                                 b--;
                             }
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. Assignment - 5 times table" + "\n");

                            //Loops and prints out the 5 times table
                            for (int i = 0; i < 51;)
                            {
                                Console.WriteLine(i);
                                i = i + 5;
                            }

                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("4. Assignment - ???" + "\n");

                            Console.WriteLine("Tbh wasn't 100% sure what it tried to make us do\n");
                            Console.Write("Assignment description: Lav et while loop og et med for-loop, som udskriver en talrækkefølgen: 20-0.");

                            break;

                        case "5":
                            Console.Clear();
                            Console.WriteLine("5. Assignment - 7 times table with formatting result to right-alignment" + "\n");

                            int j = 0;

                            //Loops and prints out the 7 times table
                            for (int i = 0; i < 141; j++)
                            {
                                Console.WriteLine("{0, 2} * 7 = {1, 3}", j, i);
                                i = i + 7;
                            }

                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("6. Assignment - User number times table" + "\n");

                            Console.Write("Insert the number you wanna make a times table of: ");
                            int userNumber = Convert.ToInt32(Console.ReadLine());

                            //Counter for how many much we've multiplied it
                            int tableCounter = 0;

                            //Loops and prints out the x(user input) times table
                            for (int i = 0; i < 200; tableCounter++)
                            {
                                Console.WriteLine("{0, 2} * {1} = {2, 3}", tableCounter, userNumber, i);
                                i = i + userNumber;
                            }

                            break;

                        case "7":
                            Console.Clear();
                            Console.WriteLine("7. Assignment - Creating a box" + "\n");

                            //Prints out horizontal lines of the box
                            for (int i = 0; i < 10; i++) 
                            {
                                Console.SetCursorPosition(20 + i, 4);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(20 + i, 8 - 1);
                                Console.WriteLine("■");
                            }

                            //Prints out vertical lines of the box
                            for (int k = 0; k < 4; k++)
                            {
                                Console.SetCursorPosition(20, 4 + k);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(30 - 1, 4 + k);
                                Console.WriteLine("■");

                            }

                            break;

                        case "8":
                            Console.Clear();
                            Console.WriteLine("8. Assignment - Creating a box w/ my name" + "\n");

                            //Prints out horizontal lines of the box
                            for (int i = 0; i < 10; i++)
                            {
                                Console.SetCursorPosition(20 + i, 4);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(20 + i, 8 - 1);
                                Console.WriteLine("■");
                            }

                            //Prints out vertical lines of the box
                            for (int k = 0; k < 4; k++)
                            {
                                Console.SetCursorPosition(20, 4 + k);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(30 - 1, 4 + k);
                                Console.WriteLine("■");

                            }

                            Console.SetCursorPosition(23, 6);
                            Console.WriteLine("Ruby");

                            break;

                        case "9":
                            Console.Clear();
                            Console.WriteLine("9. Assignment - Creating a box w/ user measurement and name" + "\n");

                            string userName = "";
                            //Receives user name
                            Console.Write("Insert your name: ");
                            userName = Console.ReadLine();

                            //Receives box width measurement
                            Console.Write("Insert the box width: ");
                            int userBoxWidth = Convert.ToInt32(Console.ReadLine());

                            //Receives box heigth measurement
                            Console.Write("Insert the box heigth: ");
                            int userBoxHeight = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            //Prints out horizontal lines of the box
                            for (int i = 0; i < userBoxWidth; i++)
                            {
                                Console.SetCursorPosition(0 + i, 0);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(0 + i, userBoxHeight - 1);
                                Console.WriteLine("■");
                            }

                            //Prints out vertical lines of the box
                            for (int i = 0; i < userBoxHeight; i++)
                            {
                                Console.SetCursorPosition(0, 0 + i);
                                Console.WriteLine("■");
                                Console.SetCursorPosition(userBoxWidth - 1, 0 + i);
                                Console.WriteLine("■");

                            }

                            //Initializes variables for X and Y positions of users name
                            int namePositionX = userBoxWidth / 2, namePositionY = userBoxHeight / 2;

                            //Positions and prints users name
                            Console.SetCursorPosition(namePositionX - userName.Length / 2, namePositionY);
                            Console.WriteLine(userName);

                            break;
                    }

                    break;

                case "9":
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Extended control structure assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("3. Assingment ----------------------------------------- |");
                    Console.WriteLine("4. Assignment ----------------------------------------- |");
                    Console.WriteLine("5. Assingment ----------------------------------------- |");
                    Console.WriteLine("0. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput9 = Console.ReadLine();

                    switch (userInput9)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - 3 times table up till 21" + "\n");

                            //Loops and prints out the 5 times table
                            for (int i = 0; i < 22;)
                            {
                                Console.WriteLine(i);
                                i = i + 3;
                            }

                            Console.WriteLine("Now the loop has stopped");

                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Assignment - 4 times table but it skips 16" + "\n");

                            for (int i = 0; i < 40;)
                            {
                                i = i + 4;
                                if (i == 16)
                                {
                                    continue;
                                }
                                Console.WriteLine(i);
                            }

                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. Assignment - Price deduction" + "\n");

                            Console.WriteLine("Deduction on car travel\nYou get a 1,54kr deduction per km for 25-100km driven\nYou get a 0,77kr deduction per km for over 100km driven");
                            Console.Write("Insert how many km you drive to work everyday: ");

                            //Receives the distance the user has driven
                            int distance = Convert.ToInt32(Console.ReadLine());

                            double total = 0;

                            //Calculates how much of a price deduction the user gets
                            if (distance < 25)
                            {
                                Console.WriteLine("You don't get any deduction");
                            }
                            else if (distance >= 25 && distance <= 100)
                            {
                                total = (distance - 24) * 1.54;
                                Console.WriteLine("You get {0:N2}kr deducted", total);
                            }
                            else if (distance > 100)
                            {
                                total = 76 * 1.54 + (distance - 120) * 0.77;
                                Console.WriteLine("You get {0:N2}kr deducted", total);
                            }

                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("4. Assignment - what type of taxes do you need to pay based on income" + "\n");

                            int income = Convert.ToInt32(Console.ReadLine());

                            if (income < 42000)
                            {
                                Console.WriteLine();
                            }

                            break;
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}