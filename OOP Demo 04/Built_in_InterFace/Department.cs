﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_04.Built_in_InterFace
{
    internal class Department : ICloneable
    {
        public int Code { get; set; }

        public string? Title { get; set; }

        public object Clone()
        {

            return new Department();
            {
                Code = this.Code;
                Title = this.Title;
            }
        }
    }
}