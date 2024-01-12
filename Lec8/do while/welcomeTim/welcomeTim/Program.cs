string username;
do
{
    Console.WriteLine("Enter your name or type exit for exiting :");
    username = Console.ReadLine();
    if(username.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Proffessor {username}");
    }else
    {
        Console.WriteLine($"welcome Student {username}");
    }
} while (username.ToLower() != "exit");