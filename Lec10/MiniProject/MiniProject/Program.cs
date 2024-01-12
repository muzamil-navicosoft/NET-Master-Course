Dictionary<string, int> GuestBook = new Dictionary<string, int>();
string familyName = string.Empty;
int familyCount = 0;
string enterOtherFamily = "n";
int totallPartyAttendies = 0;

do
{
    Console.WriteLine("Please Enter your Family Name");
    familyName = Console.ReadLine();
    Console.WriteLine("Please Enter your family count Inculding your self who are joing Party");
    familyCount = int.Parse(Console.ReadLine());
    GuestBook.Add(familyName, familyCount);
    Console.WriteLine(@"want to Enter Other Family to Party press 'Y' for Yes and 'N' for No");
    enterOtherFamily = Console.ReadLine();
} while (enterOtherFamily.ToLower() == "y");


Console.WriteLine("List of Famlies Joining the party Tonight are ");
foreach (var  family in GuestBook)
{
    Console.WriteLine($"{family.Key}");
    totallPartyAttendies+=family.Value;
}
Console.WriteLine($"Total Number of Preson in Today's Party are : {totallPartyAttendies}");
