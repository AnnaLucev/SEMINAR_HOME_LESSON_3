// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел  от 1 до N.  
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

static int  Output_of_result(string message)
{ 
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Exercise_3_seminar_3();

static void Exercise_3_seminar_3()
{
    int number = Output_of_result("Введите число больше 0");
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            System.Console.Write($"{i * i}\t");
        }
    }
    else 
        System.Console.WriteLine("Ввод некорректен. Скорректируйте ввод данных");
}