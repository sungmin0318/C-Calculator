using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQ = new Queue<string>();

            myQ.Enqueue("하성민");
            myQ.Enqueue("오준환");

            Console.WriteLine(myQ.Count.ToString());

            Console.WriteLine(myQ.Dequeue());
            Console.WriteLine(myQ.Dequeue());

            Console.WriteLine(myQ.Count.ToString());


            Stack<string> myS = new Stack<string>();

            myS.Push("하성민");
            myS.Push("오준환");

            Console.WriteLine(myS.Count.ToString());
            Console.WriteLine(myS.Count.ToString());
            Console.WriteLine(myS.Pop());
            Console.WriteLine(myS.Pop());

            Console.WriteLine(myS.Count.ToString());


            Console.Write(System.Environment.NewLine+ System.Environment.NewLine+ System.Environment.NewLine);

            Dictionary<string, string> myDic = new Dictionary<string, string>();
            //string[] myStr = new string[30];

            myDic.Add("1", "하성민");
            myDic.Add("2", "오준환");

            //myDic.Add("0", "하성민");
            //myDic.Add("1", "오준환");


            for (int i = 1;  i <= 2; ++i)
            {
                Console.WriteLine(myDic[i.ToString()]);
            }

        }
    }
}

