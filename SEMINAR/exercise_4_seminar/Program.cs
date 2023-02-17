// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1)   -> 5,09 
// A (7,-5); B (1,-1)   -> 7,21


// СПОСОБ 1
// System.Console.Write("Введите 4 числа - координаты точек A(x1, y1) и B(x2, y2)");
// int[] number = new int[4];
//
// for (int i = 0; i < number.Length; i++)
// {
//    number[i] = Convert.ToInt32(Console.ReadLine());
// }
// double distance = Math.Sqrt(Math.Pow((number[2]-number[0]), 2) + Math.Pow((number[3]-number[1]), 2));
// Console.WriteLine(distance);

// СПОСОБ 2
Console.WriteLine("Введите координаты точки А"); 
double Ax = Convert.ToInt32(Console.ReadLine()); 
double Ay = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите координаты точки В"); 
double Bx = Convert.ToInt32(Console.ReadLine()); 
double By = Convert.ToInt32(Console.ReadLine());  
double result = Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2)); 
Console.WriteLine($"Координаты A: {Ax}, {Ay}, координаты В: {Bx}, {By}, расстояние между точками: " + result);