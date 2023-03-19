using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA07ClassWork
{
    internal class ProceduralProgramming
    {
        #region DATA TYPES
        public void DataTypes()
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
        #endregion

        #region BASICS
        public void Basics()
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
        #endregion

        #region CONDITIONS
        public void ConditionsIfElse()
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
        }
        public void ConditionsSwitchCase()
        {
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
        #endregion

        #region LOOPS
        public void LoopsGetTable()
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

           

            string[] friends = { "areeba", "ateefa", "mariam", "fareha", "sania", "yusiarah" };
            foreach (string k in friends)
            {
                Console.WriteLine(k);
            }

        }
        public void LoopsPrintPatterns()
        {
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
        }
        public void LoopsReverseString()
        {
            string str = "This is a book";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

        }
        public void LoopsFulllPrintString()
        {
            string sentence = "This is a String";
            int i = 0;
            while (i < sentence.Length)
            {
                Console.Write(sentence[i]);
                i++;
            }
        }
        public void LoopsPrintHalfString()
        {
            string str = "This is a String";
            int result = str.Length / 2;

            Console.WriteLine(result);
            for (int i = (str.Length / 2); i >= 1; i--)
                for (int i = (str.Length / 2); i <= str.Length - 1; i++)
                {
                    Console.Write(str[i]);
                }
        }
        public void LoopsGroupReverse()
        {
            string sentence = "This is Contour"
            for (int i = sentence.Length - 1; i > 2; i--)
            {
                Console.WriteLine(sentence[i]);
                //Console.WriteLine(i);
            }
        }
        //public void LoopsGroupStringReverse()
        //{
        //    string str = "This is a book";
        //    var space = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //        for (int i = 0; i <= str.Length; i++)
        //        {
        //            if (i == space)
        //            {

        //            }
        //            Console.Write(space);

        //        }
        //}

        //public void LoopsCheckPalandrome()
        //{
        //    string word = "addaeq";
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {

        //        //Console.WriteLine(typeof(value[i]));
        //        char newword = word[i];
        //        Console.Write(newword);
        //        Console.WriteLine(typeof(newword));
        //        if (word == newword)
        //        {
        //            Console.WriteLine("True");
        //        }
        //        else
        //        {
        //            Console.WriteLine("False");
        //        }
        //    }

        //}
        #endregion

        #region ARRAY
        public void ArraysRemoveDuplicates()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2 };
            var size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        size--;
                        arr[j] = arr[size];
                        j--;
                        Console.WriteLine(arr[j]);
                    }
                }
            }
        }
        public void ArraysSort()
        {
            int[] teachersId = { 60, 40, 30, 10, 20, 50, 70 };
            for (int i = 0; i < teachersId.Length; i++)
            {
                for (int j = i; j < teachersId.Length; j++)
                {
                    if (teachersId[i] > teachersId[j])
                    {
                        int temp = teachersId[i];
                        teachersId[i] = teachersId[j];
                        teachersId[j] = temp;
                    }
                }
                Console.WriteLine(teachersId[i]);
            }
        }
        public void ArraysGetSingleChar()
        {
            char[] arr = { 'H', 'E', 'l', 'l', 'O' };

            Console.WriteLine(arr[2]);
            Console.WriteLine(Convert.ToChar(arr[2]));
            Console.WriteLine(Convert.ToString(arr));
        }
        public void ArraysGetArrayAsString()
        {
            char[] arr = { 'H', 'E', 'l', 'l', 'O' };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(Convert.ToChar(arr[i]));
            }
        }
        #endregion

        #region LISTS
        public void Lists()
        { }
        #endregion

        #region TRT CATCH
        public void TryCatch()
        {
            Console.WriteLine("Hello");

        }
        #endregion
    }
}
