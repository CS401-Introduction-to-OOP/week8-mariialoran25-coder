namespace Week8;

public class Letter :DeliveryItem
{
    public Letter(string trakingNumber, double weight) : base(trakingNumber, weight){}

    public override double CalculateCost()
    {
        return 15 + (Weight * 10);
    }

    
}
