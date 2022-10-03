void Zadacha0025()
  {
 /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
 возводит число A в натуральную степень B. 
    3, 5 -> 243 (3⁵)
    2, 4 ->16 */

  Console.Clear();

  Console.Write ("Первое число: ");
  int a = int.Parse(Console.ReadLine());

  Console.Write ("Второе число: ");
  int b = int.Parse(Console.ReadLine());

  int result = 1;
  for (int i = 1; i<=b; i++)

  result *=a;

  Console.WriteLine ($"Равно: {result}");

  }

void Zadacha0027()
  {
  /* Задача 27
  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 452 -> 11
 82 -> 10
 9012 -> 12 */

  Console.Clear();

  Console.Write ("Введите число: ");
  int num = int.Parse(Console.ReadLine());
  int sum = 0;
  while (num>0)
  {
    sum += num%10;
    num /=10;
  }
  
  Console.Write ($"{sum}");

  }

void Zadacha0029()
  {
 /* Задача 29
 Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 6, 1, 33 -> [6, 1, 33] */


  int n;
  Console.WriteLine("введите n");
  n = Convert.ToInt32(Console.ReadLine());
  int [] x = new int [n];
  for (int i = 0; i < n; i++)
    {
        Console.WriteLine("введите {0} элемент массива",i);
        x[i] = Convert.ToInt32(Console.ReadLine());
    }  
  Console.ReadLine();  
  foreach (int i in x)
    {
        Console.Write(i+ "\t");
    }  


 }



Zadacha0025();
//Zadacha0027();
//Zadacha0029();


