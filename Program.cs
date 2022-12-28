/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

// int SumOfElements(int m, int n)
// {
//     if(Math.Min(m,n) < Math.Max(m,n)-1)
//     return SumOfElements(Math.Min(m,n)+1, Math.Max(m,n))+(Math.Min(m,n)+1); 
//     else return 0;
// }


// Console.WriteLine("Enter first number: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// int res = SumOfElements(numb1, numb2);
// Console.WriteLine(res);

/*
Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
*/


// string Binary(int m)
// {
//     string s = String.Empty;
//     if(m>0) return Binary(m/2) + (s + m%2); 
//     else if(m<0) return Binary(m/2) + (s + (-m%2));
//     return s;
// }

// char [] ChangeSymbols(string s)
// {
//     char [] arr = s.ToCharArray();
//     int length = arr.Length;
//   

//     for(int i=1; i < length; i++)
//     {
//         if(arr[i] == '0') arr[i] = '1';
//         else arr[i] = '0';
//     }
//     return arr;
// }



// Console.WriteLine("Enter number: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// if(numb1 > 0){
//     string res = Binary(numb1);
//         Console.WriteLine(res);
// }
// else{
//     string res = Binary(numb1);
// char [] newArray = ChangeSymbols(res);
// string newNumber = new string(newArray);
// short number = Convert.ToByte(newNumber);
// short p = Convert.ToByte(1);
// int sum = number + p;
//  Console.WriteLine(sum);
// }
