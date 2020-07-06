namespace MarketStore
{
    class BronzeCard : Card
    {
        public override void CalculateDiscountRate()
        {
            double turnover = GetTurnover();
            if (turnover < 100.00)
                SetDiscountRate(0);
            else if (100.00 <= turnover && turnover <= 300.00)
                SetDiscountRate(1);
            else if (turnover > 300.00)
                SetDiscountRate(2.5);
        }
    }
}
