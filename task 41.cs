//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(string [] num  )


{
    

 for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine("ВВедите число");
    num[i] =Console.ReadLine();
    
       
}

}
    
void PrintArray(string[] num )
{

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");
    
    
}
Console.WriteLine();
}
void znach (string [] num , int count)
{
    
    int[] ints = Array.ConvertAll(num, s => int.TryParse(s, out var x) ? x : -1);
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > 0)
        {
          count ++;
        }
    }
    Console.WriteLine("Количество чисел болше нуля = " + count);
}
Console.WriteLine("Введите количество чисел");
 int M = Convert.ToInt32(Console.ReadLine());
string [] numbers =  new string [M];

int kol = 0;
 FillArray(numbers);
 PrintArray(numbers);
znach(numbers, kol);
 