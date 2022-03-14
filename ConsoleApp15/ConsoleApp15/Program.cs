using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {


            #region
            //Console.WriteLine("Yasini daxil et:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ili daxil et:");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if (age>18)
            //{
            //    Console.WriteLine("Xos gelmisen");
            //}
            //else if (age == 18)
            //{
            //    Console.WriteLine("Birazda gozle");
            //}
            //else
            //{
            //    Console.WriteLine("Hele usaqsan");
            //}

            //string message = age > 18 ? "Xos gelmisen" : "Hele usaqsan";

            //Console.WriteLine(message);

            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Ela yasin var");
            //        break;
            //    default:
            //        Console.WriteLine("Yasin pisdir");
            //        break;
            //}
            //for (int i = 0; i <= age; i++)
            //{
            //    if (i != age)
            //    {
            //        Console.WriteLine($"{year - i}-ci ilde {age - i} yasin var idi.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{year - i}-ci ilde anadan olmusan.");
            //    }
            //}

            //while (age>=0)
            //{
            //    Console.WriteLine($"{year}-ci ilde {age} yasin var idi.");
            //    year--;
            //    age--;
            //}
            #endregion

            Console.WriteLine("Yasini daxil et:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("denied");
                return;
            }
            Console.WriteLine("Maasini daxil et:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meblegi daxil et:");
            int desiredLoan = Convert.ToInt32(Console.ReadLine());

            if ((age <= 50 && desiredLoan < (salary * 7.2)) || (age > 50 && desiredLoan < (salary * 8.4)))
            {
                Console.WriteLine("accepted");
            }
            else
            {
                Console.WriteLine("denied");
            }

            //if (age<18)
            //{
            //    Console.WriteLine("denied");
            //}
            //else if (age>=18 && age<=50){
            //    if (desiredLoan < (salary*7.2))
            //    {
            //        Console.WriteLine("accepted");
            //    }
            //    else
            //    {
            //        Console.WriteLine("denied");
            //    }
            //}
            //else
            //{
            //    if (desiredLoan < (salary * 8.4))
            //    {
            //        Console.WriteLine("accepted");
            //    }
            //    else
            //    {
            //        Console.WriteLine("denied");
            //    }
            //}

        }
    }
}
