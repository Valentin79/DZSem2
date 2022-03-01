// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

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


if(array.Length < 3) 
{
    Console.WriteLine("Третьей цифры нет.");
}
else Console.WriteLine($"Третья цифра: {array[2]}");

