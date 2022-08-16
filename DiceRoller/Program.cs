
while (true)
{
    Console.WriteLine("================================================================= \n enter dice, ex: 2d4");
    var input = Console.ReadLine(); // "2d4"

    var split = input.Split("d"); // ["2","4"]

    var diceCount = int.Parse(split[0]); // 2
    var diceSides = int.Parse(split[1]); // 4

    Console.WriteLine($"Rolling {diceCount} dice of {diceSides} sides...");
    Console.WriteLine("rolla");
    Console.WriteLine("rola");
    Console.WriteLine("rollla");
    Console.WriteLine("rollaa!");

    var rand = new Random();

    var throws = 0;
    var diceTotals = 0;
    while (throws < diceCount)
    {
        var dieResult = rand.Next(1, diceSides+1);
        throws += 1;
        diceTotals += dieResult;
        Console.WriteLine($"You rolled {dieResult}");
    }

    Console.WriteLine($"Your total is {diceTotals}!!!!!");
    Console.WriteLine("-loona  -*-");
}