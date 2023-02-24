Console.Clear();
Console.WriteLine("1 - Программа для расчета количества четных чисел в массиве из трехзначных чисел (задача 34)");
Console.WriteLine("2 - Программа для расчета суммы элементов на нечетных позициях одномерного случайного массива (задача 36)");
Console.WriteLine("3 - Программа для  определения разницы между макс и мин значениями случайного массива (задача 38)");

int numberOfTask = Prompt("Введите номер задачи ");
switch (numberOfTask)
{
    case 1:
    CountEvenNArr();
    break;

    case 2:
    SumElNoEvenIndex();
    break;

    case 3:
    DiffMaxMinArr();
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

// Задача 34: 
// Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве 
// [345, 897, 568, 234] ---  2
// 

void CountEvenNArr()   // итоговая функция выполнения задачи 34
{
    int[] arrayResult = new int[12]; 
    arrayResult = GetArray(); 
    int countEven_ =  CountEven (arrayResult);
    Console.WriteLine($"Итоговый массив -- [ {String.Join(",  ", arrayResult)} ]");  
    Console.WriteLine($"Количество четных чисел в массиве   --  {countEven_}"); 
}

int[] GetArray()   // задаем функцию определения случайного массива трехзначных чисел из 12 элементов
{
    int [] array = new int[12];
    for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(100,1000);
    return array;
}

int CountEven (int[] array)  // задаем функцию определения количествa четных чисел в массиве
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
           countEven += 1;
    }
    return countEven;
}


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях 
// [3, 7, 23, 12] ---  19 
// [-4, -6, 89, 6] ---  0

void SumElNoEvenIndex()   // итоговая функция выполнения задачи 36
{
    int[] arrayResult = new int[6]; 
    arrayResult = GetArray_(); 
    int sumNOEvenIn_ =  SumNOEvenInd (arrayResult);
    Console.WriteLine($"Итоговый массив -- [ {String.Join(",  ", arrayResult)} ]");  
    Console.WriteLine($"Сумма элементов на нечетных позициях   =  {sumNOEvenIn_}"); 
}

int[] GetArray_()   // задаем функцию определения случайного массива из 6 элементов
{
    int [] array = new int[6];
    for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(-100,100);
    return array;
}

int SumNOEvenInd (int[] array)  // задаем функцию рачета суммы элементов на нечетных позициях
{
    int sumNOEvenIn = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 == 0)
           sumNOEvenIn += array[i];
    }
    return sumNOEvenIn;
}

// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива
// [3, 7, 22, 2, 78] ---  76

void DiffMaxMinArr()   // итоговая функция выполнения задачи 38
{
    int[] arrayResult = new int[6]; 
    arrayResult = GetArray__(); 
    int diffMaxMin_ =  DiffMaxMin(arrayResult);
    Console.WriteLine($"Итоговый массив -- [ {String.Join(",  ", arrayResult)} ]");  
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива   =  {diffMaxMin_}"); 
}

int[] GetArray__()   // задаем функцию определения случайного массива из 6 элементов
{
    int [] array = new int[6];
    for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(0,100);
    return array;
}


int DiffMaxMin (int[] array)  // задаем функцию рачета разницы между макс и мин значениями массива
{
    int diffMaxMin = 0;
    int maxim = array[0];
    int minim = array[0];

    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > maxim) maxim = array[i];
           if (array[i] < minim) minim = array[i];
    }
    diffMaxMin = maxim - minim;
    return diffMaxMin;
}




