// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа

int num  = new Random().Next(100,1000); // [100; 1000)
Console.WriteLine("Случайное трехзначное число  -  " + num); 

// int a = num / 100;
// int b = num % 10;
// Console.WriteLine("Итоговое двузначное число  - " + a + b);

char[] arr = num.ToString().ToCharArray(); 
Console.Write($"First {arr[0]}, Third {arr[2]}");
