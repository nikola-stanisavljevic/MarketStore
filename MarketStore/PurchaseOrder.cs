using System;

namespace MarketStore
{
    class PurchaseOrder
    {
        private Card _card;
        private double purchaseValue;
        private double discount;
        private double totalValue;

        public PurchaseOrder() { }

        public PurchaseOrder(Card card, double turnover, double purchaseValue)
        {
            if (purchaseValue < 0 && turnover < 0)
                throw new Exception("Either purchase value or turnover value is initialized as negative (below 0).");

            _card = card ?? throw new Exception("The Card object is set to null.");

            _card.SetTurnover(turnover);
            this.purchaseValue = purchaseValue;
            InitializePurchase();
        }

        public void InitializePurchase()
        {
            CalculateDiscount();
            CalculateTotal();
        }

        public void CalculateDiscount()
        {
            _card.CalculateDiscountRate();
            double discountRate = _card.GetDiscountRate();
            discount = purchaseValue * discountRate/100;
        }

        public void CalculateTotal()
        {
            if (purchaseValue - discount >= 0)
                totalValue = purchaseValue - discount;
            else throw new Exception("Total value is below 0, please check purchase value.");
        }

        public void Display()
        {
            Console.WriteLine("Purchase value: " + purchaseValue.ToString("C"));
            double discountRate = _card.GetDiscountRate() / 100;
            Console.WriteLine("Discount rate: " + discountRate.ToString("P1"));
            Console.WriteLine("Discount: " + discount.ToString("C"));
            Console.WriteLine("Total: " + totalValue.ToString("C"));
        }
    }
}
