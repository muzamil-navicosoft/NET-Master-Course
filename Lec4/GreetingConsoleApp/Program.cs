//In this application , we will welcome the user to our application and then we will ask them for their first name. Finally, we will Greet them by name


// Greeting The Client to The Application
Console.WriteLine(" Welcome To The Application ");
Console.WriteLine(" This Applicaiton is Developed by Muzamil Mughal By Love <3");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();


// Asking Customer to Entery His / Her Name
Console.WriteLine("Please Enter Your Name : ");
string? FirstName = "";
FirstName = Console.ReadLine();



// Greet Customer with His or Her Name
Console.WriteLine();
Console.WriteLine("Hi, " + FirstName);
Console.WriteLine("Thanks for using our Application!");
