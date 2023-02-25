// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

 // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 

 // 6, 1, 33 -> [6, 1, 33]
System.Console.Write("Введите кол-во элементов массива: "); 
 int n = Convert.ToInt32(Console.ReadLine()); 
 System.Console.WriteLine(); 

 int[] arr = new int[n]; 

 for (int i = 0; i < arr.Length; i++) 
 { 
     System.Console.Write($"Введите элемент массива № {i + 1}: "); 
     arr[i] = Convert.ToInt32(Console.ReadLine()); 
     System.Console.WriteLine(); 
 } 

 Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
