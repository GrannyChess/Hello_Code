Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "grannychess")
{
    Console.WriteLine("Fuck off, GrannyChess!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}