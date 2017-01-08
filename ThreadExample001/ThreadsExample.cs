using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class ThreadsExample
    {
        static void Main()
        {
            Writer oWriter1 = new Writer();
            Writer oWriter2 = new Writer();
            Writer oWriter3 = new Writer();

            Thread oThread1 = new Thread(() => oWriter1.WriteSomething("I am the first"));
            Thread oThread2 = new Thread(() => oWriter2.WriteSomething("2222"));
            Thread oThread3 = new Thread(() => oWriter3.WriteSomethingOnce());

            oThread1.Start();
            oThread2.Start();
            oThread3.Start();

            Thread.Sleep(100);

            oThread1.Abort();
            oThread2.Abort();
            oThread3.Abort();
        }
    }
}
