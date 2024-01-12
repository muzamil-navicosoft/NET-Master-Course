string? name = string.Empty;
int age;
int allowedage = 21;

Console.WriteLine("Enter your name please");
name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Enter your age please");
var result = int.TryParse(Console.ReadLine(), out int userAge);
if (result != false)
{
    age = userAge;


    if (!string.IsNullOrEmpty(name))
    {
        if (name.ToLower() == "bob" || name.ToLower() == "sue")
        {
            Console.WriteLine("Welcome Professor");
        }
        else if (age < 21)
        {
            Console.WriteLine($"you have wait for {allowedage-age} year to attend this class");
        }
        else
        {
            Console.WriteLine($"weclome to The class {name}");
        }
    }
}