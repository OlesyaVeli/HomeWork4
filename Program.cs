/*Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
/*
int Metod1(int numberA, int numberB)
{
   int result = 1;    
   for(int i = 1; i <= numberB; i++)
   {
       result = result * numberA;
   }
   return result;       
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Metod1(a,b);
Console.WriteLine($"Число {a} в степени {b} равно " + result);
*/


/*Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/
/*
int Metod2(int num)
{
    int sum = 0;
    while(num > 0)
    {
        int num1 = num % 10; 
        num = num / 10;
        sum = sum + num1;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Metod2(a);
Console.WriteLine($"Сумма цифр числа {a} равна " + result);
*/



/*Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/




    Console.WriteLine("Введите количество элеменов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
  


    


   
   
   



