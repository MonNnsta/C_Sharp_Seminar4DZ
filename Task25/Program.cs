
int Stepen(int numA, int numB)
{
  int res = 1;
  for(int i=1; i <= numB; i++)
  {
    res = res * numA;
  }
    return res;
}

  Console.Write("Input A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Stepen(numA, numB);
  Console.WriteLine("Solution = "+ exponentiation);
