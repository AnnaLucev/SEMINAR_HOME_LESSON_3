Console.Clear();
Console.WriteLine("1 - Программа для расчета А в степени В");
Console.WriteLine("2 - Программа для расчета суммы цифр в числе");
Console.WriteLine("3 - Программа для  вывода на экран массива из заданного количества элементов");

int numberOfTask = Prompt("Введите номер задачи ");
switch (numberOfTask)
{
   case 1:
   AToDegreeOfB();;
   break;
   
   case 2:
   SumFigures();;
   break;

   case 3:
   PrintArray();;
   break;
   
   default:
   Console.WriteLine("Номер задачи введен некорректно");
   break;
}

int Prompt(string message)     // Метод запроса
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Задача 25 
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
// 3,5 --- 243
// 2,4 --- 16

void AToDegreeOfB()  //  функция расчета заданной степени заданного числа через цикл
{
    int a = GetNumber();
    int b = GetNumber();
    if (b > 0)
    {
       int result = 1;
       for (int i = 1; i <= b; i++)
       {
           result = result * a;
       }
       Console.WriteLine($"Число {a}, возведенное в степень {b}  =  {result}");
    }
    else  Console.WriteLine("Введено некорректное число степени, введите второе целое число > 0");
}

int GetNumber()     //  функция вывода вводимых данных в виде int
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// Задача 27 
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 --- 11
// 82 --- 10
// 9012 --- 12

void SumFigures()  //  функция расчета суммы цифр в заданном числе
{
    int number = GetNumber();
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр числа   =  {result}");
}

// Задача 29 
// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
// 1,2,5,7,19 --- [1,2,5,7,19]
// 6,1,33 --- [6,1,33]

void  PrintArray()      // вывод массива чисел из N элементов
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int countElements = int.Parse(Console.ReadLine());
    int[] arr = new int[countElements];
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}:\t ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Вывод (печать) массива: ");
    string array = String.Join(", ", arr);
    Console.WriteLine($"[{array}]");
}