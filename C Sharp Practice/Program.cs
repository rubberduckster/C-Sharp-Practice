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
            Console.WriteLine("");
            Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
            Console.WriteLine("");
            Console.Write("Enter number: ");

            Console.ReadKey();
            //do { } while ();
        }
    }
}