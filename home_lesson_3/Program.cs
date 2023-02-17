// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// 3 -- 1,8,27
// 5 -- 1,8,27,64,125

static int  Output_of_result(string message)
{ 
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Home_lesson_3_3();

static void Home_lesson_3_3()
{
    int number = Output_of_result("Введите число больше 0");
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            System.Console.Write($"{Math.Pow(i, 3)}\t");
        }
    }
    else 
        System.Console.WriteLine("Ввод некорректен. Скорректируйте ввод данных");
}