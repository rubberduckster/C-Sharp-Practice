namespace Program
{
    static class Program
    {
        public static void Main() {
            //Loop for main menu (options: variables, strings, arithmetic expressions, variables in expression,
            //boolean variables, if-else statements, switch cases, loops, extended control structure, methods and instances,
            //return types and parameters, instance variables, inheritance, constructors, arrays, loop of array, public, private and protected)

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
            Console.WriteLine("10. Methods and instances ----------------------------- |");
            Console.WriteLine("11. Return types and parameters ----------------------- |");
            Console.WriteLine("12. Instance variables -------------------------------- |");
            Console.WriteLine("13. Inheritance --------------------------------------- |");
            Console.WriteLine("14. Constructors -------------------------------------- |");
            Console.WriteLine("15. Arrays -------------------------------------------- |");
            Console.WriteLine("16. Loop of array ------------------------------------- |");
            Console.WriteLine("16. Public, private and protected --------------------- |");
            Console.WriteLine("");
            Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
            Console.WriteLine("");
            Console.Write("Enter number: ");

            //Shared values for multiple cases
            string userInput1 = Console.ReadLine();

            switch (userInput1) {
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
                    string userInput = Console.ReadLine();
                    //Assignment 1 & 2
                    int Number1 = 5, Number2 = 3;

                    switch (userInput) {
                        case "1":

                        Console.Clear();
                        Console.WriteLine("1. Assignment - Printing 2 ints on 2 lines" + "\n");

                            

                            Console.WriteLine(Number1 + "\n" + Number2 + "\n");
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

                            Console.WriteLine("Insert your name: ");
                            userName = Console.ReadLine();
                            Console.WriteLine("Insert your age: ");
                            userAge = Console.ReadLine();
                            userAgeCon = int.Parse(userAge);

                            Console.WriteLine("\n" + "My name is {0} and I'm {1} years old.", userName, userAge);
                            break;

                        case "6":

                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}