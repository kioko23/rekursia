//  //Задача №1: Задайте значения M и N. Напишите программу, 
//  //которая выведет все натуральные числа в промежутке от M до N. 
//  //Использовать рекурсию, не использовать циклы.

 void NaturalNumbers(int m, int n)
 {
   if(m <= n)
   {
      Console.WriteLine(m);
      NaturalNumbers( m + 1,  n);
   }
      

 }
 NaturalNumbers(5,15);  


// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.
static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return -1;

}

Console.Write(Akkerman(0, 5));


//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void PrintArrayReverse(int[] array, int index)
{
    if(index >= 0)
    {
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
       
    
}

 int[] array = {5, 4, 3, 2, 1};
 PrintArrayReverse(array, array.Length - 1);













