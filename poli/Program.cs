Console.Write("Введите число: ");
string? number = Console.ReadLine();

void PaliorNopali(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - это не палиндром.");
}

if (number!.Length == 5)
{
  PaliorNopali(number);
}
else Console.WriteLine($"Введите занова!");
