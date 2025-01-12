﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05.Sealed
{
    internal sealed class ImmutableString
    {
        private readonly string value;

        public string Value
        {
            get { return value; }
    
        
        }

        public ImmutableString(string value)
        {
            this.value = value;
        }


}


