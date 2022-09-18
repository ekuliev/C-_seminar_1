// 1. Задача про дни недели или сказка про белого бычка
// Явно есть более эффективный способ с массивами или функциями типа DayOfWeek, 
// но в рамках того, что дали на лекции - такой огород
Console.Write("Введите номер дня (1-7): ");
string DayNumber = Console.ReadLine();
if(DayNumber == "1")
{
    Console.WriteLine("Это Пн");
}
else
{
    if(DayNumber == "2")
    {
        Console.WriteLine("Это Вт");
    }
    else
    {
        if(DayNumber == "3")
        {
            Console.WriteLine("Это Ср");
        }
        else
        {
            if(DayNumber == "4")
            {
                Console.WriteLine("Это Чт");
            }
            else
            {
                if(DayNumber == "5")
                {
                    Console.WriteLine("Это Пт");
                }
                else
                {
                    if(DayNumber == "6")
                    {
                        Console.WriteLine("Это Сб");
                    }
                    else
                    {
                        if(DayNumber == "7")
                        {
                            Console.WriteLine("Это Вс");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели некорректное число :(");
                        }
                    }
                }
            }
        }
    }
}