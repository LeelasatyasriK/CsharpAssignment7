using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace SerializationEx
{
        class Program
        {
            static void Main(string[] args)
            {
                MarketingExecutive m = new MarketingExecutive();
                //Console.WriteLine("Enter Employee Number: ");
                //m.EmpNo = int.Parse(Console.ReadLine());

                //Console.Write("Enter Employee Name: ");
                //m.EmpName = Console.ReadLine();

                //Console.Write("Enter Employee salary: ");
                //m.Salary = int.Parse(Console.ReadLine());

            //SERIALIZATION
                FileStream stream = new FileStream(@"C:\Users\KOSATYAS\Desktop\MarketingExcecutive.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
            //  formatter.Serialize(stream, m);
            // stream.Close();
            //DESERIALIZATION
             m= (MarketingExecutive)formatter.Deserialize(stream);
                   Console.WriteLine("Employee id:{0}",m.EmpNo);
                 Console.WriteLine("Employee Name:{0}", m.EmpName);
            Console.WriteLine("Employee Name:{0}", m.Salary);
            stream.Close();
                 // m.PrintDetails();
                Console.WriteLine("Enter Kilometers travelled");
                int n = Convert.ToInt32(Console.ReadLine());
                m.KT = n;
                m.TeA = 1000;
                m.CalculateSalary();
            }
        }
}

