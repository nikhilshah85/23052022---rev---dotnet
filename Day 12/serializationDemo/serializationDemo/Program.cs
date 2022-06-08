using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" !! ~~~~~~~~~~~~~~~~~~~~~~~~~~~ Welcome to Banking System - CitiBank ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ !!");
            Console.WriteLine("Please enter the card .....and wait for validation");
            //new card object is creatd and values are assigned to the object
            CreditCard crd = new CreditCard();
        
            crd.cardNo = 123456789;
            crd.cardExpDate = DateTime.Now.AddYears(5);


            #region Example on ENUM
            //Console.WriteLine("Enter your card type");
            //Console.WriteLine("1. Visa");
            //Console.WriteLine("2. Master");
            //Console.WriteLine("3. AMEX");
            //int type = Convert.ToInt32(Console.ReadLine());

            //switch (type)
            //{
            //    case 1:
            //        crd.cardType = validCardType.Visa;
            //        break;
            //    case 2:
            //        crd.cardType = validCardType.Master;
            //        break;
            //    case 3:
            //        crd.cardType = validCardType.Amex;
            //        break;
            //    default:
            //        break;
            //}
            //crd.cardType = validCardType.Visa;
            #endregion


            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine(" !! ~~~~~~~~~~~~~~~~~~~~~~~~~~~ Welcome to Banking System - CitiBank ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ !!");

            Console.WriteLine("Its a valid card ");
            Console.WriteLine("Please enter a 4 digit PIN no");
            int pinNo = Convert.ToInt32(Console.ReadLine());

            bool isPinValid = crd.ValidatePin(pinNo);



            if (isPinValid)
            {
                BinaryFormatter bf = new BinaryFormatter();
                CreditCard crd2;
                FileStream fs = new FileStream(crd.cardNo + ".dat", FileMode.Open, FileAccess.Read);
                crd2 =(CreditCard)bf.Deserialize(fs);

                crd.availableBalance = crd2.availableBalance;
                fs.Close();
                Console.WriteLine("Avaialbel Balance is " + crd.availableBalance);


                FileStream beforeTransation = new FileStream(crd.cardNo + ".dat", FileMode.Create, FileAccess.Write);
               
                bf.Serialize(beforeTransation, crd);
                beforeTransation.Close();


                Console.WriteLine("Avaialbe balace is " + crd.availableBalance);
                Console.WriteLine("1. Widraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Exit");

                //switch case here, case 1:widraw, case 2: deposit, case 3: exit
                try
                {
                    Console.WriteLine("Please enter amount to widraw");
                    int v_amtToWidraw = Convert.ToInt32(Console.ReadLine());
                    crd.Widraw(v_amtToWidraw);
                    Console.WriteLine("Avaialbe balace is " + crd.availableBalance);

                    FileStream afterTransaction = new FileStream(crd.cardNo + ".dat", FileMode.Create, FileAccess.Write);

                    bf.Serialize(afterTransaction, crd);
                    beforeTransation.Close();

                }
                catch(Exception es)
                {
                    Console.WriteLine(es.Message);
                }
             


            }
            else
            {
                Console.WriteLine("Invalid Pin");
            }


            

        }
    }
}
