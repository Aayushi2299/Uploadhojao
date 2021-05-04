using System;

namespace MindTreeQuestion21
{
    class TestUSN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter USN");
            string usn = Console.ReadLine();

            string result = ValidateUSN(usn) ? "Success" : "Failure";

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static bool ValidateUSN(string usn)
        {
            if (usn.Length != 10)
                return false;

            if (!(usn[0] == '1' || usn[0] == '2'))
                return false;

            if (!(IsUpperCase(usn[1]) && IsUpperCase(usn[2])))
                return false;

            if (!(IsDigit(usn[3]) && IsDigit(usn[4]) && IsDigit(usn[7]) && IsDigit(usn[8]) && IsDigit(usn[9])))
                return false;

            if (!((usn[5] == 'C' || usn[5] == 'I' || usn[5] == 'E' || usn[5] == 'M') && (usn[6] == 'S' || usn[6] == 'C' || usn[6] == 'E')))
                return false;

            return true;
        }

        private static bool IsDigit(char character)
        {
            int a = (int)character;
            if (a >= 48 && a <= 57)
                return true;
            return false;
        }

        private static bool IsUpperCase(char character)
        {
            int a = (int)character;
            if ((a >= 65 && a <= 90))
                return true;
            return false;
        }
    }

}
