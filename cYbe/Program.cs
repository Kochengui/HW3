
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int kyb = Convert.ToInt32(Console.ReadLine());

void CYbe(int[] cubkey)
{
  int index = 0;
  int length = cubkey.Length;
  while (index <  length){
    cubkey[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}

void PrintArry(int[] tell)
{
  int length = tell.Length;
  int index = 0;
  while(index < length){
    Console.Write(tell[index]+ " ");
    index++;
  }
} 

int[] arry = new int[kyb+1];
CYbe(arry);
PrintArry(arry);