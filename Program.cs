/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

// int [,] New2dArray(int lines, int column)
// {
//     int [,] array = new int [lines, column];
//     for(int i =0; i < lines; i++){
//         for(int j = 0; j < column; j++){
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i =0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//         Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }    


// int [,] Order2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1)-1; j++){
//             for(int k = j+1; k < array.GetLength(1); k++)
//                 if(array[i,j] > array[i,k]){
//                     int temp = array[i,j];
//                     array[i,j] = array[i, k];
//                     array[i,k] = temp;
//             }

//         }
//     Console.WriteLine();
//     }
//     return array;
// }

// Console.WriteLine("Enter the number of lines: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] array = New2dArray(lines, columns);
// Show2dArray(array);
// int [,] newarray = Order2dArray(array);
// Show2dArray(newarray);

/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

// int[,] New2dArray(int lines, int column)
// {
//     int[,] array = new int[lines, column];
//     for (int i = 0; i < lines; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumOfRows(int [,] array, int j)
// {
//     int sum =0;
//     for(int i = j; i < j+1; i++)
//     {
//         for(int l = 0; l < array.GetLength(1); l++)
//         {
//             sum = sum + array[i,l];
//         }
//     }
//     return sum;
// }
// int ChooseRow(int row1, int row2, int row3, int row4)
// {
//     int [] arr = new int [] {row1,row2, row3, row4};
//     int min = row1;
//     int i =0;
//     for(i = 0; i < arr.Length; i++)
//     {
//         if(arr[i]< min) min = arr[i];
//     }
//     return min;
// }  

// void ShowRow(int mean,int row1, int row2, int row3, int row4)
// {
//     if(mean == row1) Console.WriteLine("1 row");
//     else if(mean == row2) Console.WriteLine("2 row");
//     else if(mean == row3) Console.WriteLine("3 row");
//     else if(mean == row4) Console.WriteLine("4 row");
// }

// int [,] array = New2dArray(4,4);
// Show2dArray(array);
// int res0 = SumOfRows(array, 0);

// int res1 = SumOfRows(array, 1);

// int res2 = SumOfRows(array, 2);

// int res3 = SumOfRows(array, 3);

// int arr = ChooseRow(res0, res1, res2, res3);
// ShowRow(arr, res0, res1, res2, res3);


/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

// int [,] First2dArray(int lines, int column)
// {
//     int [,] array = new int [lines, column];
//     for(int i =0; i < lines; i++){
//         for(int j = 0; j < column; j++){
//             array[i,j] = new Random().Next(3,6);
//         }
//     }
//     return array;
// }

// int [,] Second2dArray(int lines, int column)
// {
//      int [,] array = new int [lines, column];
//     for(int i =0; i < lines; i++){
//         for(int j = 0; j < column; j++){
//             array[i,j] = new Random().Next(5,8);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i =0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//         Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }    

// void MultiplicationOfArray(int [,] array, int [,]newArray)
// {
//     int [,] multArray = new int [2,2];
//             multArray[0,0] = (array[0,0]*newArray[0,0])+ (array[1,0]*newArray[0,1]);
//             multArray[0,1] = (array[0,1]*newArray[0,0])+ (array[1,1]*newArray[0,1]);
//             multArray[1,0] = (array[0,0]*newArray[1,0])+ (array[0,1]*newArray[1,1]);
//             multArray[1,1] = (array[0,1]*newArray[1,1])+ (array[1,0]*newArray[1,1]);
//             Console.WriteLine($"{multArray[0,0]} {multArray[0,1]}");
//             Console.WriteLine($"{multArray[1,0]} {multArray[1,1]}");
// }


// int [,] array = First2dArray(2,2);
// int [,] secondArray = Second2dArray(2,2);
// Show2dArray(array);
// Console.WriteLine();
// Show2dArray(secondArray);
// MultiplicationOfArray(array, secondArray);




/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

// int [] NewArray(int size)
// {
//     int temp = 0;
//     int d=1;
//     int [] array = new int [size];
//     array[0] = 10;
//     for(int i=1; i<size; i++)
//     {
//         temp = new Random().Next(10,55);
//         array[i] = temp;
//         for(int e = 0; e < i; e++)
//         {
//             if(array[e] == array[i]) array[i] = 100-e;
//         }

//     }
//     return array;
// }
//  void ShowArray(int [] array)
//  {
//     for(int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//  }

// void Make3dArray(int [] array, int x, int y, int z)
// {
//     int [, ,] new3dArray = new int [x,y,z];
//     int e = 0;
//     for(x=0; x < new3dArray.GetLength(0); x++)
//     {
//         for(y=0; y < new3dArray.GetLength(1); y++)
//         {
//             for(z=0; z < new3dArray.GetLength(2); z++, e++)
//             {
//                 new3dArray[x,y,z] = array[e];
//                 Console.WriteLine($"{new3dArray[x,y,z]}{(x,y,z)} ");
//             }
//         }
//     }
// }
// Console.WriteLine("Length: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Width: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Height: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int size = x*y*z;
// int [] newArray = NewArray(size);
// ShowArray(newArray);
// Make3dArray(newArray, x,y,z);
