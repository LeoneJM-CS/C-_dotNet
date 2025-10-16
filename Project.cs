//using System;

//namespace Lecture10
//{
//    public class Pay { 
//        public abstract class Payment
//        {
//            public abstract void ProcessPay(double payTotal);
//            public virtual void DisplayReceipt()
//            {
//                Console.WriteLine("Thank you for your payment.");
//            }
//        }
//        public class CreditPay(double payTotal): Payment 
//        {
//            public override void ProcessPay(double payTotal)
//            {
//                Console.WriteLine("Processing credit card payment ${0}", payTotal);
//            }
//            public override void DisplayReceipt() { Console.WriteLine("Thank you for your payment."); }
//        }
//        public class PayPal(double payTotal): Payment
//        {
//            public override void ProcessPay(double payTotal)
//            {
//                Console.WriteLine("Processing PayPal payment ${0}", payTotal);
//            }
//            public override void DisplayReceipt() { Console.WriteLine("Thank you for your payment."); }
//        }
//        static void Main(string[] args)
//        {
//            Payment p;
//            Console.WriteLine("Enter Payment Choice: ");
//            string? payType = Console.ReadLine();
//            if ((payType == "Paypal") | (payType == "PayPal"))
//            {
//                Console.WriteLine("Enter payment amount: ");
//                double payTotal = Convert.ToDouble(Console.ReadLine());
//                p = new PayPal(payTotal);
//                p.ProcessPay(payTotal);
//                p.DisplayReceipt();
//            }
//            else if ((payType == "Credit card") | (payType == "credit card"))
//            {
//                Console.WriteLine("Enter payment amount: ");
//                double payTotal = Convert.ToDouble(Console.ReadLine());
//                p = new CreditPay(payTotal);
//                p.ProcessPay(payTotal);
//                p.DisplayReceipt();
//            }
//            else 
//            {
//                Console.WriteLine("Invalid Input");
//            }
//        }
//    }
//}