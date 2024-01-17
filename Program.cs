using Mission2Part2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Create a new dice roll instance*/
        DiceRoll diceRoll = new DiceRoll();

        /*Get a number from the user and then store that number to a variable*/
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        int number = int.Parse(System.Console.ReadLine());

        /*Use the instance's class to call one of its class's methods.
        Store the return method to a new array in this program to be processed*/
        int[] numberArray = diceRoll.RollDice(number);

        /*Print initial results*/
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + number.ToString());

        /*Print histogram results*/
        for (int i = 2; i <= 12; i++)
        {
            int percentage = numberArray[i-2] * 100 / number;
            System.Console.WriteLine(i.ToString() + ": " + new string('*', percentage));
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}