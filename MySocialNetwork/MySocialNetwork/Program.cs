using System.Text;
using System.Threading.Channels;

ISocial mySocial = new NetworkProxy(new MySocialNetwork());

Console.WriteLine(mySocial.GetPage(1));
Console.WriteLine(mySocial.GetPage(2));
Console.WriteLine(mySocial.GetPage(3));

Console.WriteLine(mySocial.GetPage(2));


interface ISocial
{
    string GetPage(int num);
}

class MySocialNetwork : ISocial
{
    public string GetPage(int num)
    {
        return "This Page : " + num;
    }
}

class NetworkProxy : ISocial
{
    private ISocial _site;
    private Dictionary<int, string> cache;

    public NetworkProxy(ISocial site)
    {
        this._site = site;
        cache = new Dictionary<int, string>();
    }
    public string GetPage(int num)
    {
        string page;
        if (cache.ContainsKey(num))
        {
            page = cache[num];
            page = "From Cache : " + page;
        }
        else
        {
            page = _site.GetPage(num);
            cache.Add(num, page);
        }
        return page;
    }

}