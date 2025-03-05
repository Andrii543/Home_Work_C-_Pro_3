using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Work_C__Pro_3.Task_3;

namespace Home_Work_C__Pro_3.Task_1
{

    public partial class MyArray : IOutput
    {

        private int[] _marray = { 1, 2, 4, 5, 7, 1, 10, 49};

        public int[] Marray { get => _marray; set => Marray = value; }


        public void Show()
        {

            foreach (var item in Marray)
            {

                Console.WriteLine(item);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine($"\nПовідомлення: {info}");

            Show();

        }

       

    }
}
