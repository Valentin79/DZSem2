//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
string str = a.ToString();
int[] array = new int[str.Length];
int i = 0;
while(i < str.Length)
{
    array[i] = int.Parse(str[i].ToString());
    i++;
}
Console.WriteLine(array[1]);
