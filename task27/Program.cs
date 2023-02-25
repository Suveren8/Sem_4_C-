// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

 // 452 -> 11 

 // 82 -> 10 

 // 9012 -> 12
int Ftor(int number) 
 { 

     int bufer = Math.Abs(Convert.ToInt32(number)); 
     int i = 1; 
     int result = 0; 

     while(i < bufer) 
     { 
         result = result + (bufer % (i*10))/i; 
         i *=10; 
     } 

     return result; 
 } 

 Console.Write("Введите число: "); 
 int burger = Convert.ToInt32(Console.ReadLine()); 

 Console.Write($"Итого: {Ftor(burger)}"); 
