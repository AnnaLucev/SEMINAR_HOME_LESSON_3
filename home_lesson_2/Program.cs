// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// 645 -- 5
// 78 -- третьей цифры нет
// 32679 -- 6



Console.Write("Input number > 99  -- ");
int a = Convert.ToInt32(Console.ReadLine());
char[] arr = a.ToString().ToCharArray(); 
if (a > 99)
{ Console.WriteLine("Third figure inputing number is  -  " + arr[2]);}
else {Console.WriteLine("This is not a third figure. Correct the input");}
