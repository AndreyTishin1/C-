Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "андрей")
{
    Console.WriteLine("Урааааа, это Андрей !!!!!");
}

else
{
    Console.Write("Привет, ");
    Console.Write(username);
}