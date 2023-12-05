class Repository<T>
{
    List<T> reposiory = new List<T>();
    public delegate bool Criteria<T>(T item);

    public List<T> Find(Criteria<T> criteria)
    {
        List<T> list = new List<T>();

        foreach (T items in reposiory)
        {
            if (criteria(items))
            {
                list.Add(items);
            }
        }
        return list;
    }

    public void AddToList(T item)
    {
        reposiory.Add(item);
    }
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}