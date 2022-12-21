//using System;
//namespace FunctionsDemo
//{
//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        Employee Emp1 = new Employee();
//    //        Emp1.EmployeeID = 1001;
//    //        Emp1.Name = "James";
//    //        UpdateName(Emp1);
//    //        Console.WriteLine($"Emp1 Name = {Emp1.Name}");
//    //        Console.ReadKey();
//    //    }
//    //    public static void UpdateName(Employee Emp2)
//    //    {
//    //        Emp2.Name = "vipin";
//    //        Console.WriteLine($"Emp1 Name = {Emp2.Name}");
//    //    }
//    //}
//    //public class Employee
//    //{
//    //    public int EmployeeID;
//    //    public string Name;
//    //}

//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        int temp;
//    //        int[] Array = { 11, 33, 5, -3, 19, 8, 49 };

//    //        for (int i = 0; i < Array.Length - 1; i++)
//    //        {

//    //            for (int j = i + 1; j < Array.Length; j++)
//    //            {
//    //                if (Array[i] > Array[j])
//    //                {

//    //                    temp = Array[i];
//    //                    Array[i] = Array[j];
//    //                    Array[j] = temp;

//    //                }

//    //            }

//    //        }
//    //        Console.ReadKey();
//    //    }
//    //}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //var code = new Employee { Name = "Code" };
//            //var play = new Employee { Name = "Play" };

//            //List<Employee> allEmployess = code + play;
//            //Console.WriteLine(allEmployess);
//            int input = 10;
//            int batch = 3;
//            int[] arr = new int[input];
//            for (int i = 0; i < input; i++)
//            {
//                arr[i] = i+1;
//            }
//            int len = arr.Length/ batch == 0 ? arr.Length: (arr.Length / batch);
//            for (int i = 0; i < len; i = i+ batch)  ///10/2 = 5
//            {
//                for (int j = 1; j < batch; j++)
//                {
//                    Console.WriteLine(arr[i]+","); 
//                }
//            }

//            Console.ReadKey();

//        }
//    }

//    //public class Employee
//    //{
//    //    public string Name { get; set; }
//    //    public static List<Employee> operator +(Employee a, Employee b) =>
//    //        new List<Employee> {a,b };
//    //}

//}