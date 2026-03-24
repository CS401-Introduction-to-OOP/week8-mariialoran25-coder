namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _obj = new List<T>();

    public void AddItem(T item)
    {
        _obj.Add(item);
        Console.WriteLine($"Added object {item.TrackingNumber}");
    }
    
    public double GetTotalCost()
    {
        double res = 0;
        foreach (var obj in _obj)
        {
            res += obj.CalculateCost();
        }

        return res;
    }
}