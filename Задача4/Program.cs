// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число, обозначающее день недели (1-7)");
string a = Console.ReadLine();
int aa = int.Parse(a);

if( aa <= 0 || aa >= 8)
{
    Console.WriteLine("Это не день недели.");
}
if(aa > 5 & aa < 8)
    {
    Console.WriteLine("Это выходной =)"); 
    }
if(aa > 0 & aa < 6) 
{
    Console.WriteLine("Это будний день =(");
}
