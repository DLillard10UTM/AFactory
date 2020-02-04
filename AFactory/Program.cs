using System;

namespace AFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Manufacturers m;
            PhoneTypeChecker checker = new PhoneTypeChecker(m);
            checker.productChecker();
        }
    }
}
