// task 1
//delegate void DisplayMessageDelegate(string message);

//class Program
//{
//    static void Main(string[] args)
//    {
//        DisplayMessageDelegate displayMessage = DisplayMessageInConsole;

//        displayMessage("Hello, world!");
//        displayMessage("This is delegates in C#.");
//        displayMessage("The application has finished.");

//        displayMessage += DisplayMessageInMessageBox;
//        displayMessage("Message in a MessageBox.");

//        Console.ReadKey();
//    }

//    static void DisplayMessageInConsole(string message)
//    {
//        Console.WriteLine("Console: " + message);
//    }

//    static void DisplayMessageInMessageBox(string message)
//    {
//        Console.WriteLine("MessageBox: " + message);
//    }
//}



// task 2
//delegate double ArithmeticOperation(double x, double y);

//class Program
//{
//    static void Main(string[] args)
//    {
//        ArithmeticOperation addition = Add;
//        ArithmeticOperation subtraction = Subtract;
//        ArithmeticOperation multiplication = Multiply;


//        Console.Write("Enter the first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());


//        double resultAddition = addition(num1, num2);
//        double resultSubtraction = subtraction(num1, num2);
//        double resultMultiplication = multiplication(num1, num2);

//        Console.WriteLine($"Addition: {num1} + {num2} = {resultAddition}");
//        Console.WriteLine($"Subtraction: {num1} - {num2} = {resultSubtraction}");
//        Console.WriteLine($"Multiplication: {num1} * {num2} = {resultMultiplication}");

//        Console.ReadKey();
//    }

//    static double Add(double x, double y)
//    {
//        return x + y;
//    }

//    static double Subtract(double x, double y)
//    {
//        return x - y;
//    }

//    static double Multiply(double x, double y)
//    {
//        return x * y;
//    }
//}


// task 3
//delegate bool NumberCheckDelegate(int number);

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        NumberCheckDelegate isEven = IsEven;
//        NumberCheckDelegate isOdd = IsOdd;

//        bool isNumberEven = isEven(number);
//        bool isNumberOdd = isOdd(number);

//        Console.WriteLine($"{number} is even: {isNumberEven}");
//        Console.WriteLine($"{number} is odd: {isNumberOdd}");

//        Console.ReadKey();
//    }

//    static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }

//    static bool IsOdd(int number)
//    {
//        return number % 2 != 0;
//    }
//}

