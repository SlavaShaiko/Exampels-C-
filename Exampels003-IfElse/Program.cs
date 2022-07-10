internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя:  ");
        string username = Console.ReadLine();

        if (username.ToLower() == "slava")
        {
            Console.Write("Oh may love Slava!  ");
        }
        else
        {
            Console.Write("Hello,  ");
            Console.Write(username);
        }
    }
}