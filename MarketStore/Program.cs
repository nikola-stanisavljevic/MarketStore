using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double turnover1 = 0;
            double purchaseValue1 = 150;
            try
            {
                PurchaseOrder purchaseOrder1 = new PurchaseOrder(new BronzeCard(), turnover1, purchaseValue1);
                purchaseOrder1.Display();
                Console.WriteLine();

                PurchaseOrder purchaseOrder2 = new PurchaseOrder(new SilverCard(), 600, 850);
                purchaseOrder2.Display();
                Console.WriteLine();

                PurchaseOrder purchaseOrder3 = new PurchaseOrder(new GoldCard(), 1500, 1300);
                purchaseOrder3.Display();
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex.Message);
            }
        }
    }
}
