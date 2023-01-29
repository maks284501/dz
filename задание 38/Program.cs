int[] masiv = new int[10]; // объявляем массив
int max = 0;
int min = 50;
int r = 0;

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
if (masiv[i]>max)
max=masiv[i];
}
for(int i = 0; i<masiv.Length; i++)
{
if (masiv[i]<min)
min=masiv[i];
}
r=max-min;
Console.WriteLine(".");
Console.WriteLine($"Минимальное: {min}");
Console.WriteLine($"Максимальное: {max}");
Console.WriteLine($"Разница чисел: {r}");
