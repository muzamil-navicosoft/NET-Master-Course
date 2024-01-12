int UserAge;
int age;
int yougeAge = 25;
do
{
    Console.WriteLine("Please Enter your Age");
}
while (!int.TryParse(Console.ReadLine(), out age));

UserAge = age;


Console.WriteLine($"you will be of {yougeAge + UserAge} after {yougeAge} years");

Console.WriteLine($"you were {UserAge - yougeAge} year old before {yougeAge} years");

