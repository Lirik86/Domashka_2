int promt(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
bool validate(int num)
{
    bool r = num <= 7 && num >= 1;
    if (r)
    {
        return true;
    }
    Console.WriteLine("ввели не верный день недели ");
    return false;
}
bool weekend(int isweek)
{
    if (isweek > 5)
    {
        return true;
    }
    return false;
}
int a = promt("Введите день недели >");
if (validate(a))
{
    if (weekend(a))
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Рабочий день(((");
    }
}