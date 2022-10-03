Console.WriteLine("Add user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Wow, this is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}