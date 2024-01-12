string name= string.Empty;
List<string> list = new List<string>();

do
{
    Console.WriteLine("Enter the First Naem or type exit when you are done");
    name = Console.ReadLine();
    if (string.IsNullOrEmpty(name) && name.ToLower() != "exit") ;
    list.Add(name);

} while (name.ToLower() != "exit");


foreach (string s in list)
{
    Console.WriteLine($"Hello  {s}");
}