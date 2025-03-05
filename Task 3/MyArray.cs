using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Work_C__Pro_3.Task_3;

namespace Home_Work_C__Pro_3.Task_1
{
    public partial class MyArray : ISort
    {
        public void SortAsc()
        {
            Array.Sort(Marray);

            Show();
        }

        public void SortDesc()
        {
            Array.Reverse(Marray);

            Show();
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc is true)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
