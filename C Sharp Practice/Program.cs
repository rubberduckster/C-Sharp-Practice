namespace Program
{
    static class Program
    {
        public static void Main() {
            //Loop for main menu (options: variables, strings, arithmetic expressions, variables in expression,
            //boolean variables, if-else statements, switch cases, loops, extended control structure, methods and instances,
            //return types and parameters, instance variables, inheritance, constructors, arrays, loop of array, public, private and protected)

            //Background color
            Console.BackgroundColor = ConsoleColor.DarkRed;
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

            switch (Console.ReadLine()) {
                case "1":
                    Console.Clear();
                    Console.WriteLine();
                    break;
            }

            Console.ReadKey();
            //do { } while ();
        }
    }
}