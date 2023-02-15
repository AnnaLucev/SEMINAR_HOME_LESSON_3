// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int rand  = new Random().Next(10,100); // [10; 100)
Console.WriteLine(rand);

if (rand/10 > rand%10) 
{
    Console.WriteLine(rand/10);
}
else
{
    Console.WriteLine(rand%10);
}