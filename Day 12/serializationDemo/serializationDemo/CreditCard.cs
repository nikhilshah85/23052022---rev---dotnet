using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace serializationDemo
{
    enum validCardType
    {
        Visa,
        Master,
        Amex
    }


    [Serializable]
    internal class CreditCard
    {
        public long cardNo { get; set; }
        public int availableBalance { get; set; }
        public DateTime cardExpDate { get; set; }
        public int cardPIN { get; set; }
        public validCardType cardType { get; set; }

        public bool ValidatePin(int cardPIN)
        {
            //object will go to server and check the pin from database
            if (cardPIN == 9999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Widraw(int amt)
        {
            if (amt > availableBalance)
            {
                throw new Exception("Insufficient Balance");
            }
            else if (amt > 20000)
            {
                throw new Exception("You cannot widraw more than 20K in a single transaction");
            }
            availableBalance = availableBalance - amt;
            return availableBalance;
        }
    }
}
