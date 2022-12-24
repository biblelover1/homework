
/*
#1 Заполнить вещественными числами
*/

// double [,] Fill2dArray(int rows, int colum){
//     double [,] array = new double [rows, colum];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colum; j++){
//             array[i,j] = new Random().NextDouble()*100; 
//         }
//     }
//     return array;
// }

// void Show2dArray(double [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.WriteLine($"{array[i,j]}  ");
            
//         } 
//     }   Console.WriteLine();
// }   
// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int colum = Convert.ToInt32(Console.ReadLine());
// double [,] array = Fill2dArray(rows, colum);
// Show2dArray(array);

/*
#2 показать элемент
*/

// int [,] Make2dArray(int lines, int col){
//     int [,] array = new int [lines, col];
//     for(int i = 0; i < lines; i++){
//         for(int j = 0; j < col; j++){
//             array[i,j] = new Random().Next(1, 7);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]}  ");
           
//         }
//         Console.WriteLine(); 
//     } 
// }

// void ShowElement(int [,] array, int rows, int colum){
//     int i = rows-1;
//     int j = colum-1;
//     Console.WriteLine($"{array[i,j]}");
// }



// Console.WriteLine("Enter the row of elem: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the column of elem: ");
// int colum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// if(rows > 5 || colum > 5){
//     Console.WriteLine(-1);
// }
// int [,] array = Make2dArray(5, 5);
// Show2dArray(array);
// Console.WriteLine();
// ShowElement(array, rows, colum);


/*
#3 Cумма элементов столбца
*/

// int [,] Make2dArray(int lines, int col){
//     int [,] array = new int [lines, col];
//     for(int i = 0; i < lines; i++){
//         for(int j = 0; j < col; j++){
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]}  ");
           
//         }
//         Console.WriteLine(); 
//     } 
// }

// void ShowSumOfElements(int [,] array, int rows){
//     int i = 0;
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for(i = 0; i < array.GetLength(0); i++)
//         {
//         sum += array[i,j];
//         }
//         Console.WriteLine($"{Math.Round(sum/rows, 2)}");
//     }
// }



// Console.WriteLine("Enter the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of columns: ");
// int colum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [,] array = Make2dArray(rows, colum);
// Show2dArray(array);
// Console.WriteLine();
// ShowSumOfElements(array, rows);