//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

// int GetNumber(string welcome)
// {
//     System.Console.Write(welcome);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = GetNumber("Введите число num: ");  // abc

// if (num > 99 && num < 1000)
// {
//     System.Console.WriteLine($"Вторая цифра числа {num} равна {num / 10 % 10}");
// }
// else
// {
//     System.Console.WriteLine($"Вы ввели некорректное число {num}");
// }

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//int GetNumber(string welcome)
// {
//     System.Console.Write(welcome);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = GetNumber("Введите число num: ");  // abc

// if (num > 99)
// {
//     int temp = num;
//     while (temp > 999)
//     {
//         temp = temp / 10;
//     }
//     System.Console.WriteLine($"Третья цифра числа {num} равна {temp % 10}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//int GetNumber(string welcome)
//{
    //System.Console.Write(welcome);
  //  return Convert.ToInt32(Console.ReadLine());
//}
//int num = GetNumber("Введите день недели: ");

//if (num > 0 && num < 6)
//{
 //   System.Console.WriteLine("Это будный день. Поработайте ещё.");
//}
//else if (num == 6 || num == 7)
//{
  //  System.Console.WriteLine("Это выходной день. Можно отдохнуть.");
//}
//else
//{
  //  System.Console.WriteLine("Такого дня недели не существует");
//}
