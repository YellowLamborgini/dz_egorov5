Console.WriteLine("Введите год");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц");
int month = Convert.ToInt32(Console.ReadLine());
if (month>12)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine("Введите день");
int day = Convert.ToInt32(Console.ReadLine());
if (month == 2 & day>28&year%4!=0)
{
    Console.WriteLine("Ошибка!");
    return;
}else if (month == 2 & day>29&year%4==0)
{
    Console.WriteLine("Ошибка!");
    return;
}
else if (month == 4 | month == 6 | month == 9 | month == 11 & day>30)
{
    Console.WriteLine("Ошибка!");
    return;
}

    DateTime date = new DateTime(year,month,day);

if (month>=1&month<=2)
{
    Console.Write("Winter ");
}
else if (month >= 3 & month <= 5)
{
    Console.Write("Spring ");
}
else if (month >= 6 & month <= 8)
{
    Console.Write("Summer ");
}
else if (month >= 9 & month <= 11)
{
    Console.Write("Autumn ");
}
else if (month ==12)
{
    Console.Write("Winter ");
}

Console.WriteLine(date.DayOfWeek);