// Все задачи оформляем методами!! Задача 27 решается без применения строковой типизации!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Main ()
{
Console.Clear();
Console.WriteLine("Start");
Console.WriteLine($"{Exponentiation(GetNumber(), GetNumber())}");
Console.WriteLine("End");
}
int GetNumber()
{
Console.Write("Введите число: "); 
return int.Parse(Console.ReadLine());

}
int Exponentiation(int NumberOne, int NumberTwo)
{
   int result = 1;
   for(int i =0; i < NumberTwo; i++)
{
    result *= NumberOne; 
}
    return result;
    
}
Main ();