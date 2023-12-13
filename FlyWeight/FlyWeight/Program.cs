public interface IFlyweight
{
    string GetType();
    int GetSize();
    string GetColor();
}

public class Flyweight : IFlyweight
{
    private string _type;
    private int _size;
    private string _color;

    public Flyweight(string type, int size, string color)
    {
        _type = type;
        _size = size;
        _color = color;
    }

    public string GetType()
    {
        return _type;
    }

    public int GetSize()
    {
        return _size;
    }

    public string GetColor()
    {
        return _color;
    }
}

public class Factory
{
    private static Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

    public static IFlyweight GetFlyweight(string type, int size, string color)
    {
        if (!_flyweights.ContainsKey(type))
        {
            _flyweights[type] = new Flyweight(type, size, color);
        }

        return _flyweights[type];
    }
}

