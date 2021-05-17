using System;

namespace first_project
{
    class Kalkulyator
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil edin: ");
            double eded1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            double eded2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hansi emeliyyati yerine yetirmek isteyirsiniz? ");
            string emeliyyat = Console.ReadLine();

            if (emeliyyat == "+")
            {
                Console.WriteLine("Netice: {0}", eded1 + eded2);

            }
            else if (emeliyyat == "-")
            {
                Console.WriteLine("Netice: {0}", eded1 - eded2);
            }
            else if (emeliyyat == "*")
            {
                Console.WriteLine("Netice: {0}", eded1 * eded2);
            }
            else if (emeliyyat == "/")
            {
                Console.WriteLine("Netice: {0}", eded1 / eded2);
            }
            else if (emeliyyat == "%")
            {
                Console.WriteLine("Netice: {0}", eded1 % eded2);
            }
            else
            {
                Console.WriteLine("Teessuf ki, secdiyiniz emeliyyat duzgun deyil.");
            }
        }


    }
}