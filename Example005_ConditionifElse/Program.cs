Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "шабдан")
{
    Console.WriteLine("Ура, это же Шабдан!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
