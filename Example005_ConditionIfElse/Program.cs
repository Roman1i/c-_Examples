Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ромчик")
{
    Console.WriteLine("Йоу, Ромчик!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}