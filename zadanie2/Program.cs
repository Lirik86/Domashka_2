int promt(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int proverka(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}
int chislo = promt("Введите число >");
int chislo3 = proverka(chislo);
if (chislo3 == -1)
{
    System.Console.WriteLine("В числе нет третей цифры ");
}
else
{
    Console.WriteLine($"цифра №3 в числе {chislo} является {chislo3}");
}
