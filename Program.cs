// int CutNumber (int number)
// {
//     int sot = number/100;
//     int ed = number%10;
//     int result = sot * 10 + ed;
//     return result;
// }
// Console.Write("input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int newNum = CutNumber(num);
// Console.WriteLine("new version of " + num + " ist " + newNum);


//--------------------------------------------------------------------

//Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int y = 1000;
int CutNumber (int number)
{
    if (number > 99 && number < y)
    {
        int result = number/10%10;
        return result;
    } 
    else 
    {
        Console.Write("wrong number!! input a number: ");
        return number;
    }  
}

Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(number);
Console.WriteLine("new version of " + number + " ist " + newNum);
*/

//---------------------------------------------------------------

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа.

/*

int CutNumber (int number)
{
   if (number>99)
   {
    int result = number/100%10;
    return result;
   }
   else
    {
        Console.Write("wrong number!! input a number: ");
        return number;
    }  
}



Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(number);
Console.WriteLine("new version of " + number + " ist " + newNum);

*/


// Задача 3.01: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число обозначающий день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// int num1 = 5;
// int num2 = 7;
// int zero = 0;


// if(day < num2 || day > zero)
// {
//     if(day > num1)
//     {
//         Console.WriteLine($"да");
//     }
//      else
//     {
//         Console.WriteLine($"нет");
//     }
// }
// else
// {
//     Console.WriteLine($"введите другое число");
// }

// Задача 3.02: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным. 
/*
bool day (int N)
{
    bool result = false;
    if (N == 6 || N == 7)
    {
        result = true;
    }
    return result;
}
Console.Write("Введите число обозначающий день недели: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(day(N));























// bool IsDivisible (int number1, int number2)
// {
//     return ((number2 % number1) == 0);
// }

// Console.Write("Enter number1: ");
// int number1 = Convert.ToInt32(Console.Rea
/*
bool IsSquare (int number1, int number2)
{
    return (number1 == number2 * number2 || number2 == number1 * number1);    
}

Console.Write("введите цифру, обозначающую день недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsSquare(number1, number2));
*/