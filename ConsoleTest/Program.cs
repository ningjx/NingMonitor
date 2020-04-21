﻿using AIDA64Ext.Handlers;
using AIDA64Ext.Helper;
using AIDA64Ext.Models;
using NetWorkSpeedMonitor;
using Newtonsoft.Json;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PCounters.GetAllCategorysInfo("safasf.txt");
            //Console.WriteLine("计数器输出完成，按任意键退出");
            //Console.ReadKey();
            OHMHandler.Start();
            PerformanceHandler.Start();
            while (true)
            {
                Console.Clear();
                PerformanceParams.AllItems.ForEach(t => Console.WriteLine($"{t.Name} {t.Type.ToString()} {t.Value.ToString("f2")}{t.Unit}"));
                Thread.Sleep(1000);
            }
        }

        //static void Main()
        //{
        //    PerformanceCounterCategory[] pcc = PerformanceCounterCategory.GetCategories();
        //    List<string> aa = new List<string>();
        //    
        //    for (int i = 0; i < pcc.Length; i++)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        //if (cn.IndexOf("PROCESSOR") != -1)
        //        {
        //            sb.Append("CategoryName:" + pcc[i].CategoryName + "\r\n");
        //            sb.Append("MachineName:" + pcc[i].MachineName + "\r\n");
        //
        //            List<string> instanceNames = new List<string>();// = pcc[i].GetInstanceNames();
        //            try
        //            {
        //                instanceNames = pcc[i].GetInstanceNames()?.ToList();
        //            }
        //            catch
        //            {
        //
        //            }
        //            if (instanceNames.Count != 0)
        //            {
        //                foreach(string instanceName in instanceNames)
        //                {
        //                    sb.Append("**** Instance Name **********\r\n");
        //                    sb.Append("InstanceName:" + instanceName + "\r\n");
        //
        //                    try
        //                    {
        //                        PerformanceCounter[] counters = pcc[i].GetCounters(instanceName);
        //                        for (int k = 0; k < counters.Length; k++)
        //                        {
        //                            sb.Append("CounterName:" + counters[k].CounterName + "\r\n");
        //                        }
        //                    }
        //                    catch (Exception)
        //                    { }
        //                    sb.Append("**************************************************\r\n");
        //                }
        //            }
        //            aa.Add(sb.ToString());
        //        }
        //
        //    }
        //
        //    var aaa = JsonConvert.SerializeObject(aa);
        //    FileHelper.Write(new string[] { "666.txt" }, aaa);
        //}
    }
}
