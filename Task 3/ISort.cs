﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_C__Pro_3.Task_3
{
    public interface ISort
    {
        void SortAsc();

        void SortDesc();

        void SortByParam(bool isAsc);
    }
}
