using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCustomer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Write();
            program.Read();
            Console.ReadKey();

        }
        public void Write()
        {
            CustomerDetails cust = new CustomerDetails();
            string path = "C:\\DotNetTraining\\Day11\\CustomerFolder\\CustomerNmae_DOB.txt";
            Console.WriteLine("enter customer ID");
            cust.Id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter customer name");
            cust.Name=Console.ReadLine();
            Console.WriteLine("enter customer DOB");
            cust.DOB=DateTime.Parse(Console.ReadLine());
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, cust);
            Console.WriteLine("written in file");
            stream.Close();
        }
        public void Read()
        {
            string path = "C:\\DotNetTraining\\Day11\\CustomerFolder\\CustomerNmae_DOB.txt";
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            CustomerDetails myCust=(CustomerDetails)formatter.Deserialize(stream);
            Console.WriteLine("Customer ID: "+myCust.Id);
            Console.WriteLine("Customer Nmae: " + myCust.Name);
            Console.WriteLine("Customer DOB: " + myCust.DOB);
        }
    }
}
