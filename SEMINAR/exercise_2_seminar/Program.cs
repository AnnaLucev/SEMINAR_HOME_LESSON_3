// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек 
// в этой четверти (x и y).


Exercise_2_seminar_3();

static void Exercise_2_seminar_3()
{
    int number = Output_of_result("Введите номер четверти (1, 2, 3, 4)");
    switch (number)
        {
            case 1:
            System.Console.WriteLine("Координаты x > 0 и y > 0");
            break;
            case 2:
            System.Console.WriteLine("Координаты x < 0 и y > 0");
            break;
            case 3:
            System.Console.WriteLine("Координаты x < 0 и y < 0");
            break;
            case 4:
            System.Console.WriteLine("Координаты x > 0 и y < 0");
            break;
            default:
            System.Console.WriteLine("Такой четверти нет. Скорректируйте ввод данных");
            break;
        }

}

static int  Output_of_result(string message)
{ 
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}