using System;

namespace BankLibrary
{
    public abstract class Bank
    {
        #region Field & Properties

        private string accHolderName;

        public string AccHolderName
        {
            get { return accHolderName; }
            set { accHolderName = value; }

        }

        public double balance;

        public double  Balance
        {
            get { return balance; }
            protected set { balance = value; } //private do not allow to the access outside

        }
        #endregion

        #region Methods

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        //public abstract void Withdraw(double amount); //abstract 
        public virtual void Withdraw(double amount) // virtual for a concrete that is compulsary method
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            //traditional method
            //return "AccountHolderName :" +AccHolderName + "Balance : " + Balance;

            //format string (using place holder)
            //return string.Format("AccountHolderName : {0} Balance : {1}", AccHolderName, Balance);

            //string interpolation
            return string.Format($"Account Holder Name : {AccHolderName} Balance : {balance}");
        }


        #endregion

        #region Constructor

        public Bank()
        {
            Balance = 1000;
        }

        public Bank(string name, double amount)
        {
            this.AccHolderName = name;
            this.Balance = amount;
        }
        #endregion


    }
}
