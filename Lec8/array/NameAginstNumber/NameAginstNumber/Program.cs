string[] names = ["Muzamil", "Ali", "Asad"];
bool result;
int num;

do
{
    Console.WriteLine("Enter Any valid number betweem 1 to 3");
    result = int.TryParse(Console.ReadLine(), out num);
    
}
while (!result);

if( num >= 1 && num <= 3)
{
    Console.WriteLine($"The Name against the number {num} is {names[num-1]}");
}
else
{
    Console.WriteLine($"Name doesnot exist against the numnber : {num}");
}