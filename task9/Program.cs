// Программа которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа 78 -> 8; 12 -> 2; 85 -> 8
int number = new Random().Next(10, 100);// последнее число не входит в отрезок!!!
Console.WriteLine($"Наше случайное число: {number}");//Console.WriteLine(number);
int digit1 = number/10; //нахождение первого числа
int digit2 = number%10; //нахождение последнего числа
Console.WriteLine($"Первая цифра: {digit1}");
Console.WriteLine($"Последняя цифра: {digit2}");
if (digit1 >digit2)
{
    Console.WriteLine($"Наибольшая цифра: {digit1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра: {digit2}");
}