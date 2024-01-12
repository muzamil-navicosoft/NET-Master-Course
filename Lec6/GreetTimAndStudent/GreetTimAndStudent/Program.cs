string? Name = string.Empty;
Name = Console.ReadLine();
if( !string.IsNullOrEmpty(Name))
{
    if(Name.ToLower() == "tim")
    {
        Console.WriteLine("Welcome Professor");
    }
    else
    {
        Console.WriteLine($" Welcome new Student {Name} to the Class");
    }
}