// HW2
// Exercise 10

// int Numb(int numb1){
//     int dec = (numb1 / 10) % 10;
//     return dec;
// }
// Console.Write("Enter three signs number: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// int result = Numb(numb1);
// Console.WriteLine ($"{result} - second sign");


// Exercise 13
// int Path(int numb)
// {
//     if (numb < 100 && numb > 100000){
//     int x = (-1);
//     return x;
//     }

//     else if (100 <= numb && numb < 1000){
//     int a = numb % 10;
//     return a;
//     }

//     else if (1000 <= numb && numb < 10000){
//     int b = numb / 10 % 10;
//     return b;
//     }

//     else if (10000 <= numb && numb < 100000){
//     int d = (numb / 100) % 10;
//     return d;
//     }

//     else{ 
//         int x = (-1);
//         return x;
//     }
// }
// Console.WriteLine("Enter number befor 100000: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int result = Path(numb);
// Console.WriteLine($"Third number: {result}");


// Exercise 15
// void Day(int numm)
// {
//     if(numm == 1)
//     Console.WriteLine("no");

//     if(numm == 2)
//     Console.WriteLine("no"); 

//     if(numm == 3)
//     Console.WriteLine("no");

//     if(numm == 4)
//     Console.WriteLine("no"); 

//     if(numm == 5)
//     Console.WriteLine("no"); 

//     if(numm == 6)
//     Console.WriteLine("yes"); 

//     if(numm == 7)
//     Console.WriteLine("yes"); 
// }
// Console.WriteLine("Enter number from 1 to 7 to know if day is holiday: ");
// int numm = Convert.ToInt32(Console.ReadLine());
// Day(numm);

// Exercise 4 (previous HW)
// Console.Write("Enter first number: ");
// int numm0 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int numm1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter third number: ");
// int numm2 = Convert.ToInt32(Console.ReadLine());
// int max = numm0;
// if(numm1 > max) max = numm1;
// if(numm2 > max) max = numm2;
// Console.Write($"Max number is {max}");

//                  Exxercise 8 (previous HW)
// Console.WriteLine("Enter number: ");
// int numm = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while(i < numm){
//      Console.WriteLine($"{i}");
//      i = i + 2;
// }