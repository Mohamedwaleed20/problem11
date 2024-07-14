// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
Console.WriteLine("enter the arr : ");
string arr = Console.ReadLine();
int[] numbers = arr.Split(',').Select(int.Parse).ToArray();
int[] res = new int[numbers.Length];
Console.Write("[ ");
for (int i = 0; i < numbers.Length; i++)
{
    int product = 1;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (i != j)
        {
            product *= numbers[j];
        }
    }
    res[i] = product;
    Console.Write(res[i]);
    Console.Write(", ");
}
Console.Write(" ]");
Console.ReadLine();