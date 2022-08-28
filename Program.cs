/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
/*
/*
Console.Write("Please enter 3 digit number - ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Second digit is - " + stringNumber[1]);
*/

/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
Console.Write("Enter Number - ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("Third Number is - " + anyNumberText[2]);
}
else 
{
    Console.WriteLine("There is no third digit");

}
*/
