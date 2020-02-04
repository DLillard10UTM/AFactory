using System;
using System.Collections.Generic;
using System.Text;

namespace AFactory
{
    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    };

    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            //Im not quite sure what this constructor is meant to do?
        }

        public void productChecker()
        {
            //set internal factory to correct factory, then write both phone types to console
            factory = new SamsungFactory();

            Console.WriteLine(factory.getSmart().getName());
            Console.WriteLine(factory.getDumb().getName());

            factory = new HTCFactory();

            Console.WriteLine(factory.getSmart().getName());
            Console.WriteLine(factory.getDumb().getName());

            factory = new NokiaFactory();

            Console.WriteLine(factory.getSmart().getName());
            Console.WriteLine(factory.getDumb().getName());
        }
    }
}
