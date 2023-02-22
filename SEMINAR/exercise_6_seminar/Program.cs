Console.Clear();
Console.WriteLine("1 - Программа для расчета количества цифр в числе");
Console.WriteLine("2 - Программа для расчета произведения от 1 до N");
Console.WriteLine("3 - Программа для  вывода массива случайных чисел из 0 и 1");
Console.WriteLine("4 - Программа для  ");

int numberOfTask = Prompt("Введите номер задачи ");
switch (numberOfTask)
{
    case 1:
    CountsFig();
    break;

    case 2:
    MultiplN();
    break;

    case 3:
    Console.WriteLine(RandomNArray());
    break;
    
    default
    Console.WriteLine("Номер задачи введен некорректно");
    break;
}

void Prompt(string message)     // Метод запроса
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Напишите программу, которая принимает на вход число и выдает количество цифр в этом числе 
//  456  -- 3
//  78 --   2
//  24561  --- 5

CountsFig();

// Напишите программу, которая принимает на вход число и  выдает произведение чисел от 1 до N
//  4 -- 24
//  5 -- 120

MultiplN();

// Задача 30
// Напишите программу, которая выводит массив из 8 элементов, заполненных нулями и единицами в случайном порядке
//  [1,0,1,1,0,1,0,0]

Console.WriteLine(RandomNArray());




void CountsFig()   // функция, которая принимает на вход число и выдает количество цифр в этом числе
{
    int number = GetNumber();
    int count = CountFigures(number);
    Console.WriteLine($"Count figures in number {number} =  {count}");
}

void MultiplN()   // функция, которая принимает на вход число и  выдает произведение чисел от 1 до N
{
    int number = GetNumber();
    int miltypl = MultiPly(number);
    Console.WriteLine($"Multiplication of numbers from 1 to {number} =  {miltypl}");
}

int GetNumber()     //  функция вывода вводимых данных в виде int
{
    Console.WriteLine("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountFigures(int number)    // функция вывода количества цифр в числе в виде int
{
    char[] number_ = number.ToString().ToCharArray();
    int counts = number_.Length;
    return counts;
}

int MultiPly(int number)    // функция вывода произведениz чисел от 1 до N
{
    int multResults = 1;
    for (int i = 1; i <= number; i++)
    {
        multResults *= i;
    }
    return multResults;
}

string  RandomNArray()      // определение случайного массива чисел из N элементов
{
    Console.WriteLine("Input number of figures in array: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int[] arr = new int [N];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0,2);
        // Console.Write(arr[i] + " ");
    }
    string array = String.Join(" ", arr);  
    return array;
}