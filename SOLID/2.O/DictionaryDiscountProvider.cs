namespace SOLID.O;

public class DictionaryDiscountProvider : IDiscountProvider
{
    private readonly IReadOnlyDictionary<string, IDiscountStrategy> _map;
    public DictionaryDiscountProvider(IEnumerable<(string key, IDiscountStrategy strategy)> strategies)
    => _map = strategies.ToDictionary(x => x.key, x => x.strategy );
    
    public IDiscountStrategy Get(string key)
    => _map.TryGetValue(key, out var s) ? s : new NoDiscount();
}