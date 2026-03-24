namespace Week8;

public class Program
{
    public static void Main()
    {
        Letter let1 = new Letter("AS2",1);
        Letter let2 = new Letter("LM3",2);

        Parcel par1 = new Parcel("OM1",1,"30x20");
        Parcel par2 = new Parcel("OM5",1,"20x");
        
        let1.PrintInfo();
        par2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(let1);
        myCargo.AddItem(let2);
        myCargo.AddItem(par1);
        myCargo.AddItem(par2);

        double totalCost = myCargo.GetTotalCost();
        Console.WriteLine($"Total Delivery : {totalCost}");
    }
}

