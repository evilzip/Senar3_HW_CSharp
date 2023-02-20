// Задача 1. 
// Напишите задачу, которая принимает нв вход пятизначное числои проверяет, является ли оно полиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 > да

int InputIn(string message)
{
    System.Console.Write(($"{message} > "));
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect && value >0) //добавил исключение отлицательных чисел
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number or negative number");
    Environment.Exit(-1);
    return 0;
}


bool isSingleDigit(int value)
{
    if (value>9) return true;   
    System.Console.WriteLine("single digit value is always a nice polyndrom");
    Environment.Exit(-2);
    return false;
}

int reverseValue(int value)
{
    int result=0, valueLastDigit;     
    
    while (value>0)
    {
        valueLastDigit = value%10;
        result = result*10 + valueLastDigit; 
        value/=10;        
    }
    return result;
}

int userValue = InputIn("Enter your value");
if (isSingleDigit(userValue))
{
    if (userValue == reverseValue(userValue))
    {
        System.Console.WriteLine($"Yes! {userValue} is a nice polyndrom");
    }
    else
    {
        System.Console.WriteLine($"No! {userValue} is not a polyndrom");
    }

}

