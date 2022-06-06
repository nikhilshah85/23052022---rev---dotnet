using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write to File
            //FileStream myBook = null;
            //StreamWriter wr = null;
            //try
            //{
            //     myBook = new FileStream("mydetails.txt", FileMode.Create, FileAccess.Write);
            //     wr = new StreamWriter(myBook);
            //    wr.WriteLine("Hello");
            //    wr.WriteLine("My Name is Nikhil");
            //    wr.WriteLine("I am a Programmer");
            //    wr.WriteLine("I am a From India");
            //    wr.WriteLine("I am a working on Microsoft .Net");
            //    wr.WriteLine("I am a from India");
            //    wr.WriteLine("I am a also a Consultant");
            //}
            //catch (IOException io)
            //{
            //    Console.WriteLine(io.Message);
            //}
            //finally
            //{
            //    wr.Close();
            //    myBook.Close();
            //}
            #endregion

            #region Read from file
            //FileStream myFile = null;
            //StreamReader rd = null;

            //try
            //{
            //    myFile = new FileStream("mydetails.txt", FileMode.Open, FileAccess.Read);
            //    rd = new StreamReader(myFile);
            //    Console.WriteLine(rd.ReadToEnd());
            //}
            //catch(IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    myFile.Close();
            //    rd.Close();
            //}
            #endregion

            #region Write to file, while loop
            //Console.WriteLine("Enter Your Name");
            //string fileName = Console.ReadLine();
            //fileName = fileName + ".txt";

            //Console.WriteLine("Tell us something about yourself, press 1 and enter, when you are done");
            //FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            //StreamWriter wr = new StreamWriter(myFile);
            //try
            //{
            //    int no = 0;
            //    while (no != 1)
            //    {
            //        string details = Console.ReadLine();
            //        if (details == "1")
            //        {
            //            no = 1;
            //        }
            //        wr.WriteLine(details);

            //    }
            //}
            //catch(IOException es)
            //{
            //    Console.WriteLine(es.Message);
            //}
            //finally
            //{
            //    wr.Close();
            //    myFile.Close();
            //}
            #endregion

            Console.WriteLine("Enter the Name");
            string fileName = Console.ReadLine();
            fileName = fileName + ".txt";

            FileStream fs = null;
            StreamReader rd = null;

            try
            {

                 fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                rd = new StreamReader(fs);
                Console.WriteLine(rd.ReadToEnd());
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
            finally
            {
                fs.Close();
                rd.Close();
            }
        }
    }
}
