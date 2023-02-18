int Prompt(string massage)
{
Console.Write(massage);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

bool Weekend (int WeekDay)
{
    if (WeekDay > 5)
{
        return true;
}
return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int WeekDay = Prompt("Введите день недели:   ");
if (ValidateWeekday(WeekDay))
{
    if (Weekend(WeekDay))
    {
        Console.WriteLine("Ура! Выходной");
    }
    else
    {
        Console.WriteLine("Ура! Работаем");
    }
}
