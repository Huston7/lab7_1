class Program
{
    public static void Main()
    {
        Calculator<int> calculatorInt = new Calculator<int>();
        Calculator<double> calculatorDouble = new Calculator<double>();


        Console.WriteLine($"Addition: {calculatorInt.Add(6, 7)}\n" +
                          $"Addition: {calculatorDouble.Add(20.5, 32.3)}\n" +
                          $"Subtract: {calculatorInt.Subtract(8, 3)}\n" +
                          $"Multiply: {calculatorInt.Multiply(10, 2)} \n" +
                          $"Division: {calculatorInt.Divide(20, 4)} \n");

    }
}