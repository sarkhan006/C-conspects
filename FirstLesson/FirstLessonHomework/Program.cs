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


