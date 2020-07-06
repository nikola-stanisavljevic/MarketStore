using System;

namespace MarketStore
{
    abstract class Card
    {
        private string ownerName;
        private string ownerSurname;
        private double turnover;
        private double discountRate;

        public abstract void CalculateDiscountRate();

        public double GetDiscountRate() { return discountRate; }
        public void SetDiscountRate(double discountRate)
        {
            if (discountRate >= 0)
                this.discountRate = discountRate;
            else throw new Exception("Value of discount rate is below 0.");
        }
        public double GetTurnover() { return turnover; }
        public void SetTurnover(double turnover)
        {
            if (turnover >= 0)
                this.turnover = turnover;
            else throw new Exception("Value of turnover is below 0.");
        }
        public string GetName() { return ownerName; }
        public void SetName(string name)
        {
            if (name != null)
                ownerName = name;
            else throw new Exception("Owner name is set to null!");
        }
        public string GetSurname() { return ownerSurname; }
        public void SetSurname(string surname)
        {
            if (surname != null)
                ownerSurname = surname;
            else throw new Exception("Owner surname is set to null!");
        }
    }
}
