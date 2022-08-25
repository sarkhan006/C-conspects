/*Task 4 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.Write("Input a - ");
int a = Convert.ToInt32(Console.ReadLine());


Console.Write("Input number b - ");
int b = Convert.ToInt32(Console.ReadLine());

if( a >  b)
{
    Console.Write("the biggest number is : " +  a);
}
else 
{ 
    Console.Write("the biggest number is : " +  b);
}
*/


/* Task 5 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 */

 /*
Console.Write("Input First Number - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number Second Number - ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number Third Number - ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a ;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c ;
}
Console.Write("The biggest number is : " + max );
*/

/*  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/*
Console.Write("Provide  number - ");
int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0) 
{
Console.Write("This number is OK ");
}
else
{
    Console.Write("This number is NOT OK ");
}
*/

/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*
Console.Write("Provide number - ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while( current <= number )
{
    current =current + 1;
    if (current %2 == 0) 
{
    Console.Write( current + " ");
}
}
*/








