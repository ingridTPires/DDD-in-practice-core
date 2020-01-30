using System;

namespace DddInPractice.Logic
{
    //entity
    public class SnackMachine : Entity
    {
        public SnackMachine()
        {
            MoneyInside = new Money(0, 0, 0, 0, 0, 0);
            MoneyInTransaction = new Money(0, 0, 0, 0, 0, 0);
        }
        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }

        public void InsertMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            MoneyInTransaction = new Money(0, 0, 0, 0, 0, 0);
        }

        public void BuySnack()
        {
            MoneyInside += MoneyInTransaction;

            //MoneyInTransaction = 0;

        }
    }
}
