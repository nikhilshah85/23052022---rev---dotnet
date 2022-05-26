using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    internal class Accounts
    {
        //this is old and lengthy way to write the code
        #region Properties
        //int accccccnooooo;

        //public int AccNo
        //{
        //    get { return accccccnooooo; }
        //    set { accccccnooooo = value; }
        //}''

        ////variables are by default private in nature, i.e accessible only in this file, not outside
        //int v_accNo;
        //string v_accName;
        //double v_accBalance;

        ////encapsulation says dont allow direct access to storage place where u store the data

        //public int AccountNumber
        //{
        //    get { return v_accNo; }
        //    set { v_accNo = value; }
        //}

        ////new c# style
        //public int accNo { get; set; } //variable will creaed by compiler, you are anyways not suppose to use

        #endregion

        //this is short and fast, new way to write code
        #region Properties

        //public int accNo { get; set; }

        //public string accName { get; set; }

        //public double accBalance { get; set; }

        //public bool accIsActive { get; set; }

        //public string accEmail { get; set; }

        #endregion

        #region Methods
        //public double Widraw(int w_amount)
        //{
        //    accBalance = (accBalance - w_amount) - TransactionCharge(w_amount);
        //    return accBalance;
        //}

        //public double Deposit(int d_amount)
        //{
        //    accBalance = accBalance + d_amount;
        //    return accBalance;
        //}



        //private int TransactionCharge(int amount)
        //{
        //    int tCharge = 0;
        //    if (amount > 1000 && amount <= 2000)
        //    {
        //        tCharge = 5;
        //    }
        //    else if (amount > 2000 && amount <= 5000)
        //    {
        //        tCharge = 8;
        //    }
        //    else
        //    {
        //        tCharge = 10;
        //    }
        //    return amount * tCharge / 100;
        //}

        //private void ConnectToDatabase()
        //{

        //    ///perform all the opertaions for this class, like perform log, encrypt / decrypt data etc...
        //}

        #endregion




    }
}
