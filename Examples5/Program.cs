Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ura, eto Masha");
}
else
{
    Console.Write("Privet, ");
    Console.WriteLine(username);
}