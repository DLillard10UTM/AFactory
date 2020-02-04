using System;
using System.Collections.Generic;
using System.Text;

namespace AFactory
{

/*
 * Author: Danny Lillard
 * Date: 2/3/2020
 * Description: Less intelligent phones and their functionality.
 */
    interface IDumb
    {
        public string getName();
    }

    public class Asha : IDumb
    {
        public string getName()
        {
            return "Asha";
        }
    }

    public class Genie : IDumb
    {
        public string getName()
        {
            return "Genie";
        }
    }

    public class Primo : IDumb
    {
        public string getName()
        {
            return "Primo";
        }
    }
}
