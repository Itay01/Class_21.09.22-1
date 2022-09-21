class ConsoleApp2
{
    public static void Main()
    {
        double hours_attended, hours_missing, salary, total_money;
        Console.WriteLine("Enter a number of hours you were attended: ");
        hours_attended = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number of hours you were missing: ");
        hours_missing = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your salar pre hour: ");
        salary = double.Parse(Console.ReadLine());
        total_money = hours_attended * salary;
        if (hours_missing < 3.5)
            total_money += total_money / 10;
        Console.WriteLine("Your total money is {0}", total_money);
    }
}