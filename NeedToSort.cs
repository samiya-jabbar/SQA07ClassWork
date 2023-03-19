using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SQA07ClassWork

{
    internal class MyProgram
    {
        static void Main(string[] args)
        {
            MyProgram.DataTypes(); //for understanding basics of C#
            MyProgram.Basics(); //
            MyProgram.Conditions();
            MyProgram.loops();
            Console.Read();
        }
        static void DataTypes()
        {
            string sam = "samiya jabbar";
            int a = 9;
            char b = '5';
            char c = 'c';
            float d = 1.5F;
            double e = 4.567;
            Console.WriteLine("Congratz ateefa, we did it");
            Console.WriteLine("hello " + sam);
            Console.WriteLine(a);
            //Console.WriteLine(b + c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(Convert.ToInt32(e));
        }
        static void Basics()
        {
            string tee = "samiya";
            string fari = "Areeba";
            Console.WriteLine(tee.Length);
            Console.WriteLine(tee.ToUpper());
            string friends = $"My firends are: {tee} {fari}";
            Console.WriteLine(friends);
            Console.WriteLine(fari[4]);
            Console.WriteLine(fari.IndexOf('r'));
            Console.WriteLine(tee.Substring(2));
        }
        static void Conditions()
        {
            string x = "samiya";
            string y = "areeba";
            int xx = x.Length;
            int yy = y.Length;
            if (xx == yy)
            {
                Console.WriteLine($"{x} and {y} are good friends");

            }
            else if (xx <= yy)
            {
                Console.WriteLine("may be they are friends");
            }
            else
            {
                Console.WriteLine("They are not good friends");
            }

            int day = 11;
            string result = (day < 5) ? "Good" : "Bad"; // short hand if-else, ternary operator
            Console.WriteLine(result);

            switch (day)
            {
                case 10:
                    Console.WriteLine("Monday");
                    break;
                case 11:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }

        }
        static void loops()
        {
            Console.WriteLine("Enter any number so that I can show you a table: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I want the table of {num1} to be printed till: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= num2)
            {
                int result = num1 * i;
                Console.WriteLine(($"{num1} * {i} = {result}"));
                i++;

            }

            for (int j = 1; j <= 10; j = j + 2)
            {
                int result = num1 * j;
                Console.WriteLine($"==> {num1} * {j} = {result}");
            }

            char star = '*';
            //pattern#1
            for (int y = 3; y >= 0; y--)
            {
                for (int z = 0; z <= y; z++)
                {
                    //Console.WriteLine($"{y} and {z}");
                    Console.Write(star);
                }
                Console.WriteLine(" ");
            }
            //pattern#2
            for (int m = 3; m >= 0; m--)
            {
                for (int n = 3; n >= m; n--)
                {
                    Console.Write(star);
                    //Console.WriteLine($"{m} and {n}");
                }
                Console.WriteLine("");
            }
            //pattern#3
            for (int p = 3; p >= 0; p--)
            {
                for (int q = 0; q <= p; q++)
                {
                    //Console.WriteLine($"{p} and {q}");
                    Console.Write(star);
                }
                Console.WriteLine(" ");
                for (int r = 3; r >= p; r--)
                {
                    Console.Write(" ");
                    //Console.WriteLine($"{p} and {r}");
                }
            }
            //pattern#4
            for (int s = 3; s >= 0; s--)
            {
                for (int t = 3; t >= s; t--)
                {
                    //Console.WriteLine($"{s} and {t}");
                    Console.Write(star);
                }
                Console.WriteLine(" ");
                for (int u = 0; u <= s; u++)
                {
                    Console.Write(" ");
                    //Console.WriteLine($"{s} and {u}");
                }
            }

            string[] friends = { "areeba", "ateefa", "mariam", "fareha", "sania", "yusiarah" };
            foreach (string k in friends)
            {
                Console.WriteLine(k);
            }

        }




    }
}
