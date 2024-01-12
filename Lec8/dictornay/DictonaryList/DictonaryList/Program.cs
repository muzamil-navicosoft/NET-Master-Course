Dictionary<int, string> employees = new Dictionary<int, string>();
int counter = 0;
int employeeID;
string? employeeName;
for(int i = 0; i<2; i++)
{
    Console.WriteLine("Please Enter Employee ID");
    employeeID= int.Parse(Console.ReadLine());

    Console.WriteLine("Please Enter the Name of Employee Agaisnt the ID");
    employeeName = Console.ReadLine();
    employees.Add(employeeID, employeeName);
    counter++;
}
Console.WriteLine(" Enter Any ID to know the name of that Employee");
int promptId = int.Parse(Console.ReadLine());
Console.WriteLine($" The Employee Against ID {promptId} is  {employees[promptId]}");

