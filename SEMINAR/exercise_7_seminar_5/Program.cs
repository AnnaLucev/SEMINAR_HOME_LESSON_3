Console.Clear();
Console.WriteLine("1 - Программа для расчета суммы отрицательных и положительных элементов случайного массива (задача 31)");
Console.WriteLine("2 - Программа для замены элементов массива: положительные элементы заменяются на соответствующие отрицательные и наоборот (задача 32)");
Console.WriteLine("3 - Программа для  определения, присутствует ли заданное число в массиве (задача 33)");
Console.WriteLine("4 - Программа задания одномерного массива из 123 элементов и для вывода количества элементов массива, значения которых лежат в отрезке [10, 99](задача 35");
Console.WriteLine("5 - Программа нахождения произведения пар чисел в одномерном массиве (парой считается первый и последний элемент, второй и предпоследний и тд), результат в отдельный массив (задача 37");

int numberOfTask = Prompt("Введите номер задачи ");
switch (numberOfTask)
{
    case 1:
    SumNegPosArr();
    break;

    case 2:
    ReplaceNegArr();
    break;

    case 3:
    SearchNumberArr();
    break;

    case 4:
    CountElementArr();
    break;

    case 5:
    ProductCouplElemArr();
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


// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void SumNegPosArr()   // итоговая функция выполнения задачи 31
{
    int negative = 0, positive = 0; 
    int[] arrayResult = new int[12]; 

    arrayResult = GetArray(); 
    void SumArray(int[] array)   // функция нахождения сумм отрицательных и положительных элементов массива
    {     
        foreach (int el in array)     
        {         
            if (el > 0)             
                positive += el;         
            else negative += el;     
        }    
        Console.WriteLine(negative + " " + positive); 
    }  
    SumArray(arrayResult); 
    PrintResult(arrayResult, positive, negative);
}

int[] GetArray()   // задаем функцию определения случайного массива из 12 элементов
{
    int [] array = new int[12];
    for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(-9,10);
    return array;
}

void PrintResult(int[] array, int positive, int negative)   // функция вывода на экран результата
{     
    Console.WriteLine($"Array result is [ {String.Join(",  ", array)} ]");     
    Console.WriteLine($"Positive sum is    {positive}    and Negative sum is    {negative}"); 
}  

// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот
// [-4,-8,8,2] --- [4,8,-8,-2]

void ReplaceNegArr()    // итоговая функция задачи 32
{
    int [] arr = new int [8];
    Random random = new Random();
    Console.Write($"Исходный массив:    ");
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-10, 11);
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
    Console.Write($"Измененный массив:  ");
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write($"{arr[i]}\t");
    }
}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
// 4; массив  [6,7,19,345,3]  ----- нет
// -3; массив  [6,7,19,345,-3]  ----- да

void SearchNumberArr()      // итоговая функция задачи 33
{  
    int [] arr = {6, 7, 19, 345, 3};
//  int [] arr = PrintArray();      
    int number = Prompt("Введите число для поиска");

    if(FoundNumberOfArray(arr, number))
         Console.WriteLine($"В массиве  {arr} элемент {number} найден.");
    else
         Console.WriteLine($"В массиве  {arr} элемент {number} не найден.");   
}

int []  PrintArray()      // вывод массива чисел из N элементов
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
    return arr;
}

bool FoundNumberOfArray(int [] arr, int userNumber)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == userNumber)
            return true;      
    }
    return false;
}

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
// массив  [5,18,123,6,2]  ----- 1
// массив  [1,2,3,6,2]  ----- 0
// массив  [10,11,12,13,14]  ----- 5

static void CountElementArr()
{
    int [] arr = new int [123];
    Random random = new Random();
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 500);
        if (arr[i] >= 10 && arr[i] < 100)
        {
            count++;
        }
    }
    foreach (var item in arr)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и тд 
// Результат запишите в новом массиве
// массив  [1 2 3 4 5]  ----- 5 8 3
// массив  [6 7 3 6]  ----- 36 21


static void ProductCouplElemArr()
{
//  int [] arr = {1, 2, 3, 4, 5};
    int [] arr = {1, 2, 4, 5};
    int [] arr2;
    if (arr.Length % 2 != 0)   // проверка на четность и нечетность количества элементов массива
    {
        arr2 = new int [arr.Length / 2 + 1];
        arr2 [arr.Length / 2] = arr[arr.Length / 2];
    }
    else
        arr2 = new int [arr.Length / 2];

//  for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    for (int i = 0, i < arr.Length / 2; i++)
        arr2[i] = arr[i] * arr [arr.Length - i - 1];

    Console.WriteLine("Исходный массив:  ");
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Итоговый массив парных произведений:  ");
    foreach (var item in arr2)
    {
        Console.Write(item + " ");
    }
}
//  Console.WriteLine(String.Join(" ", arr);
//  Console.WriteLine(String.Join(" ", arr2);




