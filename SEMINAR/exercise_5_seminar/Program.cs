// Написать программу, которая принимает на вход число N и выдает сумму чисел от 1 до N
//  7 -- 28
//  4 -- 10
//  8 -- 36

int number = GetNumber();
Console.WriteLine("Sum is {0} ", Sum(number));

int GetNumber()     // задаем функцию вывода вводимых данных в виде int
{
    Console.WriteLine("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum (int a)    // задаем функцию вывода суммы данных от 1 до заданного числа
{
   int result = 0;
   for (int i = 1; i <= a; i++)
   {
      Console.Write(i + " ");
      result += i;
   }
   return result;
}