using System;
using System.Collections.Generic;
using System.Text;

namespace AFactory
{

/*
 * Author: Danny Lillard
 * Date: 2/3/2020
 * Description: Factory implementations.
 */
    interface IPhoneFactory
    {
        public ISmart getSmart();
        public IDumb getDumb();
    }

    class SamsungFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            return new GalaxyS2();
        }

        public IDumb getDumb()
        {
            return new Genie();
        }
    }

    class HTCFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            return new Lumia();
        }

        public IDumb getDumb()
        {
            return new Asha();
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            return new Titan();
        }

        public IDumb getDumb()
        {
            return new Primo();
        }
    }
}
