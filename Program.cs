﻿//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые 
//числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// int count = -x;
// while (count <= x)
// {
//    Console.Write(count+" ");
//    count = count +1;
// }

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// int y=-x;
// while (y<x)
// {
//    // Console.Write($"{y}, ");
//     Console.Write(y + ", ");

//     y=y+1;
// }
// Console.WriteLine(y);

//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y = x % 10;
Console.WriteLine(y);


