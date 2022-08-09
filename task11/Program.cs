// Программа которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа. 456 -> 46; 782 -> 72; 918 -> 98
Console.Clear();
int number = new Random().Next(99, 1000);
Console.WriteLine($"Наше случайное число: {number}");
int digit1 = number/100; //нахождение первого числа
int digit2 = number%10;
Console.WriteLine($"{digit1}{digit2}");
//Console.WriteLine($"Первая цифра: {digit1}");
//Console.WriteLine($"Последняя цифра: {digit2}");
//int result = digit1 * 10;
//int sum = result + digit2;
//Console.WriteLine($"Наше число: {sum}");