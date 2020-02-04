using System;
using System.Collections.Generic;
using System.Text;

namespace AFactory
{

/*
 * Author: Danny Lillard
 * Date: 2/3/2020
 * Description: Smart phones and their functionality.
 */
    interface ISmart
    {
        public string getName();
    }

    public class Lumia : ISmart
    {
        public string getName()
        {
            return "Lumia";
        }
    }

    public class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }

    public class Titan : ISmart
    {
        public string getName()
        {
            return "Titan";
        }
    }
}
