using System.Text;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int a =   Console.WriteLine(TenByTen());
            TenByTen(10);

            //2
            int[] MyNumbers = { 100, 200, 300, 400 };
            Console.WriteLine(MyNumbers.Max());
            //3
            int[] Num = { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(Num.Max());

            int[] Num1 = { -9, -2, -7, -7, -8, -4 };
            Console.WriteLine(Num1.Max());

            //4
            int[] Num2 = { 3, 5, 6, 7, 7, 8, 9 };


            Console.WriteLine(Num.Length);

            //int number = int.Parse(Console.ReadLine());


        }

        static void TenByTen(int Num)
        {
            string line = "";
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine("\n");
            //    Console.WriteLine(i);

            for (int i = 1; i <= Num; i++)
            {
                for (int a = 1; a <= Num; a++)
                {
                    line += i * a + " ";
                    //i++;
                }
                Console.WriteLine(line);
                line = "";
            }

            //i++;
            //}

        }

        //static void Freq(int[] Num, int n)
        //{
        //    var Dictionary<int, int> dictionary = new Dictionary<int, int>();
        //    Array.Sort(Num);

        //    foreach (int i in Num)
        //    {
        //        if (!dictionary.ContainKey(Num))
        //        {
        //            dictionary.Add(Num, 1);
        //        }
        //        else dictionary[Num]++;
        //    }
        //    StringBuilder sb = new StringBuilder();
        //    var sortedList = from pair in dictionary orderby pair.Value descending select pair;

        //    foreach (var x in sortedList)
        //    {
        //        { sb.Append(x.Key + ""); }
        //    }

        //    Console.WriteLine(sb);

        //}

    }

}


