using Home_Work_C__Pro_3.Task_1;
using System.Text;
using Home_Work_C__Pro_3.Task_1_2;
using Home_Work_C__Pro_3.Task_3;

namespace Home_Work_C__Pro_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            //------------ Task 1

            //IOutput arrayOutput = new MyArray();

            //arrayOutput.Show();

            //arrayOutput.Show("Цей цикл не великий");

            //--------------- Task 2

            //IMath arrayMath = new MyArray();

            //Console.WriteLine(arrayMath.Max());

            //Console.WriteLine(arrayMath.Min());

            //Console.WriteLine(arrayMath.Avg());

            //arrayMath.Search(10);

            //--------------- Task 3

            ISort arraySort = new MyArray();

            arraySort.SortAsc();

            Console.WriteLine();

            arraySort.SortDesc();

            Console.WriteLine();

            arraySort.SortByParam(true);


        }
    }
}
