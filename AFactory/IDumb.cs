﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AFactory
{
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