Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша");//tolower() позволяет ввести имя "маша" с заглавной или строчной буквы, Маша, маШа и т.д.
{
    Console.WriteLine("Ура!Это же Маша!");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}
