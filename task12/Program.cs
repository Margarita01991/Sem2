// Принимает на вход два числа и выводить является ли второе число кратным первому. Если не кратно, то выводится остаток деления. 34 5 -> не кратно, остаток 4; 16, 4 -> кратно
Console.Clear();
double numberA = new Random().Next(9, 100);
double numberB = new Random().Next(1, 10);

if (numberA % numberB > 0)
{
    Console.Write($"{numberA} и {numberB}, не кратно, остаток {numberA % numberB}");
}
else 
{
    Console.Write($"{numberA} и {numberB}, кратно");
}