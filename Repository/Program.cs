class Program
{
    public static void Main()
    {
        Repository<int> repositoryInt = new Repository<int>();

        repositoryInt.AddToList(1);
        repositoryInt.AddToList(2);
        repositoryInt.AddToList(3);

        Repository<int>.Criteria<int> criteria = repositoryInt.IsEven;


        List<int> evenNumbers = repositoryInt.Find(criteria);

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }


}
