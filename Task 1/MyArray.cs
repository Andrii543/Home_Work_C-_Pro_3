using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Work_C__Pro_3.Task_1_2;
using Home_Work_C__Pro_3.Task_3;

namespace Home_Work_C__Pro_3.Task_1
{

    public class MyArray : IOutput, IMath, ISort
    {

        private int[] Marray = { 1, 2, 4, 5, 7, 1, 10, 49};


        //-----------------------   Task 1
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

        //----------------------------   Task 2
        public int Max()
        {

            return Marray.Max();
        }

        public int Min()
        {
            return Marray.Min();
        }

        public float Avg()
        {
            return (float)Marray.Average();
        }

        public bool Search(int valueToSearch)
        {
            if (Marray.Contains(valueToSearch))
            {
                Console.WriteLine("Число знайдено");
                return true;
            }
            else
            {
                Console.WriteLine("Число не знайдено");
                return false;
            }
        }

        //------------------  Task 3

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
            if(isAsc is true)
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
