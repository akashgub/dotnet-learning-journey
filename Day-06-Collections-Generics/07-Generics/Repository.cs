
public class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void DisplayAll()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }

    public int Count()
    {
        return items.Count;
    }
}
 