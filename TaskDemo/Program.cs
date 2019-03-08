using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "xxx<a href='URL'>超链接</a>123132456";
            //var length = str.LastIndexOf('\'') - str.IndexOf('\'')-1;
            //var href = str.Substring(str.IndexOf('\'')+1, length);
            //Console.WriteLine(href);

            //var str = "张志强=20016,钟大海=10152,王伟旭=20011,余惠洁=10015,谭建纳=20027,黄玲玲=20076,游伯任=20018,李小臻=20164,刘会梅=10096,彭振武=20123,陈小波=20114,吴平=20144,程剑楠=20145,袁号=20110,叶剑辉=20080,杨望生=20133,张振辉=20077,陈小龙=20061,杨健辉=10159,成小超=20021,邓艳虹=10182,何意梅=10174,叶永强=20125,李文成=20112,梁惠敏=20069,王春岚=10142,周嘉文=20129,张小娟=20093,曾卫明=10121,周健=20116,胡晓兰=10006,赵细英=10082,黄锟华=20103,赖伟强=20141,吴达=20090,冯攀=20046,江俊升=20052,林明龙=20033,刘小峰=20051,罗天桢=20169,王亦恒=20124,陈晓春=10057,吴维晶=20045,杨瑞兰=20167,陆炫志=20089,杨亮=10017,冯高洁=20100,郑耿林=20004,陈烁佳=20096,张子伦=20078,张景恒=20017,覃松荣=20010,劳宝俊=20014,张坤鹏=20152,邱浩铭=20020,梁铭哲=20079,张玉=20104,陈豫强=20031,卢敬石=20097,汪志军=20030,黄绮文=20168,梁名炟=20113,谭云斌=20063,吴优=20071,陈广平=20157,曾佑爱=10001,付金林=20161,龙图=10175,黄东明=10067,李琦=10099,朱风春=10070,许晓雯=10109,王子以=20134,曹晗=20099,徐毓豪=20139,徐杏=20106,张海涛=20001,陈伟华=10170,林泽森=10163,沈立京=20132,陈树仙=10106,黄树忠=20002,黄文丹=10056,黎亚艺=10051,曹卫=10185,池晓东=20003";
            //var strs = str.Split(',');
            //Console.WriteLine(strs.Length);
            //Console.ReadKey();

            //string emailstr = "";//邮箱字符串
            //   var emailList = emailstr.Split('，');//分割
            //   if (emailList != null && emailList.Length > 0)
            //   {
            //       foreach (var email in emailList)
            //       {
            //           Console.WriteLine(email);
            //       }
            //   }
            //Console.ReadKey();


            //Program pro = new Program();
            //pro.TestTask();

            //var testr = pro.TestRetrunTask().Result;
            //Console.WriteLine(testr);

            //pro.TestTaskAsync().GetAwaiter().GetResult();


            //var testr2 = pro.TestRetrunTaskAsync().Result;
            //Console.WriteLine(testr2);

            //Console.ReadKey();


            //for (var i = 1; i <= 9; i++)
            //{
            //    for (var j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{j}*{i}={i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            Asy_ClassA asy = new Asy_ClassA();

            DateTime pbgtime = DateTime.Now;
            for (int i = 0; i < 50; i++)
            {
                asy.MethodC(pbgtime, i);
                Console.WriteLine("普通方法{0}调用完成", i);
            }

            DateTime abgtime = DateTime.Now;
            for (int i = 0; i < 50; i++)
            {
                 asy.MethodA(abgtime, i);
                Console.WriteLine("异步方法{0}调用完成", i);
            }
            Console.ReadKey();
        }























        /// <summary>
        /// 无返回值
        /// </summary>
        /// <returns></returns>
        public Task TestTask()
        {
            Console.WriteLine("TestTask");
            //return Task.FromResult(true);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 有返回值
        /// </summary>
        /// <returns></returns>
        public Task<int> TestRetrunTask()
        {
            Console.WriteLine("TestRetrunTask");
            return Task.FromResult(10);
        }


        /// <summary>
        /// 异步无返回值
        /// </summary>
        /// <returns></returns>
        public async Task TestTaskAsync()
        {
            Console.WriteLine("TestTaskAsync");
          
            await Task.CompletedTask;
        }

        /// <summary>
        /// 异步有返回值
        /// </summary>
        /// <returns></returns>
        public async Task<int> TestRetrunTaskAsync()
        {
            Console.WriteLine("TestRetrunTask");
            return await Task.FromResult(100);
        }
    }
}
