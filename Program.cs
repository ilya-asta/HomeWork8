// _____________Домашняя работ____________________________
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


//  Console.WriteLine("Введите кол-во строчек");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во колонок");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows,colomns];

// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10); 
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
//  void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) -1 ;k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// GetArray();
// PrintArray();
// ChangeArray();
// Console.WriteLine("____________");
// PrintArray();


// ____________________Задание 2___________________________________________________
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите кол-во строчек и столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int [rows,rows];

// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10); 
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// int ChangeArray(int[,] array)
// {
//     int index = 0;
//     int min = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i==0)
//                 min = min + array[i,j];
//             else
//                 sum = sum + array[i,j];
//         }

//         if (i==0)
//         {
//             index = i;
//         }
//         else if (min>=sum)
//         {
//             min = sum;
//             index = i;  
//         }
//     }

//     return index;
// }

// GetArray();
// PrintArray();
// int minIndex = ChangeArray(array);
// Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minIndex + 1}");

// ________________________________Задание 3________________________________________________________

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//  int[,] array1 = new int [2,2];

// void GetArray()
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             array1[i,j] = new Random().Next(0,10); 
//             Console.Write(array1[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array2 = new int [2,2];
// void GetArray2()
// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             array2[i,j] = new Random().Next(0,10); 
//             Console.Write(array2[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array3= new int [2,2];

// void GetArray3()
// {
//     for (int i = 0; i < array3.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 sum += array1[i,k] * array2[k,j];
//             }

            
//             Console.Write((array3[i,j] = sum) + " ");
//         }
//         Console.WriteLine();
//     }
// }

// GetArray();
// Console.WriteLine("___________________");
// GetArray2();
// Console.WriteLine("___________________");
// GetArray3();




// ________________________________Задача 4__________________________________
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] array = new int[2,2,2];

// void FillArray(int [,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k,i,j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//             }
//         }
//     }

// }

// FillArray(array);
// PrintIndex(array);




// ______________________Задача 5______________________________
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] array = new int[4,4];
// int count = 0;
// int i = 0;
// int j = 0;

// for (j = 0; j < array.GetLength(1); j++)
// {
//     array[i,j] = 1 + count;
//     count++;
// }

// j =3;
// for (i = 1; i < array.GetLength(0); i++)
// {
//     array[i,j] = 1 + count;
//     count++;
// }

// i =3;
// for (j = 2; j >= 0; j-=1)
// {
//     array[i,j] = 1 + count;
//     count++;
// }

// j=0;
// for (i = 2; i >= 1; i-=1)
// {
//     array[i,j] = 1 + count;
//     count++;
// }
// i =1;
// for (j = 1; j <=2; j++)
// {
//     array[i,j] = 1 + count;
//     count++;
// }

// i=2;
// for (j = 2; j >=1 ; j-=1)
// {
//     array[i,j] = 1 + count;
//     count++;
// }

// for (i = 0; i < array.GetLength(0); i++)
// {
//     for (j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");

