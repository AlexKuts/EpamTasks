﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCreator
{
    interface IGiftItem
    {
        string Name { get; }
        double Weight { get; }    
    }
}