namespace MarketStore
{
    class SilverCard : Card
    {
        public override void CalculateDiscountRate()
        {
            if (GetTurnover() > 300.00)
                SetDiscountRate(3.5);
            else SetDiscountRate(2);
        }
    }
}
