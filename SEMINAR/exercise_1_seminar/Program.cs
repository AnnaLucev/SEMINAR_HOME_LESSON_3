// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] points = new int[2];
for (int i = 0; i < points.Length; i++)
{   
    while (true)
    {
        points[i] = Convert.ToInt32(Console.ReadLine());
        if (points[i] != 0)
            break;
        else
            Console.WriteLine("Ввод некорректен / Incorrect input");
    } 
}
if (points[0] > 0 && points[1] > 0)  //  x > 0 и y > 0
    Console.WriteLine("Точка находится в 1 четверти плоскости");
else if (points[0] < 0 && points[1] > 0)  //  x < 0 и y > 0
    Console.WriteLine("Точка находится во 2 четверти плоскости");
else if (points[0] < 0 && points[1] < 0)  //  x < 0 и y < 0
    Console.WriteLine("Точка находится в 3 четверти плоскости");
else   //  x < 0 и y > 0
    Console.WriteLine("Точка находится в 4 четверти плоскости");