int[] masiv = new int[12]; // объявляем массив
int s = 0;
Random rand = new Random(); // метод

// заполняем массив случайными числами
 for (int i = 0; i < masiv.Length; i++)
      {
          masiv[i] = rand.Next(0,50);
      }           
            
 //Вывод массива         
 Console.Write("Массив: ");
 for(int i = 0; i<masiv.Length; i++)
Console.Write(" " + masiv[i]); 

for(int i = 0; i<masiv.Length; i++)
{
if (i%2!=0)
s = s+masiv[i];
}
Console.WriteLine(".");
Console.WriteLine($"Сумма чисел: {s}");
