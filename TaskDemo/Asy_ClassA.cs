using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    public  class Asy_ClassA
    {
        //异步方法
        public async Task<int> MethodA(DateTime bgtime, int i)
        {
            int r = await Task.Run(() =>
            {
                Console.WriteLine("异步方法{0}Task被执行", i);
                Thread.Sleep(100);
                return i * 2;
            });
            Console.WriteLine("异步方法{0}执行完毕，结果{1}", i, r);

            if (i == 49)
            {
                Console.WriteLine("用时{0}", (DateTime.Now - bgtime).TotalMilliseconds);
            }
            return r;
        }
        //普通方法
        public int MethodC(DateTime bgtime, int i)
        {
            int r = Task.Run(() =>
            {
                Console.WriteLine("普通多线程方法{0}Task被执行", i);
                Thread.Sleep(100);
                return i * 2;
            }).Result;
            Console.WriteLine("普通方法{0}执行完毕，结果{1}", i, r);

            if (i == 49)
            {
                Console.WriteLine("用时{0}", (DateTime.Now - bgtime).TotalMilliseconds);
            }
            return r;
        }
    }
}
