// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -- да
// 7 -- да
// 1 -- нет

Console.Write("Input the number of the day of the week  -- ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)
{Console.WriteLine("This is weekend!"); }
else {Console.WriteLine("This is not weekend! Go to work!");}
