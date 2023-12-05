class FunctionCache<TKey, TResult>
{

    private Dictionary<TKey, ChacheItem> cache = new Dictionary<TKey, ChacheItem>();

    public class ChacheItem
    {
        private TResult result;
        private DateTime expirationTime;
        public TResult Result
        {
            get { return result; }
            set { result = value; }
        }
        public DateTime ExpirationTime
        {
            get { return expirationTime; }
            set { expirationTime = value; }
        }
    }
    public delegate TResult Func(TKey key);

    public TResult GetOrCompute(TKey key, Func function, TimeSpan cacheDuration)
    {
        if (cache.TryGetValue(key, out var cachedResult) && DateTime.Now < cachedResult.ExpirationTime)
        {
            Console.WriteLine($"Result for key '{key}' found in cache.");
            return cachedResult.Result;
        }

        Console.WriteLine($"Result for key '{key}' not found in cache. Caching result.");
        TResult result = function(key);

        cache[key] = new ChacheItem
        {
            Result = result,
            ExpirationTime = DateTime.Now.Add(cacheDuration)
        };

        return result;
    }
}