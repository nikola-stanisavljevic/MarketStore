using System;

namespace MarketStore
{
    class GoldCard : Card
    {
        public override void CalculateDiscountRate()
        {
            SetDiscountRate(2.0);
            int pts = Convert.ToInt32(GetTurnover()/100);
            for (int i = 0; i < pts; i++)
            {
                if (GetDiscountRate() == 10.0)
                {
                    SetDiscountRate(10.0);
                    break;
                }
                else
                    SetDiscountRate(GetDiscountRate() + 1.0);
            }
        }
    }
}
