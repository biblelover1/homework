// HW6 Exercise 1  Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.WriteLine("Enter size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int posNumb = SumPos(size);
// int SumPos(int size){
//     int sum = 0;
//     for(int i = 0; i < size; i++){
//     Console.WriteLine("Enter number: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     if(b > 0) sum++;
//     }
//     return sum;
// }
// Console.WriteLine($"The sum of positive numbers is: {posNumb}");


// Exercise 2:  Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

// Console.WriteLine("Enter k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter b1: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// ShowPoint(k1, b1 ,k2, b2);
// void ShowPoint(double k1, double b1, double k2, double b2){
//     double x = (b2-b1)/(k1-k2);
//     double y = k2*x + b2;
//     Console.WriteLine($"The point of connection is ({x};{y})");
// }