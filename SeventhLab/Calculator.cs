class Calculator<T>
{
    public delegate T Operation(T x, T y);

    public T Add(T x, T y){ return (dynamic)x + y; }

    public T Subtract(T x, T y){ return (dynamic)x - y; }

    public T Multiply(T x, T y){ return (dynamic)x * y; }

    public T Divide(T x, T y)
    {
        if (EqualityComparer<T>.Default.Equals(y, default(T)))
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return default(T);
        }

        return (dynamic)x / y;
    }


    public T PerformOperation(T x, T y, Operation operation)
    {
        return operation(x, y);
    }

}