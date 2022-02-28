// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

int[] array = new int[3];
int i = 0;
while(i < 3)
{
    array[i] = new Random().Next(0, 9);
    i++;
}

Console.WriteLine($"{array[0]}{array[1]}{array[2]} --> {array[0]}{array[2]}");
