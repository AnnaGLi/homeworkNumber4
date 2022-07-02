
/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Enter 8 numbers separated by comma : ");
string? seriesOfNumbers = Console.ReadLine();  
seriesOfNumbers = seriesOfNumbers + ",";  
void СheckNumber2 (int  series)
{
  if (series == '0'||series == '1'||series == '2'||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ',')
      {
      }
  else 
      {
        Console.WriteLine("Error.Enter series of numbers.");
      }
}

// massive
int[] number(string newNumber)
{ 
  int[] array = new int[1];  
  int k =0;

  for (int i = 0; i < newNumber.Length; i++)
  {
    string tempNumber = "";
    while (newNumber[i] != ',' && i < newNumber.Length)
    {
      tempNumber += newNumber[i];
      СheckNumber2(newNumber[i]);
      i++;
    }
    array[k] = Convert.ToInt32(tempNumber);    
    if (i < newNumber.Length-1){
      array = array.Concat(new int[] {0}).ToArray(); 
    }
    k++;
  }
  return array;
}

void PrintArry(int[] massive){
  int count = massive.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(massive[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] arrayOfNumbers =  number(seriesOfNumbers);

PrintArry(arrayOfNumbers);