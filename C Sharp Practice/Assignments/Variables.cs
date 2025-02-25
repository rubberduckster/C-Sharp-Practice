using System;
namespace Program
{
    public class VariableFunctions
    {
        //Variable assingment menu
        public static void VariablesMenu()
        {
            Console.Clear();
            Console.Write("|");
            Console.WriteLine("Variable assignments.");
            Console.WriteLine("1. Assingment ----------------------------------------- |");
            Console.WriteLine("2. Assignment ----------------------------------------- |");
            Console.WriteLine("3. Assingment ----------------------------------------- |");
            Console.WriteLine("4. Assignment ----------------------------------------- |");
            Console.WriteLine("5. Assingment ----------------------------------------- |");
            Console.WriteLine("6. Assignment ----------------------------------------- |");
            Console.WriteLine("0. Go back -------------------------------------------- |");
            Console.WriteLine("Type one of the numbers in the menu to view the assingment.");
            Console.WriteLine("");
            Console.Write("Enter number: ");
        }

        //First variable assignment
        public static void Variables1()
        {
            int number1 = 5, number2 = 3;

            //Prints out 2 int variables on their respective lines
            Console.WriteLine(number1 + "\n" + number2);
        }
    }
}