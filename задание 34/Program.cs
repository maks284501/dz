 int[] masiv = new int[12]; // объявляем массив
int s = 0;
Random rand = new Random(); // метод

// заполняем массив случайными числами
 for (int i = 0; i < masiv.Length; i++)
      {
          masiv[i] = rand.Next(100, 999);
      }           
            
 //Вывод массива         
 Console.Write("Array: ");
 for(int i = 0; i<masiv.Length; i++)
Console.Write(" " + masiv[i]); 

for(int i = 0; i<masiv.Length; i++)
{
if (masiv[i]%2==0)
s = s+1;
}
Console.WriteLine(".");
Console.WriteLine($"Сумма четных: {s}");