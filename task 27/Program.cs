Console.WriteLine("Task 27. To find Sum of all digits of the number");
Console.Write ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  { int count = Convert.ToString(number).Length;
    int remainder = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        remainder = number - number % 10;
        result = result + (number - remainder);
        number = number / 10;
    }
   return result;
  }
int sumNumber = SumNumber(number);
Console.WriteLine("Sum of all digits of the number: " + sumNumber);
