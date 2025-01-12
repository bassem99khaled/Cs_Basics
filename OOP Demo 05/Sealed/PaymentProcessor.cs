using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05.Sealed
{
    internal sealed class PaymentProcessor
    {
        public void ProccessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount}");
        }
    }

        //internal class MyPaymentProcessor : PaymentProcessor
        //{

        //    public new void ProccessPayment(decimal Amount)
        //    {
        //     Console.WriteLine($"Amount = {Amount + 20}");
        
        //        }
    
}
