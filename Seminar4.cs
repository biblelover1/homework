//HW Seminar 4 Exercise 1: Напишите цикл, который принимает на вход два числа (A и B) 
//              и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// Console.WriteLine("Enter base: ");
// int baseNumb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter grade: ");
// int gradeNumb = Convert.ToInt32(Console.ReadLine());
// int res = Grade(baseNumb, gradeNumb);
// Console.WriteLine($"Result is {res}");

// int Grade(int a, int b){
    int sum = a;
    for(int i = 2; i <= b; i++){
    sum = a*sum;    
    }
    return sum;
// }


// Exercise 2: Напишите программу, которая 
//  принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// void Sum(int num){
//     int sum = 0;
//     int a = 0;
//     while(num > 0)
//     {
//         a = num % 10;
//         sum = sum + a;
//         num = num / 10;
//     }
//         Console.WriteLine($"Sum of signs is {sum}");
// }
// Console.WriteLine("Enter number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Sum(numb);


//Exercise 3: Напишите программу, 
//которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// Console.WriteLine("Enter number ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[numb];
// ShowArray(array, numb);

// void ShowArray(int[] arr, int length){
//     int lenght = arr.Length;
//     for(int i = 0; i < lenght; i++){
//         arr[i] = new Random().Next(0, 9);
//         Console.Write($"{arr[i]}, ");
//     }
// }




 
