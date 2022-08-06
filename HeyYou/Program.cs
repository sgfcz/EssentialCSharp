using static System.Console;

class HeyYou
{
    static void Main()
    {
        string firstName, lastName;
        WriteLine("Hey！You");

        Write("Enter you frist name: ");
        firstName = ReadLine();

        Write("Enter you last name: ");
        lastName = ReadLine();

        WriteLine($"Your full name is {firstName} {lastName}.");
    }
}