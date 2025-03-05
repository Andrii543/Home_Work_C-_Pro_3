using Home_Work_C__Pro_3.Task_1_2;
using Home_Work_C__Pro_3.Task_1;

namespace Home_Work_C__Pro_3.Task_1
{
    public partial class MyArray : IMath
    {

        public int Max() => Marray.Max();

        public int Min() => Marray.Min();

        public float Avg() => (float)Marray.Average();


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
    }
}
