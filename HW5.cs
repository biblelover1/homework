/*HW5 Exercise 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

// Console.WriteLine("Enter size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newarray = NewArray(size);
// ShowArray(newarray);
// Console.WriteLine();
// Count(newarray);
// int [] NewArray(int size){
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// void ShowArray(int [] array){
//     for(int i = 0; i < array.Length; i++){
//        Console.Write($"{array[i]} ");
//     }
// }

// void Count(int [] array){
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i]%2==0)
//         sum++;
//     }
//     Console.WriteLine($"{sum}");
// }


/* Exercise З5: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
*/

// int size = 123;
// int [] createdArray = NewArray(size);
// // ShowArray(createdArray);
// Console.WriteLine();
// PartArray(createdArray);

// int [] NewArray(int size){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(0, 1000);
//     }
//     return array;
// }
// // void ShowArray(int[] array){
// //     for(int i=0; i < array.Length; i++) 
// //     Console.Write($"{array[i]} ");
// //}

// void PartArray(int [] array){
//     int sum = 0;
//     for(int i=0; i < array.Length; i++)
//     if(array[i] >= 10 && array[i] < 100){
//     sum++;
//     }
//     Console.WriteLine($"{sum}");
// }

/* Exercise З6: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/
// int size = 10;
// int [] createdArray = NewArray(size);
// ShowArray(createdArray);
// Console.WriteLine();
// SumOfNumbers(createdArray);

// int [] NewArray(int size){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for(int i=0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
//     }   
// }
// void SumOfNumbers(int[] array){
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(i % 2 == 0){
//             sum = sum + array[i];
//         }
//     }
//     Console.WriteLine($"{sum}");
// }

/* Exercise З7: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
*/

// int size = 11;
// int [] numbers = Numbers(size);
// ShowArray(numbers);
// Count(numbers);
// int [] Numbers(int size){
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(1, 6);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for(int i=0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
//     } 
//     Console.WriteLine();  
// }
// void Count(int [] array){
//     int a = 1;
//     int mult = 0;
//     for(int i = 0; i < (array.Length)/2; i++){
//     mult = mult + array[i]*array[^a];
//     a = a + 1;
//     }
//     Console.WriteLine($"{mult}");
// }


/* Exercise З8: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

// int size = 6;
// double [] numbers = Massive(size);
// ShowArray(numbers);
// double a = MIN(numbers);
// double b = MAX(numbers);
// Console.Write($"Max - min = {b-a}");

// double [] Massive(int size){
//     Random rand = new Random();git
//     double [] array = new double [size];
//     for(int i = 0; i < size; i++){
//         array[i] = rand.Next(-10, 100);
//     }
//     return array;
// }
// void ShowArray(double[] array){
//     for(int i=0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
//     } 
//     Console.WriteLine(); 
// }
// double MIN(double [] array){
//     int i = 0;
//     double minNumber = array[i];
//         for(int j = i+1; j < array.Length; j++){
//                 if(minNumber > array[j]){
//                 minNumber = array[j];
//                 }
//         } 
//     return minNumber;  
// }

// double MAX(double [] array){
//     int i = 0;
//     double maxNumber = array[i];
//         for(int j = i+1; j < array.Length; j++){
//             if(maxNumber < array[j]){
//             maxNumber = array[j];
//             }       
//         } 
//         return maxNumber;
// }