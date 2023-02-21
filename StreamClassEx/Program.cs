using System;
using System.IO;
namespace StreamClassEx
{
    class Program
    {
       public static void Main(string[] args)
       {
            //Console.WriteLine("Enter Account Number");
            //int AccNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter balance");
            //int balance = Convert.ToInt32(Console.ReadLine());
            FileStream f = new FileStream(@"C:\Users\KOSATYAS\Desktop\StreamReader.txt", FileMode.OpenOrCreate);

            //STREAM WRITER
            //StreamWriter s = new StreamWriter(f);
            //s.WriteLine("Customer Account Number:{0}", AccNumber);
            //s.WriteLine("Customer Name:{0}", Name);
            //s.WriteLine("Customer Account balance:{0}", balance);

            //STREAM READER
            StreamReader s = new StreamReader(f);
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
        }
    }
}
