Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a<10)
{
    Console.WriteLine(a);
}
while (a>0)
{
  int Digit = a%10;
  a/=10;
  if (a>0)
  {
    Console.Write (Digit +",");
  }  
  else
  {
    Console.WriteLine(Digit);
  }
}