// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого

Console.Write("Введите первое число  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  ");
int b = Convert.ToInt32(Console.ReadLine());
  
if (a*a==b || b*b==a)      
{Console.WriteLine("Is one number the square of another?  -  True");}  
else {Console.WriteLine("Is one number the square of another?  -  False");}