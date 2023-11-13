
/* Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} */


// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(num1 == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(num1 == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(num1 == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(num1 == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(num1 == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(num1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// else
// {
//     Console.WriteLine("Такого дня нет");
// }


// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 < 0)
// {
//     int num = -1 * num1;

//     while(num1 <= num)
//     {
//           Console.WriteLine(num1);
//           num1 = num1 + 1;
//     }
// }
// else
// {
//     int negNum = -1 * num1;

//     while(negNum <= num1 + 1)
//     {
//         Console.WriteLine(negNum);
//         negNum = negNum + 1;
//     }

// }



Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 < 100)
{
    Console.WriteLine("Введите другое число");
}
else if(num1 > 999)
{
    Console.WriteLine("Введите другое число");
}
else
{
int result = num1 % 10;
Console.WriteLine(result);
}









