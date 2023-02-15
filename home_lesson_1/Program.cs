// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

// 456 -- 5
// 782 -- 8
// 918 -- 1

Console.Write("Input three-digit number  ");
int a = Convert.ToInt32(Console.ReadLine());
char[] arr = a.ToString().ToCharArray(); 
if (a > 99 && a < 1000)
{ Console.WriteLine("Second figure inputing number is  -  " + arr[1]);}
else {Console.WriteLine("Inputed non-three-digit number. Correct the input");}