// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве
// А(3,6,8); В(2,1,-7)  -- 15,84
// А(7,-5,0); В(1,-1,9)  -- 11,53

Console.WriteLine("Введите координаты точки А (x,y,z)"); 
double Ax = Convert.ToInt32(Console.ReadLine()); 
double Ay = Convert.ToInt32(Console.ReadLine()); 
double Az = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты точки В(x,y,z)"); 
double Bx = Convert.ToInt32(Console.ReadLine()); 
double By = Convert.ToInt32(Console.ReadLine());  
double Bz = Convert.ToInt32(Console.ReadLine());  
double result = Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2) + + Math.Pow(Bz-Az, 2)); 
Console.WriteLine($"Координаты A: {Ax}, {Ay}, {Az}, координаты В: {Bx}, {By},{Bz}, расстояние между точками: " + result);
