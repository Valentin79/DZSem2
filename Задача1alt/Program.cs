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

if(array.Length < 2) 
{
    Console.WriteLine("Второй цифры нет.");
}
else Console.WriteLine($"Вторая цифра: {array[1]}");