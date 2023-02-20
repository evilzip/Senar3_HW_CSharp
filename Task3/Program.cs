// вывести третью степень всех чисел в интервале от 1 до вводимого N

int InputIn(string message)
{
    System.Console.Write(($"{message}=>"));
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect)
    {
        if (value>0)
         {
            return value;
         }
         System.Console.WriteLine("It is not a positive number");
        Environment.Exit(-2);
    }
    System.Console.WriteLine("It is not a number");
    Environment.Exit(-1);   
    return 0;
}

int userInput = InputIn("Enter your positive integer value");

string resultString = String.Empty;

for (int i = 1; i <= userInput; i++)
{    
    resultString = resultString + ($"{Math.Pow(i, 3)},");    
}

resultString = resultString.TrimEnd(','); // удаление последней запятой в финальном выводt
System.Console.WriteLine(resultString);
