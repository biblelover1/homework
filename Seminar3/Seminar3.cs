
// HW Exercise 1 Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom(int numb)
// {
//     int a = numb / 10000;
//     int e = numb % 10;
//     int b = (numb / 1000) % 10;
//     int d = (numb / 10) % 10;
//     int c = 100000;
//     if(e == a && b == d){
//         Console.Write("Number is palindrom");
//     }
//     else if(numb > c){
//         Console.Write("Error");
//     }
//     else{
//         Console.Write("Number is not palindrom");
//     }
// }
// Console.Write("Enter 5-sign number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Palindrom(numb);

// Exercise 2: Напишите программу, которая принимает на вход 
//             координаты двух точек и находит расстояние между ними в 3D пространстве.

// void Coordinate(int x1, int y1, int z1, int x2, int y2, int z2){
//     double result = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
//     Console.Write($"Distans is {result}");
// }
// Console.Write("Enter coordinate x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Coordinate(x1, y1, z1, x2, y2, z2);

// Second variant
// void Coordinate(int x1, int y1, int z1, int x2, int y2, int z2){
//     double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((y1-y2), 2));
//     Console.WriteLine($"Distans is {result}");
// }
// Console.Write("Enter coordinate x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Coordinate(x1, y1, z1, x2, y2, z2);

// Exercise 3 Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

// void Cube(int numb){
//     int i;
//     for(i = 1; i < numb; i++){
//     double result = Math.Pow(i,3);
//     Console.Write($"{result + " "}");
//     }
// }
// Console.WriteLine("Enter number ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Cube(numb);