Console.WriteLine("Enter The multiple User Name With Coma Seperation and without space");
string commanames = Console.ReadLine();

string[] names = commanames.Split(',');

for(int i=0; i<names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]} \n");
}