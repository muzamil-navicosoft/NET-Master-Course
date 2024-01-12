
List<string> studences = new List<string>();
string? name;
Console.WriteLine("Enter The Student Name you Want to Enroll in The Class  or right exit to get the total count of the student and Exit the application: ");
do
{
    name = Console.ReadLine();
    if( !string.IsNullOrEmpty(name)  && name.ToLower() != "exit")
    {
        studences.Add(name);
    }
    else
    {
        Console.WriteLine($"The Count of the class is {studences.Count} ");
    }
}while (name.ToLower() !="exit");