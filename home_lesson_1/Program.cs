// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -- нет
// 23432 -- да
// 12821 -- да

Home_lesson_1_3();

static void Home_lesson_1_3()
{
    int number5 = Output_of_result("Введите пятизначное число больше 0");
    char[] arr5 = number5.ToString().ToCharArray(); 
  
    if (number5 < 0 || arr5.Length != 5)
        Console.WriteLine("Ввод некорректен / Incorrect input");
    else
    {
        if ((arr5[0] == arr5[4]) && (arr5[1] == arr5[3]))
            Console.WriteLine($"Введенное число - {number5} - ПАЛИНДРОМ!");
        else
            Console.WriteLine($"Введенное число - {number5} -  не является палиндромом");
    }
}

static int  Output_of_result(string message)
{ 
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
