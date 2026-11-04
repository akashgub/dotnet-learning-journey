public class Storage<T>
{
    private T data;

    public void SetData(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Stored Value: {data}");
    }
}