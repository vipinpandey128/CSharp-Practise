using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //abstract class AreaClass
    //{
    //    // declare method
    //    // 'Area' as abstract
    //    abstract public int Area();
    //}

    //// class 'AreaClass' inherit
    //// in child class 'Square'
    //class Square : AreaClass
    //{
    //    int side = 0;

    //    // constructor
    //    public Square(int n)
    //    {
    //        side = n;
    //    }

    //    // the abstract method
    //    // 'Area' is overridden here
    //    public override int Area()
    //    {
    //        return side * side;
    //    }
    //}

    //class gfg
    //{

    //    // Main Method
    //    public static void Main()
    //    {
    //        Square s = new Square(6);
    //        Console.WriteLine("Area  = " + s.Area());
    //    }
    //}

    class MyClass1
    {

        // Main Method
        public static void Main()
        {
            MyPay mm = new MyPay();
            var DebitCard = mm.MPay("DebitCard");
            var CreditCard = mm.MPay("CreditCard");
            var Cash = mm.MPay("Cash");
            var Online = mm.MPay("Online");
            var VisaCard = mm.MPay("VisaCard");
            DebitCard.PaymentDetails();
            CreditCard.PaymentDetails();
            Cash.PaymentDetails();
            Online.PaymentDetails();
            VisaCard.PaymentDetails();
            
        }
    }

    abstract class Payment
    {
        public abstract void PaymentDetails();
    }

    class MyPay
    {
        public Payment MPay(string type)
        {
            Payment pp = null;
             switch (type)
            {
                case "DebitCard":
                    pp = new DebitCard();
                    break;
                case "CreditCard":
                    pp = new CreditCard();
                    break;
                case "Cash":
                    pp = new Cash();
                    break;
                case "Online":
                    pp = new Online();
                    break;
                case "VisaCard":
                    pp = new VisaCard();
                    break;
                case "AF":
                    pp = new AF();
                    break;
            }
            return pp;
        }
    }

    class DebitCard : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("DebitCard Pay");
        }

        public void OldPayment()
        {
            Console.WriteLine("Old Pay");
        }
    }
    class CreditCard : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("CreditCard Pay");
        }
    }
     class Cash : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("Cash Pay");
        }
    }

    class Online : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("Online Pay");
        }

    }

    class VisaCard : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("VisaCard Pay");
        }
    }

    class AF : Payment
    {
        public override void PaymentDetails()
        {
            Console.WriteLine("AF Pay");
        }
    }














}
