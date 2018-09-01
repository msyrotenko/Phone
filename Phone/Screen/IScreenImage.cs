﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public enum Quality
    {
        Low,   
        Middle, 
        High, 
    }
    public interface IScreenImage
    {
        int Height { get; set; }
        int Width { get; set; }
        Quality Quality { get; set; }
    }
}
