/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵)
 2, 4 -> 16 */

int Exponentiation(int numberOne, int numberTwo){
  int result = 1;
  for(int i=1; i <= numberTwo; i++){
    result = result * numberOne;
  }
    return result;
}
  Console.Write("enter the first number: ");
  int numberOne = Convert.ToInt32(Console.ReadLine());
  Console.Write("enter the second number: ");
  int numberTwo = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberOne, numberTwo);
  Console.WriteLine("Answer is: " + exponentiation);
