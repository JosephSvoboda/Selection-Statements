
var r = new Random();
int favNumber = r.Next(1,1000);


    Console.WriteLine("Guess a number.");
    var userInput = int.Parse(Console.ReadLine());


    if (userInput < favNumber)
    {
        Console.WriteLine("Too low.");
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine("Too high.");
    }
    else
    {
        Console.WriteLine("Congratulations, you are correct!");
    }