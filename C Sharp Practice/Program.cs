namespace Program
{
    static class Program
    {
        public static void Main() {
            //Loop for main menu (options: variables, strings, arithmetic expressions, variables in expression,
            //boolean variables, if-else statements, switch cases, loops, extended control structure

            //Put them into different files (by assingment group) and use void methods() to put them back here

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
                    Console.Clear();
                    Console.Write("|");
                    Console.WriteLine("Variable assignments.");
                    Console.WriteLine("1. Assingment ----------------------------------------- |");
                    Console.WriteLine("2. Assignment ----------------------------------------- |");
                    Console.WriteLine("3. Assingment ----------------------------------------- |");
                    Console.WriteLine("4. Assignment ----------------------------------------- |");
                    Console.WriteLine("5. Assingment ----------------------------------------- |");
                    Console.WriteLine("6. Assignment ----------------------------------------- |");
                    Console.WriteLine("7. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput1 = Console.ReadLine();
                    //Assignment 1 & 2
                    int Number1 = 5, Number2 = 3;

                    switch (userInput1) {
                        case "1":

                        Console.Clear();
                        Console.WriteLine("1. Assignment - Printing 2 ints on 2 lines" + "\n");

                            

                            //Console.WriteLine(Number1 + "\n" + Number2 + "\n");
                            Functions.Variable1();
                            Console.WriteLine("Press 0 to go back");
                            break;

                        case "2":

                            Console.Clear();
                            Console.WriteLine("2. Assignment - Printing 2 ints in a string on 2 lines" + "\n");

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
                    Console.WriteLine("5. Go back -------------------------------------------- |");
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
                    Console.WriteLine("2. Go back -------------------------------------------- |");
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
                    Console.WriteLine("3. Go back -------------------------------------------- |");
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
                    Console.WriteLine("2. Go back -------------------------------------------- |");
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
                    Console.WriteLine("8. Go back -------------------------------------------- |");
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

                            Console.WriteLine("Deduction on car travel - You get a 1,93kr deduction per km after a certain distance");
                            Console.Write("Insert how many km you drive to work everyday: ");

                            string distance = Console.ReadLine();
                            double distance1 = 0;

                            double totalbetween, totalmore = 0;

                            distance1 = int.Parse(distance);

                            if (distance1 < 24)
                            {
                                Console.WriteLine("You don't get any deduction");
                            }
                            else if (distance1 >= 25 && distance1 <= 120)
                            {
                                totalbetween = (distance1 - 24) * 1.93;
                                Console.WriteLine("You get {0:N2}kr deducted", totalbetween);
                            }
                            else if (distance1 > 121)
                            {
                                totalmore = 96 * 1.93 + (distance1 - 120) * 0 - 0.97;
                                Console.WriteLine("You get {0:N2}kr deducted", totalmore);
                            }

                            break;

                        case "7":
                            Console.Clear();
                            Console.Title = "The Party";
                            Console.WriteLine("7. Assignment - Party" + "\n");

                            Console.WriteLine("What is your favorite color?\nYou can pick between:\n1. red\n2. green\n3. blue\n4. yellow\n");
                            Console.Write("Insert your favorite colors number: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("How old are you?");
                            Console.Write("Insert your age: ");
                            string drinkAge = Console.ReadLine();

                            int drinkAge1 = int.Parse(drinkAge);

                            if (color == "1")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Console.WriteLine("★"); //Can't make it display correctly rn? fix later

                            }
                            else if (color == "2")
                            {
                                Console.Clear();
                                Console.BackgroundColor= ConsoleColor.DarkGreen;
                                Console.Clear();
                            }
                            else if (color == "3")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Clear();
                            }
                            else if (color == "4")
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.Clear();
                            }

                            if (drinkAge1 > 18)
                            {
                                Console.Clear();
                                Console.WriteLine("You're welcome in the cocktail bar");
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You're welcome in the soda bar");
                                Console.Clear();
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
                    Console.WriteLine("3. Go back -------------------------------------------- |");
                    Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
                    Console.WriteLine("");
                    Console.Write("Enter number: ");

                    //Shared values for multiple cases
                    string userInput7 = Console.ReadLine();

                    break;

                case "8":
                    Console.Clear();
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

                    //Shared values for multiple cases
                    string userInput8 = Console.ReadLine();

                    switch (userInput8)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("1. Assignment - 1 to 10" + "\n");

                            Console.WriteLine("Done with for loop");
                             for (int i = 1; i < 11; i++)
                             {
                                 Console.WriteLine(i);
                             }

                            Console.WriteLine("\n Done with while loop");
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

                            Console.WriteLine("Done with for loop");
                             for (int i = 100; i > 0; i--)
                             {
                                 Console.WriteLine(i);
                             }

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
                            Console.WriteLine("3. Assignment - 5 table" + "\n");

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
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}