int promt(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
bool validate(int num)
{
    bool r = num >= 100 && num < 1000;
    if (r)
    {
        return true;
    }
    Console.WriteLine("ввели не верное число ");
    return false;
}

int first = promt("Введите трехзначное число >");
if(validate(first))
{
   int sec = (first / 10) % 10;
    Console.WriteLine($"Вторая цифра в числе {first} равна {sec}");
}